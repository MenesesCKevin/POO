using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroeApp.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Nombre { get; set; }
        
        string IdentidadSecreta { get; set; }

        string GetSuperHeroe()
        {
            return $"{Nombre}";
        }
    }
}
