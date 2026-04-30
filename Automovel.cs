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
        public int Ano { get; set; }
        public string imagen { get; set; }

        /*  
          private string Marca;

          public void SetMarca(string marca) {
                  Marca = marca;
          }

          public string GetMarca() {
               return Marca;
          }
         */

        // criar um constructor para a classe automovel
        public Automovel() { 
        
        }

        public Automovel(string marca)
        {
             this.Marca = marca;
        }

    }
}
