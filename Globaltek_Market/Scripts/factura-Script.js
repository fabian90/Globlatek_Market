$(document).ready(function () {
    $("#formCrearDetalle").submit(function (event) {
        event.preventDefault(); // Evitar el envío del formulario por defecto.
        var formData = $(this).serialize(); // Serializar los datos del formulario.
        $.ajax({
            type: "POST",
            url: "/Factura/CrearDetalle",
            data: formData,
            dataType: "json",
            success: function (result) {
                console.log(JSON.stringify(result));
                // Maneja la respuesta del servidor aquí, por ejemplo, puedes mostrar un mensaje de éxito.
                var nuevaFila = $("<tr>");
                nuevaFila.append($("<td>").text(result.detalle.IdDetalle));
                nuevaFila.append($("<td>").text(result.detalle.IdFactura));
                nuevaFila.append($("<td>").text(result.producto.Nombre));
                nuevaFila.data("idproducto", result.detalle.IdProducto);
                nuevaFila.append($("<td>").text(result.detalle.Cantidad));
                nuevaFila.append($("<td>").text(result.detalle.PrecioUnitario));
                nuevaFila.append($("<td>").text(result.detalle.Cantidad * result.detalle.PrecioUnitario));
                var botonEliminar = '<button class="btn btn-danger eliminar-detalle" data-detalle-id="' + result.detalle.IdDetalle + '">Eliminar</button>';
                nuevaFila.append($(" <td>").html(botonEliminar));
                $("#tablaDetalles tbody").append(nuevaFila);
                alert("Detalle creado correctamente.");
                // Limpiar campos
                $("#IdProducto").val(""); // Reemplaza "#IdProducto" con el ID de tu campo
                $("#Cantidad").val("");    // Reemplaza "#Cantidad" con el ID de tu campo
                $("#PrecioUnitario").val(""); // Reemplaza "#PrecioUnitario" con el ID de tu campo
                calcularSubTotalDetalle()
            },
            error: function (error) {
                // Maneja cualquier error que ocurra durante la solicitud AJAX.
                alert("Ocurrió un error al crear el detalle.");
            }
        });
    });
});


$(document).ready(function () {
    $("#formCrearFactura").submit(function (event) {
        event.preventDefault(); // Evitar el envío del formulario por defecto.
        $("#TotalDescuento").prop("disabled", false);
        $("#Subtotal").prop("disabled", false);
        $("#TotalImpuesto").prop("disabled", false);
        $("#Total").prop("disabled", false);
        var formData = $(this).serialize(); // Serializar los datos del formulario.
        console.log(JSON.stringify("Crear factura: " + formData));
        $.ajax({
            type: "POST",
            url: "/Factura/Create",
            data: formData,
            dataType: "json",
            success: function (result) {
                $("#TotalDescuento").prop("disabled", true);
                $("#Subtotal").prop("disabled", true);
                $("#TotalImpuesto").prop("disabled", true);
                $("#Total").prop("disabled", true);
                console.log("Resultado: " + JSON.stringify(result));
                if (result.success === false) {
                    if (result.errors && result.errors.length > 0) {
                        // Limpiar y mostrar la lista de errores en el modal
                        $('#errorList').empty();
                        $.each(result.errors, function (index, error) {
                            $('#errorList').append('<li>' + error + '</li>');
                        });

                        // Mostrar el modal de errores
                        $('#errorModal').modal('show');
                    }
                }
                if (result.ultimaFac != 0) {
                    console.log("factura: " + result.ultimaFac)
                    $("#NumeroFactura").val(result.ultimoNumFact);
                    Actualizados(result.ultimoNumFact);
                }
            },
            error: function (xhr, textStatus, errorThrown) {
                console.log("estatus: " + xhr.status);
                if (xhr.status === 400) {
                    var response = xhr.responseJSON;
                    if (response.errors && response.errors.length > 0) {
                        // Manejar los errores, por ejemplo, mostrarlos en una alerta
                        var errorMessage = response.errors.join('\n');
                        alert(errorMessage);
                    }
                } else {
                    // Otra lógica de manejo de errores si es necesario
                    alert('Error en la solicitud.');
                }
                $("#TotalDescuento").prop("disabled", true);
                $("#Subtotal").prop("disabled", true);
                $("#TotalImpuesto").prop("disabled", true);
                $("#Total").prop("disabled", true);
            }
        });
    });
});


