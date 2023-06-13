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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_gabarito_Click(object sender, EventArgs e)
        {
            Gabarito g = new Gabarito();
            g.ShowDialog();
        }
    }
}
