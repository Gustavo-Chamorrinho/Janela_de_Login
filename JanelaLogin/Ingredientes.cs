using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanelaLogin
{
    internal class Ingredientes
    {
        string ingrediente;

        public Ingredientes(string ingrediente)
        {
            this.ingrediente = ingrediente;
        }

        public string Ingrediente { get => ingrediente; set => ingrediente = value; }


    }
}