function Actualizados(idfactura) {
    console.log("Si pasa: " + idfactura);
    // Obtener los datos de la tabla y convertirlos a un formato que puedas enviar al controlador
    var datos = [];
    $("#tablaDetalles tbody tr").each(function () {
        var fila = $(this);
        var dato = {
            IdDetalle: parseInt(fila.find("td:eq(0)").text()), // ID en la primera columna
            //IdFactura: fila.find("td:eq(1)").text(), // Factura en la segunda columna
            IdFactura: parseInt(idfactura), // Factura en la segunda columna
            //Producto: fila.find("td:eq(2)").text(), // Producto en la tercera columna
            IdProducto: parseInt(fila.data("idproducto")),
            Cantidad: parseInt(fila.find("td:eq(3)").text()), // Cantidad en la cuarta columna
            PrecioUnitario: parseInt(fila.find("td:eq(4)").text()) // Precio Unitario en la quinta columna
        };
        datos.push(dato);
    });

    console.log("Actualizar: " + JSON.stringify(datos));
    // Realiza una solicitud AJAX para enviar los datos al controlador
    $.ajax({
        url: "/Factura/ActualizarDetalle",
        type: "POST",
        data: JSON.stringify({ detalles: datos }),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        traditional: true,
        success: function (result) {

            // Recorre la tabla para encontrar la fila correspondiente al IdFactura y actualízala
            $("#tablaDetalles tbody tr").each(function () {
                var fila = $(this);
                var idFacturaEnFila = fila.find("td:eq(1)").text(); // Suponiendo que el IdFactura esté en la segunda columna                      
                fila.find("td:eq(1)").text(idfactura); // Suponiendo que el IdProducto esté en la tercera columna
            });
            alert("la factura fue generada exitosamente con el N: " + idfactura);
            console.log("actualizado");
        },
        error: function () {
            console.log("Erro al actualizar");
            // Maneja errores
        }
    });
}



$(document).ready(function () {
    $("#limpiarCamposFactura").click(function () {
        $("#NumeroFactura").val("");
        $("#Fecha").val("");
        $("#DocumentoCliente").val("");
        $("#NombreCliente").val("");
        $("#Subtotal").val("");
        $("#Descuento").val("");
        $("#Impuesto").val("");
        $("#TotalDescuento").val("");
        $("#TotalImpuesto").val("");
        $("#Total").val("");
        $("#TipoDePago").val("");
        var filas = $("#tablaDetalles tbody tr");
        filas.each(function () {
            var fila = $(this);
            var idFactura = fila.find("td:eq(1)").text(); 

            // Validar que el campo ID Factura no esté vacío para cada fila
            if (idFactura.trim() !== "") {
                fila.remove();
            }
        });
        //$("#tablaDetalles tbody").empty();
    });
});


function validarFila(idFactura) {
    if (idFactura.trim() !== "") {
        return true; 
    } else {
        return false;
    }
}
// Manejar el clic en el botón "Eliminar"
$(document).on("click", ".eliminar-detalle", function () {
    var detalleId = $(this).data("detalle-id");
    var fila = $(this).closest("tr"); // Guarda una referencia a la fila actual
    console.log("Id= " + detalleId);
    $.ajax({
        url: "/Factura/EliminarDetalle",
        type: "GET",
        data: { idDetalle: detalleId },
        success: function (result) {
            if (result.success) {
                console.log("Si entra");
                fila.remove();
                // Eliminar la fila de la tabla
                calcularSubTotalDetalle()

            }
        },
        error: function () {
            alert("Error al eliminar el detalle.");
        }
    });
});

