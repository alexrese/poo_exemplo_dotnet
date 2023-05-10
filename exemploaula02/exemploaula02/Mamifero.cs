using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploaula02
{
    class Mamifero:Animal
    {
        public bool pelos { get; set; }

        public Mamifero(bool pelos, int id, string nome, string raça, int idade, int peso, int altura) : base(id, nome, raça, idade, peso, altura)
        {
            this.pelos = pelos;
        }

        public Mamifero()
        {
        }
    }
}
