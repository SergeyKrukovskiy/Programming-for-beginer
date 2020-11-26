using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Programming_for_beginer
{
    class Program
    {
        static void Main()
        {
            string firstname = Interaction.InputBox("Как вас зовут?", "Введите имя...");
            string lastname = Interaction.InputBox("Как ваша фамилия?", "Введите фамилию...");
            MessageBox.Show("Здравствуйте " + firstname + " " + lastname,"Приятно познакомится!");
        }
    }
}
