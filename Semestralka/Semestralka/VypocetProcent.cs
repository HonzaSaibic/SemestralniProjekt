﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestralka
{
    class VypocetProcent
    {
        public double Procento (double hodnotaParametru, int zadaneCislo)
        {
            double procentoCisla = hodnotaParametru / 100;
            procentoCisla = procentoCisla * zadaneCislo;
            return procentoCisla;
        }
    }
}
