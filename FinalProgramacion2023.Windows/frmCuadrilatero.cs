using FinalProgramacion2023.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProgramacion2023.Windows
{
    public partial class frmCuadrilatero : Form
    {
        public frmCuadrilatero()
        {
            InitializeComponent();
        }
        private Cuadrilatero cuadrilatero;
        internal Cuadrilatero GetCuadrilatero()
        {
            return cuadrilatero;
        }
    }
}
