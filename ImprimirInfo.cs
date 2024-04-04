using SuperHeroeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroeApp
{
    internal class ImprimirInfo
    {
        public void ImprimirHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine(superHeroe.GetSuperHeroe());
        }
    }
}
