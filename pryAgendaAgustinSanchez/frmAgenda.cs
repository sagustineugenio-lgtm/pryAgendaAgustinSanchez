using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgendaAgustinSanchez
{
    public partial class frmAgenda : Form
    {


        public frmAgenda()
        {
            InitializeComponent();
        }
        string varContactos;
        string varNumero;
        int vContador = 0;
        int indice = 0;
        

        string[] vecContactos = new string[5];
        string[] vecTelefono = new string[5];
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void txtContactos_TextChanged(object sender, EventArgs e)
        {
            if (txtContactos.Text != "")
            {
                txtNumero.Enabled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtNumero.MaskFull == true)
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           vecContactos[indice] = txtContactos.Text;
           vecTelefono[indice] = txtNumero.Text;
            
            lstItems.Items.Add("Contacto" + varContactos + "Numero" + varNumero);
            txtContactos.Text = "";
            txtNumero.Text = "";

            indice++;
            vContador++;
            txtCantidad.Text = vContador.ToString();
            txtNumero.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void txtNumero_MaskChanged(object sender, EventArgs e)
        {


        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.MaskFull) 
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContactos.Text = "";
            txtNumero.Text = "";
        }

        private void mtbFecha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
