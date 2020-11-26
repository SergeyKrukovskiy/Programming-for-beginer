using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dialog_windows_this_day
{
    class Program
    {
        static void Main()
        {
            string[] str = Interaction.InputBox("Введите сегодняшнюю дату: ", "Дата?").Split(' ');
            MessageBox.Show(str[0] + " " + str[2] + " " + str[1], "Дата");
        }
    }
}
