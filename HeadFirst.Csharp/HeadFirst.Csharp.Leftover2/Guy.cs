using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst.Csharp.Leftover2
{
    /// <summary>
    /// Um cara com nome, idade e uma carteira cheia de dinheiro.
    /// </summary>
    public class Guy
    {
        /// <summary>
        /// Campo de armazenamento de apenas leitura para a propriedade Name.
        /// </summary>
        private readonly string name;

        /// <summary>
        /// O nome do cara.
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Campo de armazenamento de apenas leitura para a propriedade Age.
        /// </summary>
        private readonly int age;

        /// <summary>
        /// A idade do cara.
        /// </summary>
        public int Age { get { return age; } }

        /*
         * Dinheiro não é readonly porque pode mudar durante a vida do cara.
         */
        
        /// <summary>
        /// O número de reais que o cara tem.
        /// </summary>
        public int Cash { get; private set; }

        /// <summary>
        /// O construtor define o nome, a idade e dinheiro.
        /// </summary>
        /// <param name="name">O nome do cara.</param>
        /// <param name="age">A idade do cara.</param>
        /// <param name="cash">A quantidade de dinheiro que o cara começa.</param>
        public Guy(string name, int age, int cash)
        {
            this.name = name;
            this.age = age;
            Cash = cash;
        }
                
        public override string ToString()
        {
            return String.Format("{0} is {1} years old and has {2} bucks", Name, Age, Cash);
        }

        /// <summary>
        /// Dar dinheiro da carteira do cara.
        /// </summary>
        /// <param name="amount">Quantidade de dinheiro para entregar.</param>
        /// <returns>A quantidade de dinheiro entregue, ou 0 se não tiver dinheiro suficiente.</returns>
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Receber algum dinheiro na carteira do cara.
        /// </summary>
        /// <param name="amount">Quantidade de dinheiro a receber.</param>
        /// <returns>Quantidade recebida, ou 0 se nenhum dinheiro for recebido.</returns>
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            return 0;
        }

    }
}
