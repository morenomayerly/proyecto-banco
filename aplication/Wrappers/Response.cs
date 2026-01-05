using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplication.Wrappers
{
	public class Response<T>
	{
		public Response()
		{
			Succeeded = false;
			Errors = new List<string>();
		}

		public Response(T data, string? message = null)
		{
			Succeeded = true;
			Message = message;
			Data = data;
			Errors = new List<string>();
		}

		public Response(string message)
		{
			Succeeded = false;
			Message = message;
			Errors = new List<string>();
		}

		public bool Succeeded { get; set; }
		public string? Message { get; set; }
		public List<string> Errors { get; set; }
		public T? Data { get; set; }
	}
}
