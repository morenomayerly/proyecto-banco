using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplication.Behaviours;
using aplication.Wrappers;

namespace aplication.Feautres.Clientes.Commands.CreateClienteCommand
{
	public class CreateClienteCommand : IWebRequestcreate<Response<int>>
	{
		public required string Nombre { get; set; }
		public required string Apellido { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public required string Telefono { get; set; }
		public required string Email { get; set; }
		public required string Direccion { get; set; }
	}
	public class Createclientecommandhandler : IReequestHandler<creaateClienteCommand, Response<int>>
	{
		public async Task<Response<int>> HandIe(creaateClienteCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

	}

}
