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
    public partial class Ejemplo_2: Form
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
    }
}
