using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroeApp.Models
{
    class SuperHeroe
    {
        private string _Nombre;
        public int Id = 1;
        public string Nombre {
            get { 
                return _Nombre;
            }
            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreEIdentidadSecreta { get {
                return $"{Nombre} ({IdentidadSecreta})";
            } }

        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
        public bool PuedeVolar = false;


        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }
        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.Append($"{NombreEIdentidadSecreta} esta usando el superpoder {item.Nombre}!! \n");
            }
            return sb.ToString();
        }
    }
}
