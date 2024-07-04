using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Alumno
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public string Email { get; set; }
        public string  Foto { get; set; }
        public int IdCurso { get; set; }
        public  DateTime FechaAlta { get; set; }

        public DateTime FechaBaja { get; set; }

    }
}
