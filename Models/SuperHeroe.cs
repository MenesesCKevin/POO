﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroeApp.Interfaces;
namespace SuperHeroeApp.Models
{
    class SuperHeroe: Heroe, ISuperHeroe
    {
        private string _Nombre;
        public int Id { get; set; } = 1;
        public override string Nombre {
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

        public string IdentidadSecreta { get; set; }
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

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            //return base.SalvarLaTierra();
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }
}
