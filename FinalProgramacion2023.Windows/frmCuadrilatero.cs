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
       



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosRelleno();
            if (cuadrilatero != null)
            {
                txtLadoA.Text = cuadrilatero.GetLadoA().ToString();
                txtLadoB.Text=cuadrilatero.GetLadoB().ToString();
                cboRelleno.SelectedItem = cuadrilatero.Relleno;
                if (cuadrilatero.Borde == Borde.Lineal)
                {
                    rbLineal.Checked = true;
                }
                else if (cuadrilatero.Borde == Borde.Rayas)
                {
                    rbRayas.Checked = true;
                }
                else
                {
                    rbPuntos.Checked = true;
                }
            }
        }


       
        private void CargarDatosRelleno()
        {
            var listaRelleno = Enum.GetValues(typeof(Relleno)).Cast<Relleno>().ToList();
            cboRelleno.DataSource = listaRelleno;
            cboRelleno.SelectedIndex = 0;
        }

        public Cuadrilatero GetCuadrilatero()
        {
            return cuadrilatero;
        }

        private void frmCuadrilatero_Load(object sender, EventArgs e)
        {

        }




        private void rbtLineal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cuadrilatero == null)
                {
                    cuadrilatero = new Cuadrilatero()
;
                }
                cuadrilatero.SetLadoA(int.Parse(txtLadoA.Text));
                cuadrilatero.SetLadoB(int.Parse(txtLadoB.Text));
                cuadrilatero.Relleno = (Relleno)cboRelleno.SelectedItem;
                if (rbRayas.Checked)
                {
                    cuadrilatero.Borde = Borde.Rayas;

                }else if (rbPuntos.Checked)
                {
                    cuadrilatero.Borde=Borde.Puntos;
                }else
                {
                    cuadrilatero.Borde = Borde.Lineal;
                }
                

                DialogResult = DialogResult.OK;
            }
        }

       

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (!int.TryParse(txtLadoA.Text, out int lado))
            {
                valido = false;
                errorProvider1.SetError(txtLadoA, "Numero mal ingresado");
            } else if (lado <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLadoA, "Numero no valido");
            }else if (!int.TryParse(txtLadoB.Text, out int ladob))
            {
                valido = false;
                errorProvider2.SetError(txtLadoB, "Numero mal ingresado");
            }else if(ladob<= 0)
            {
                valido=false;
                errorProvider2.SetError(txtLadoB, "Numero no valido");
            }
            return valido;
        }

        public void SetCuadrilatero(Cuadrilatero? cuadrilatero)
        {
            this.cuadrilatero = cuadrilatero;
        }
    }
}
