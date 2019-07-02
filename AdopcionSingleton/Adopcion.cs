﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionSingleton
{
    class Adopcion: Perro
    {
        public Persona PersonaAdopta { set; get; }
        public Perro PerroAdoptado { set; get; }
        public DateTime FechaAdopcion
        {
            get
            {
                return DateTime.Now;
            }
        }
    }

}
