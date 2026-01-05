using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace aplication.Exceptions
{
    public class validationException : Exception
    {
        public validationException() : base("se han producido uno o mas errores de validacion")
        {
            errors = new List<string>();

        }
        public List<string> errors { get; }
        public validationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var item in failures)
            {
                errors.Add(item.ErrorMessage);
            }
        }
    }
}
        
