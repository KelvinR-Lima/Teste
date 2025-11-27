using FI.WebAtividadeEntrevista.Services;
using System.ComponentModel.DataAnnotations;

namespace FI.WebAtividadeEntrevista.Attributes
{
    public class CPFAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return CPFService.CPFEhValido(value?.ToString());
        }
    }
}