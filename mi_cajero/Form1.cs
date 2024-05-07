using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mi_cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //este comando permite limpiar el texto cuando le das clic al boton 
        private void button11_Click(object sender, EventArgs e)
        {
            cuenta.Clear();
            nip.Clear();
        }

        //este comando se repetirá en todos los botones de números para que nos permita escribitr el número elegido al darle clic 
        private void button1_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "1";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "2";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "3";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "4";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "5";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "6";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "7";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "8";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "9";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (cuenta.TextLength < 5)
            {
                cuenta.Text += "0";
                if (nip.TextLength < 4)
                {
                    nip.Text += "";
                }
            }
            else
            {
                if (nip.TextLength < 4)
                {
                    nip.Text += "0";
                }
            }
        }

        //este comando permite cerrar la aplicación al picarle clic al boton de x
        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
