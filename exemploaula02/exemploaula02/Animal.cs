using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploaula02
{
    class Animal
    {
        private int id;
        private string nome;
        private string raça;
        private int idade;
        private int peso;
        private int altura;

        public Animal()
        {
        }

        public Animal(int id, string nome, string raça, int idade, int peso, int altura)
        {
            this.id = id;
            this.nome = nome;
            this.raça = raça;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Raça { get => raça; set => raça = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Altura { get => altura; set => altura = value; }
    }
}
