using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Globaltek_Market.Business.Implementation;
using Globaltek_Market.Business.Interface;
using Globaltek_Market.Infraestructure.Data;
using Globaltek_Market.Infraestructure.Dtos;
using Globaltek_Market.Infraestructure.Entities;

namespace Globaltek_Market.Controllers
{
    public class FacturaController : Controller
    {
        private globaltekDBContext db = new globaltekDBContext();
        IProductoBusiness _productoBusiness = new ProductoBusiness();
        IFacturaBusiness _facturaBusiness= new FacturaBusiness();
        IDetalleBusiness _detalleBusiness = new DetalleBusiness();
        // GET: Factura
        public ActionResult Index()
        {
            var factura = _facturaBusiness.Consultar().Result;
            return View(factura);
        }

        // GET: Factura/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaDto facturaDto =  _facturaBusiness.ConsultarFacturaPorId(id).Result;
            if (facturaDto == null)
            {
                return HttpNotFound();
            }
            return View(facturaDto);
        }

        // GET: Factura/Create
        public ActionResult Create()
        {
            var opcionesTipoDePago = new SelectList(new[]
            {
                new { Id = "Contado", Nombre = "Contado" },
                new { Id = "Credito", Nombre = "Crédito" }
            }, "Id", "Nombre");
            ViewBag.OpcionesTipoDePago = opcionesTipoDePago;
            ViewBag.Productos = new SelectList(_productoBusiness.Consultar().Result, "IdProducto", "Nombre");
            return View("CreateOrEdit");
            //return View();
        }

        // POST: Factura/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create([Bind(Include = "IdFactura,NumeroFactura,Fecha,TipoDePago,DocumentoCliente,NombreCliente,Subtotal,Descuento,IVA,TotalDescuento,TotalImpuesto,Total")] FacturaDto facturaDto)
        {
            string ultimoNumeroFactura = "0";
            if (ModelState.IsValid)
            {
                if (facturaDto.Fecha < DateTime.Today)
                {
                    // La fecha es anterior al día actual, agrega un error de validación.
                    ModelState.AddModelError("Fecha", "La fecha no puede ser anterior al día actual.");
                    //return View("CreateOrEdit", facturaDto);
                    return Json(new { success = false, message = "La fecha no puede ser anterior al día actual.", ultimaFac = ultimoNumeroFactura });
                }
                  List<FacturaDto> UltimaFacturas = _facturaBusiness.Consultar().Result.ToList();

                 ultimoNumeroFactura = ObtenerUltimoNumeroFactura(UltimaFacturas);
                if (ultimoNumeroFactura != null)
                    {
                        Console.WriteLine("El último número de factura es: " + ultimoNumeroFactura);
                         facturaDto.NumeroFactura=ultimoNumeroFactura;
                    }
                    else
                    {
                        Console.WriteLine("No hay facturas en la lista.");
                    }
                int ultimoIdFactura= _facturaBusiness.Guardar(facturaDto).Result.IdFactura;
                //return RedirectToAction("Create");
                return Json(new { success = true, message = "Factura creada o actualizada exitosamente",ultimaFac= ultimoIdFactura,ultimoNumFact= ultimoNumeroFactura });
            }
            var opcionesTipoDePago = new SelectList(new[]
           {
                new { Id = "Contado", Nombre = "Contado" },
                new { Id = "Credito", Nombre = "Crédito" }
            }, "Id", "Nombre");

            ViewBag.OpcionesTipoDePago = opcionesTipoDePago;
            ViewBag.Productos = new SelectList(_productoBusiness.Consultar().Result, "IdProducto", "Nombre");
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            return Json(new { success = false, errors = errors, ultimaFac = ultimoNumeroFactura });
            //return View("CreateOrEdit",facturaDto);
        }

