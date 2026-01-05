using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplication.Wrappers;
using Domain.Entities;
using MediatR;

namespace aplication.Feautres.Clientes.Commands.CreateClienteCommand
{
	public class CreateClienteCommand : IRequest<Response<int>>
	{
		public required string Nombre { get; set; }
		public required string Apellido { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public required string Telefono { get; set; }
		public required string Email { get; set; }
		public required string Direccion { get; set; }
	}
	
	public class CreateClienteCommandHandler : IRequestHandler<CreateClienteCommand, Response<int>>
	{
		public async Task<Response<int>> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
		{
			// TODO: Implementar lógica de creación de cliente
			var cliente = new Cliente
			{
				Nombre = request.Nombre,
				Apellido = request.Apellido,
				FechaNacimiento = request.FechaNacimiento,
				Telefono = request.Telefono,
				Email = request.Email,
				Direccion = request.Direccion
			};
			
			// Aquí iría la lógica para guardar en base de datos
			return await Task.FromResult(new Response<int>(1, "Cliente creado exitosamente"));
		}
	}
}
