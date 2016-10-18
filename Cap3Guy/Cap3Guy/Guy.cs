using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap3Guy
{
    /// <summary>
    /// Uma classe que representa um cara com nome, idade e carteira cheia de dinheiro.
    /// </summary>
    class Guy
    {
        /// <summary>
        /// Campo para armazenar o nome do cara
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// Campo para armazenar a quantidade em dinheiro do cara na carteira
        /// </summary>
        public int Cash;

        /// <summary>
        /// Método para retirar dinheiro da carteira do cara
        /// </summary>
        /// <param name="amount">Valor a ser retirado</param>
        /// <returns>O valor removido ou 0 se não tiver dinheiro suficiente.</returns>
        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(Name + " diz: Eu não tenho dinheiro suficiente para dar a você " + amount);
                return 0;
            }
        }

        /// <summary>
        /// Método para receber dinheiro na carteira do cara.
        /// </summary>
        /// <param name="amount">Valor a receber</param>
        /// <returns>O valor recebido ou 0 se não for um valor válido</returns>
        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(Name + " diz: " + amount + " não é um valor que eu possa levar");
                return 0;
            }
        }
    }
}
