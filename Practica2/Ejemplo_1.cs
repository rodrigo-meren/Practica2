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

    public partial class Ejemplo_1 : Form
    {
        index index;
        public Ejemplo_1(index index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void Ejemplo_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            index.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("ingrese un nombre");
            }
            else
            {
                bool existe = false;
                nombre = txtNombre.Text.ToLower();
                foreach (var item in lb1.Items)
                {
                    if (nombre == item.ToString().ToLower())
                    {
                        MessageBox.Show("el nombre ya se encuentra en la lista, ingrese otro");
                        existe = true;
                    }
                }

                if (!existe)
                {
                    lb1.Items.Add(txtNombre.Text.Trim());
                    

                }
                txtNombre.Text = string.Empty;
            }
        }
      

        private void bntUno_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem == null)
            {
                MessageBox.Show("debe seleccionar un nombre");
            }
            else
            {
                lb2.Items.Add(lb1.SelectedItem);

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {


            foreach (var item in lb1.Items)
            {
                lb2.Items.Add((string)item);
            }
            lb1.Items.Clear();


        }
    }
}
