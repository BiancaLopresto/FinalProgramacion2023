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
        int intArea;
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
                txtCantidad.Text = repo.GetCantidad(intValor).ToString();
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
            if (dr == DialogResult.Cancel)
            {

                return;

            }
            Cuadrilatero cuadrilatero = frm.GetCuadrilatero();
            if (!repo.Existe(cuadrilatero))
            {
                repo.Agregar(cuadrilatero);
                txtCantidad.Text = repo.GetCantidad().ToString();
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, cuadrilatero);
                AgregarFila(r);
                MessageBox.Show("Registro Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea dar de baja el cuadrado?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {

                return;

            }
            var filaseleccionada = dgvDatos.SelectedRows[0];
            Cuadrilatero cuadrilatero = filaseleccionada.Tag as Cuadrilatero;
            repo.Borrar(cuadrilatero);
            txtCantidad.Text = repo.GetCantidad().ToString();
            SacarFila(filaseleccionada);
            MessageBox.Show("Regristo borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SacarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Cuadrilatero cuadrilatero = (Cuadrilatero)filaSeleccionada.Tag;
            Cuadrilatero cuadrilateroCopia = (Cuadrilatero)cuadrilatero.Clone();
            frmCuadrilatero frm = new frmCuadrilatero() { Text = "Editar Cuadrado" };
            frm.SetCuadrilatero(cuadrilatero);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {

                return;

            }
            cuadrilatero = frm.GetCuadrilatero();
            if (!repo.Existe(cuadrilatero))
            {
                repo.Editar(cuadrilateroCopia, cuadrilatero);
                SetearFila(filaSeleccionada, cuadrilatero);
                MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            else
            {
                SetearFila(filaSeleccionada, cuadrilateroCopia);
                MessageBox.Show("Registro existente", "Error", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad() > 0)
            {
                lista = repo.GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var cuadrilatero in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, cuadrilatero);
                AgregarFila(r);
            }
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void ordenarAscendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarASC();
            MostrarDatosEnGrilla();
            ActualizarcantidadRegistros();
        }

        private void ordenarDescendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDESC();
            MostrarDatosEnGrilla();
            ActualizarcantidadRegistros();
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {

           
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarcantidadRegistros();
        }
    }
}
