﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador {
            get { return codigoOperador; }
        }
    }
}