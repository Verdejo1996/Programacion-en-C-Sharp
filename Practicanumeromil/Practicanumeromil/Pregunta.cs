﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicanumeromil
{
    internal class Pregunta
    {
        public int id {  get; set; }
        public string pregunta { get; set; }

        public List<Respuesta> respuesta { get; set; }
    }
}
