using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroeApp.Models
{
    class SuperHeroe
    {
        public int Id = 1;
        public string Nombre;
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
                sb.Append($"{Nombre} esta usando el superpoder {item.Nombre}!! \n");
            }
            return sb.ToString();
        }
    }
}
