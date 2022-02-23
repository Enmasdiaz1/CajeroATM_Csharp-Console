using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenParcial
{
    public interface IValidar
    {
        public bool ValidandoRetorno(int cant);
        public int [] Devuelta(int cant);
        public void Devolviendo();
    }
}
