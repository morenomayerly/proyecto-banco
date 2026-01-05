using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace aplication.Wrappers
{
	public class Response<T>
	{
		public Response()
		{
			succeeded = false;
		}

		public Response(T data, string? message = null)
		{
			succeeded = true;
			this.message = message;
			Data = data;
		}

		public Response(string message)
		{
			succeeded = false;
			this.message = message;
		}

		public bool succeeded { get; set; } = false;
		public string? message { get; set; }
		public List<string> Errors { get; set; } = new();
		public T? Data { get; set; }
	}



}
    