        // GET: Factura/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaDto facturaDto =  _facturaBusiness.ConsultarFacturaPorId(id).Result;
            if (facturaDto == null)
            {
                return HttpNotFound();
            }
            var opcionesTipoDePago = new SelectList(new[]
            {
                new { Id = "Contado", Nombre = "Contado" },
                new { Id = "Credito", Nombre = "Crédito" }
            }, "Id", "Nombre");
            ViewBag.OpcionesTipoDePago = opcionesTipoDePago;
            return View("CreateOrEdit",facturaDto);
        }

        // POST: Factura/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdFactura,NumeroFactura,Fecha,TipoDePago,DocumentoCliente,NombreCliente,Subtotal,Descuento,IVA,TotalDescuento,TotalImpuesto,Total")] FacturaDto facturaDto)
        {
            if (ModelState.IsValid)
            {
                if (facturaDto.Fecha < DateTime.Today)
                {
                    // La fecha es anterior al día actual, agrega un error de validación.
                    ModelState.AddModelError("Fecha", "La fecha no puede ser anterior al día actual.");
                    return View("CreateOrEdit", facturaDto);
                }
                db.Entry(facturaDto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var opcionesTipoDePago = new SelectList(new[]
            {
                new { Id = "Contado", Nombre = "Contado" },
                new { Id = "Credito", Nombre = "Crédito" }
            }, "Id", "Nombre");

            ViewBag.OpcionesTipoDePago = opcionesTipoDePago;
            return View("CreateOrEdit",facturaDto);
        }

        // GET: Factura/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacturaDto facturaDto = _facturaBusiness.ConsultarFacturaPorId(id).Result;
            if (facturaDto == null)
            {
                return HttpNotFound();
            }
            return View(facturaDto);
        }

        // POST: Factura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _productoBusiness.Eliminar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult CrearDetalle(DetalleDto detalle)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Realiza las operaciones de creación de detalle en la base de datos
                  var respuesta=_detalleBusiness.Guardar(detalle).Result;
                    var productById = _productoBusiness.ConsultarProductoPorId(respuesta.IdProducto).Result;
                    // Puedes devolver un objeto JSON con un mensaje de éxito
                    return Json(new { success = true, 
                        message = "Detalle creado con éxito.",
                        detalle=respuesta,
                        producto= productById
                    });
                }
                catch (Exception ex)
                {
                    // En caso de error, puedes devolver un objeto JSON con un mensaje de error
                    return Json(new { success = false, message = "Error al crear el detalle: " + ex.Message });
                }
            }
            else
            {
                // Si la validación falla, devolver un objeto JSON con los errores de validación
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return Json(new { success = false, message = "Error de validación", errors = errors });
            }
        }
        [HttpGet]
        public JsonResult EliminarDetalle(int idDetalle)
        {
            if (idDetalle !=0)
            {
                var facturaDto = _detalleBusiness.Eliminar(idDetalle).Result;
                if (facturaDto == null)
                {
                    return Json(new { success = false }, JsonRequestBehavior.AllowGet);
                }
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public JsonResult ActualizarDetalle(List<DetalleDto> detalles)
        {
            try
            {
                if (detalles != null)
                {
                    foreach (var detalle in detalles)
                    {
                        _detalleBusiness.Actualizar(detalle);
                    }

                    return Json(new { success = true, message = "Detalles actualizados correctamente" });
                }
                else
                {
                    return Json(new { success = false, message = "Sin datos para actualizar" });
                }

            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error al actualizar detalles: " + ex.Message });
            }
        }

        static string ObtenerUltimoNumeroFactura(List<FacturaDto> facturas)
        {
            string ultimoNumeroFactura = facturas.LastOrDefault()?.NumeroFactura;

            if (string.IsNullOrEmpty(ultimoNumeroFactura))
            {
                // Si la lista está vacía o no hay números válidos, puedes asignar el primer número
                return "F001";
            }

            // Extraer el número de factura y convertirlo a un número entero
            if (int.TryParse(ultimoNumeroFactura.Substring(1), out int ultimoNumero))
            {
                // Incrementar el número en 1 y formatearlo nuevamente como cadena
                string nuevoNumeroFactura = "F" + (ultimoNumero + 1).ToString("D3");
                return nuevoNumeroFactura;
            }

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
