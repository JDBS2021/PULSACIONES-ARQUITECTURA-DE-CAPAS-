﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Identificacion { get; set; }


        public string Sexo { get; set; }
        public int Edad { get; set; }
        public decimal Pulsacion { get; set; }

        public void CalcularPulsacion() 
        {

            if (Sexo.ToUpper().Equals("F"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper().Equals("M"))
            {
                Pulsacion = (210 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }

        }

    }
}
