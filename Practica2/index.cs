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
    public partial class index: Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejemplo_1 ejemplo_1 = new Ejemplo_1(this);
            ejemplo_1.Show();
            this.Hide();
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            Ejemplo_2 ejemplo_2 = new Ejemplo_2(this);
            ejemplo_2.Show();
            this.Hide();
        }

       

        private void btnEj3_Click_1(object sender, EventArgs e)
        {
            Ejercicio_3 ejercicio_3 = new Ejercicio_3(this);
            ejercicio_3.Show();
            this.Hide();
        }
    }
}
