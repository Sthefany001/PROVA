using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVA_2bim
{
    public partial class Gabarito : Form
    {
        public Gabarito()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Gabarito_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodo();
        }

         private void Metodo()
         {
            int acertos = 0;
            string[] gab = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };

            try
            {

                if (textBox1.Text.ToUpper() == gab[0])
                {
                    acertos = acertos + 1;
                }

                if (textBox2.Text.ToUpper() == gab[1])
                {
                    acertos = acertos + 1;
                }

                if (textBox3.Text.ToUpper() == gab[2])
                {
                    acertos = acertos + 1;
                }

                if (textBox4.Text.ToUpper() == gab[3])
                {
                    acertos = acertos + 1;
                }

                if (textBox5.Text.ToUpper() == gab[4])
                {
                    acertos = acertos + 1;
                }

                if (textBox6.Text.ToUpper() == gab[5])
                {
                    acertos = acertos + 1;
                }

                if (textBox7.Text.ToUpper() == gab[6])
                {
                    acertos = acertos + 1;
                }

                if (textBox8.Text.ToUpper() == gab[7])
                {
                    acertos = acertos + 1;
                }

                if (textBox9.Text.ToUpper() == gab[8])
                {
                    acertos = acertos + 1;
                }

                if (textBox10.Text.ToUpper() == gab[9])
                {
                    acertos = acertos + 1;
                }


                //MessageBox.Show($"ACERTOS = {acertos.ToString()}");

                label1.Text = acertos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //MessageBox.Show("Obrigada por usar meu programa!");
            }
        }
    }
}
