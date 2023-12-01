using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Añodelanzamiento { get; set; }
        public void NodoCarro (string marca, string modelo, int añodelanzamiento)
        {
            Marca = marca;
            Modelo = modelo;
            Añodelanzamiento = añodelanzamiento;
        }
    }
}
