using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace aplication.Behaviours
{
	public class Validator<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
	{
		private readonly IEnumerable<IValidator<TRequest>> _validators = Enumerable.Empty<IValidator<TRequest>>();

       
       

        public Validator(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        public override bool Equals(object? obj)
        {
            return obj is Validator<TRequest, TResponse> validator &&
                   EqualityComparer<IEnumerable<IValidator<TRequest>>>.Default.Equals(_validators, validator._validators);
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationtoken, RequestHandIerDelegate<TResponse> next)
		{
            if (_validators.Any())
            {
                var context = new FluentValidation.ValidationContext<TRequest>(request);
                var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationtoken)));
                var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
                if (failures.Count != 0)
                    throw new Exceptions.validationException();
                 
            }
            return await next.Invoke();
		}

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}



       
    

 