$(document).ready(function () {
    // Selector del campo Descuento por su identificador
    var descuentoField = $("#Descuento");
    var impuestoField = $("#Impuesto");

    // Evento keyup para validar y guardar cuando el usuario escribe en el campo
    descuentoField.on("keyup", function () {
        var descuentoValue = parseFloat($(this).val());

        // Verificar si el valor es un número válido (no negativo)
        if (isNaN(descuentoValue) || descuentoValue < 0) {
            alert("El descuento debe ser un número válido y no puede ser negativo.");
            $(this).val(""); // Limpia el campo
        } else {
            calcularSubTotalFactura();
        }
    });

    impuestoField.on("keyup", function () {
        var impuestoValue = parseFloat($(this).val());

        // Verificar si el valor es un número válido (no negativo)
        if (isNaN(impuestoValue) || impuestoValue < 0) {
            alert("El impuesto debe ser un número válido y no puede ser negativo.");
            $(this).val(""); // Limpia el campo
        } else {
            calcularSubTotalFactura();
        }
    });

    // Selector del campo Fecha por su identificador
    var fechaField = $("#Fecha");
    fechaField.on("blur", function () {
        // Obtener la fecha actual en el formato local del usuario
        var fechaActual = new Date();
        var fechaActualLocal = fechaActual.toLocaleDateString();

        // Obtener la fecha ingresada en el campo
        var fechaIngresada = new Date(fechaField.val());
        fechaIngresada.setDate(fechaIngresada.getDate() + 1);
        // Convertir la fecha ingresada al formato local del usuario
        var fechaIngresadaLocal = fechaIngresada.toLocaleDateString();
        console.log("fecha ingresada: " + fechaIngresada + "fecha actual : " + fechaActual)
        if (fechaIngresadaLocal < fechaActualLocal) {
            alert("La fecha no puede ser anterior al día actual en tu ubicación.");
            fechaField.val("");
        }
    });
    // Validar numerico
    $("#Cantidad").on("input", function () {
        var inputValue = $(this).val();
        // Limpiar cualquier caracter no numérico o negativo
        inputValue = inputValue.replace(/[^0-9]/g, "");
        // Actualizar el valor del campo de entrada
        $(this).val(inputValue);
    });

    // Validar numerico
    $("#DocumentoCliente").on("input", function () {
        var inputValue = $(this).val();
        // Limpiar cualquier caracter no numérico o negativo
        inputValue = inputValue.replace(/[^0-9]/g, "");
        // Actualizar el valor del campo de entrada
        $(this).val(inputValue);
    });

    $("#Impuesto").on("input", function () {
        var inputValue = $(this).val();
        // Limpiar cualquier caracter no numérico o negativo
        inputValue = inputValue.replace(/[^0-9]/g, "");
        // Actualizar el valor del campo de entrada
        $(this).val(inputValue);
    });
    $("#Descuento").on("input", function () {
        var inputValue = $(this).val();
        // Limpiar cualquier caracter no numérico o negativo
        inputValue = inputValue.replace(/[^0-9]/g, "");
        // Actualizar el valor del campo de entrada
        $(this).val(inputValue);
    });

    $("#PrecioUnitario").on("input", function () {
        var inputValue = $(this).val();
        // Limpiar cualquier caracter no numérico o negativo
        inputValue = inputValue.replace(/[^0-9]/g, "");
        // Actualizar el valor del campo de entrada
        $(this).val(inputValue);
    });

});


function calcularSubTotalFactura() {
    // Selector de los campos Descuento e Impuesto por sus identificadores
    var descuentoField = $("#Descuento");
    var impuestoField = $("#Impuesto");
    var totalField = $("#Total");

    var descuento = parseFloat(descuentoField.val()) || 0; // Valor del descuento o 0 si no es un número válido
    var impuesto = parseFloat(impuestoField.val()) || 0; // Valor del impuesto o 0 si no es un número válido

    // Realizar cálculos
    var subtotal = parseFloat($("#Subtotal").val()) || 0; // Obtener el subtotal de algún campo en el formulario
    var totalDescuento = subtotal * (descuento / 100);
    var totalImpuesto = subtotal * (impuesto / 100);
    var total = subtotal - totalDescuento + totalImpuesto;

    // Actualizar los campos en el formulario
    $("#TotalDescuento").val(Math.round(totalDescuento)); // 2 decimales para el total de descuento
    $("#TotalImpuesto").val(Math.round(totalImpuesto)); // 2 decimales para el total de impuesto
    //totalField.val(total.toFixed(2).replace(",", ".")); // 2 decimales para el total
    totalField.val(Math.round(total));
}

// Función para calcular el total de la factura
function calcularSubTotalDetalle() {
    var total = 0;
    $("#tablaDetalles tbody tr").each(function () {
        var subtotal = parseFloat($(this).find("td:eq(5)").text());
        total += subtotal;
    });
    // Actualizar el campo Total en el formulario principal
    $("#Subtotal").val(Math.round(total));
    calcularSubTotalFactura()
}