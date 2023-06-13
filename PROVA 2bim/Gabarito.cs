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
            int acertos = 0;

            string[] gab = {"A", "B", "D", "E", "C", "A", "A", "D", "E", "B", "a", "b", "d", "e", "c", "a", "a", "d", "e", "b"};
            
            try
            {
                if (textBox1.Text == gab[0])
                {
                    acertos = acertos + 1;
                }
                else if (textBox2.Text == gab[1])
                {
                    acertos = acertos + 1;
                }
                else if (textBox3.Text == gab[2])
                {
                    acertos = acertos + 1;
                }
                else if (textBox4.Text == gab[3])
                {
                    acertos = acertos + 1;
                }
                else if (textBox5.Text == gab[4])
                {
                    acertos = acertos + 1;
                }
                else if (textBox6.Text == gab[5])
                {
                    acertos = acertos + 1;
                }
                else if (textBox7.Text == gab[6])
                {
                    acertos = acertos + 1;
                }
                else if (textBox8.Text == gab[7])
                {
                    acertos = acertos + 1;
                }
                else if (textBox9.Text == gab[8])
                {
                    acertos = acertos + 1;
                }
                else if (textBox10.Text == gab[9])
                {
                    acertos = acertos + 1;
                }
                if (textBox1.Text == gab[10])
                {
                    acertos = acertos + 1;
                }
                else if (textBox2.Text == gab[11])
                {
                    acertos = acertos + 1;
                }
                else if (textBox3.Text == gab[12])
                {
                    acertos = acertos + 1;
                }
                else if (textBox4.Text == gab[13])
                {
                    acertos = acertos + 1;
                }
                else if (textBox5.Text == gab[14])
                {
                    acertos = acertos + 1;
                }
                else if (textBox6.Text == gab[15])
                {
                    acertos = acertos + 1;
                }
                else if (textBox7.Text == gab[16])
                {
                    acertos = acertos + 1;
                }
                else if (textBox8.Text == gab[17])
                {
                    acertos = acertos + 1;
                }
                else if (textBox9.Text == gab[18])
                {
                    acertos = acertos + 1;
                }
                else if (textBox10.Text == gab[19])
                {
                    acertos = acertos + 1;
                }
                else
                {
                    acertos = acertos + 0;
                }
                MessageBox.Show($"ACERTOS = {acertos.ToString()}");

                label1.Text = acertos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO!{ex.Message}");
            }
            finally
            {
                //MessageBox.Show("Obrigada por usar meu programa!");
            }

           
        }
    }
}
