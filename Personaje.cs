using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Personaje
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string origen;
        private string raza;
        private bool magia;
        private string territorios;

        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string Origen { get; set; }
        public string Raza { get; set; }
        public bool Magia { get; set; }
        public string Territorios { get; set; }

    }
}
