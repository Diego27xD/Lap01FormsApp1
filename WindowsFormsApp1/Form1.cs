using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            if (checkAge.Checked)
            {
                MessageBox.Show("Es mayor de edad");

            }
            else
            {
                MessageBox.Show("Es menor de edad");
            }      

        }

     
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }
    }
}
