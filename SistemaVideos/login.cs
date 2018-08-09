using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVideos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(value: "Admin"))
            {
                if (txtContraaseña.Text.Equals(value: "1234"))
                {

                    this.Hide();

                    Menu frm = new Menu();

                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Error de credenciales");

            }

        }
    
    }
}
