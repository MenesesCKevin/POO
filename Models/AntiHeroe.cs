using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroeApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDEAntiheroe (string accion)
        {
            return $"El antiheroe {NombreEIdentidadSecreta} ha realizado {accion}";
        }
    }
}
