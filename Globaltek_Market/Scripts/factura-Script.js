
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