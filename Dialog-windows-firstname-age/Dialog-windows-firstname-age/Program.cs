using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dialog_windows_firstname_age
{
    class Program
    {

        static void Main()
        {
            string firstname = Interaction.InputBox("Как вас зовут?", "Введите имя...");
            string age = Interaction.InputBox("Сколько вам лет?", "Введите фамилию...");
            MessageBox.Show("Здравствуйте " + firstname + " " + age + " лет.", "Приятно познакомится!");
        }
    }
}
