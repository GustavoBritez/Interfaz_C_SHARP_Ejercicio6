using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Ejercicio_6 : Form
    {
        private List<int> Fibonacci = new List<int>();
        public Ejercicio_6()
        {
            InitializeComponent();
        }

        private void BTN_Comenzar_Click_1(object sender, EventArgs e)
        {
            int num = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero"));
            while (num < 0)
            {
                num = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero POSITIVO"));
            }
           
            for(int i = 0; i<num; i++)
            {
                Fibonacci.Add(Fibo(i));
            }

            TX_1.Text = string.Join(" ", Fibonacci);


        }
        private int Fibo(int n)
        {
            if (n <= 1)
           {
                return n;
           }
           else
           {
                return Fibo(n - 1) + Fibo(n - 2);
          }
        }

        private void TX_1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
