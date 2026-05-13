using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Automovel
    {
        // criar as propriedades da classe automovel
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidade  { get; set; }
        public string Ano { get; set; }
        public string imagen { get; set; }

        public Automovel() { 
        
        }

        public Automovel(string marca)
        {
             this.Marca = marca;
        }
        
        public string Acelerar(string velocidade) {
            return "Acelerando o carro a " + velocidade;
        }

        public virtual string  Frear()
        {
             return "Freando o carro";
        }

    }
}
