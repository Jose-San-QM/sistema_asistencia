using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {


    }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            inicio form = new inicio();

            form.Show();
            this.Hide();
            form.FormClosing += frm_closing;
        }

        private  void frm_closing(object sender, FormClosingEventArgs e)
        {
            txt_clave.Text = "";
            txt_usu.Text = "";
            this.Show();
        }
            
    }
}
