using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Ejercicio_3: Form
    {
        index index;
        public Ejercicio_3(index index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Ejercicio_3_FormClosed(object sender, FormClosedEventArgs e)
        {
            index.Show();
        }

     
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (rbMasc.Checked)
            {
                lblSexo.Text = "Masculino";

                if (rbCasado.Checked)
                {
                    lblEstCivil.Text = "Casado";
                }
                else if (rbSolt.Checked)
                {
                    lblEstCivil.Text = "Soltero";
                }
            }
            else if (rbFem.Checked)
            {
                lblSexo.Text = "Femenino";
                if (rbCasado.Checked)
                {
                    lblEstCivil.Text = "Casada";
                }
                else if (rbSolt.Checked)
                {
                    lblEstCivil.Text = "Soltera";
                }
            }
            foreach(string x in chlEmpleos.CheckedItems)
            {
              lbEmpleos.Items.Add(x);   
            }
           
        }
    }
}
