using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Cliente : AuditableBaseEntity
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set; }
        public required string Direccion { get; set; }

        public int Edad
        {
            get
            {
                if (FechaNacimiento == default(DateTime))
                    return 0;
                
                return new DateTime(DateTime.Now.Subtract(FechaNacimiento).Ticks).Year - 1;
            }
        }
    }
}
