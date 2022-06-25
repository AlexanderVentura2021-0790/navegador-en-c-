using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form

    {

        List<string> favoritos =  new List <string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            txtDireccion.Text = ("www.google.com");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtDireccion.Text);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void BtnFavoritos_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            actualizarcbmfavorito();
        }

        private void actualizarcbmfavorito()
        {

            cmbFavoritos.Items.Clear();
            foreach(string direccion in favoritos)
            {
                cmbFavoritos.Items.Add(direccion);
            }
        }

        
    }
}
