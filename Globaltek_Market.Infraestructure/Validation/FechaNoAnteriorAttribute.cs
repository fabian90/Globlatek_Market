using System;
using System.ComponentModel.DataAnnotations;
public class FechaNoAnteriorAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is DateTime fecha)
        {
            return fecha >= DateTime.Today;
        }
        return false;
    }
}
