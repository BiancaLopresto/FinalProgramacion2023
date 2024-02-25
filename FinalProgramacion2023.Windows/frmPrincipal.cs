using FinalProgramacion2023.Datos;
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
    public partial class frmPrincipal : Form
    {
        private RepositorioCuadrilatero repo;
        private List<Cuadrilatero> lista;
        int intValor;
        bool filterOn = false;
        public frmPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioCuadrilatero();
            ActualizarcantidadRegistros();
        }

        private void ActualizarcantidadRegistros()
        {
           if (intValor > 0)
            {
                txtCantidad.Text=repo.GetCantidad(intValor).ToString();
            }
           else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCuadrilatero frm = new frmCuadrilatero() { Text = "Agregar Cuadrilatero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel )
            {

                return;
            
            }
            Cuadrilatero cuadrilatero = frm.GetCuadrilatero();
            if (!repo.Existe(cuadrilatero))
            {
                repo.Agregar(cuadrilatero);
                txtCantidad.Text=repo.GetCantidad().ToString();
                DataGridViewRow r= ConstruirFila();
                SetearFila(r, cuadrilatero);
                AgregarFila(r);
                MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Registro Existente", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Cuadrilatero cuadrilatero)
        {
            r.Cells[colLado.Index].Value = cuadrilatero.GetLadoA();
            r.Cells[colB.Index].Value = cuadrilatero.GetLadoB();
            r.Cells[colRelleno.Index].Value = cuadrilatero.Relleno;
            r.Cells[colBorde.Index].Value = cuadrilatero.Borde;
            r.Cells[colArea.Index].Value = cuadrilatero.GetArea();
            r.Cells[colPerimetro.Index].Value = cuadrilatero.GetPerimetro();
            r.Cells[coltipo.Index].Value = cuadrilatero.TipoCuadrilatero();

            r.Tag = cuadrilatero;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
