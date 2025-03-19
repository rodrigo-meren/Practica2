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
    }
}
