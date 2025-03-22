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
    public partial class Ejemplo_2 : Form
    {
        index index;
        public Ejemplo_2(index index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Ejemplo_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            index.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.ToUpper() +" "+ txtApellido.Text.ToUpper();
            if (txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe completar el nombre y el apellido");
            }
            else
            {
                bool existe=false;
                
                foreach (var item in lbNombres.Items)
                {
                    if (nombre == item.ToString())
                    {
                        MessageBox.Show("el nombre ya se encuentra en la lista, ingrese otro");
                        existe = true;
                    }
                    
                }
                if (!existe)
                {
                    lbNombres.Items.Add(nombre);
                    lbNombres.Sorted = true;
                }
            }
            txtApellido.Text=string.Empty;
            txtNombre.Text=string.Empty;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
         lbNombres.Items.Remove(lbNombres.SelectedItem);
        }
    }
}

