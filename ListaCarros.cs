using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR
{
    class ListaCarros
    {
        private Nodo primero;
        Nodo Siguiente;
        public ListaCarros()
        {
            primero = null;
        }
        public void AgregarCarro(Carro carro)
        {
            Nodo nodo = new Nodo(carro);
            nodo.Siguiente = primero;
            primero = nodo;
        }
        public void Agregarfinalcarro(Carro carro1)
        {
            Nodo nodof = new Nodo(carro1);
            //nodo.Siguiente = primero;
            //primero = nodo;
            if (primero != null)
            {
                primero.Siguiente = nodof;
            }
        }
        public void 
        
    }
}
