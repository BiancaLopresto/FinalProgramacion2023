﻿namespace FinalProgramacion2023.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            ordenarAscendenteToolStripMenuItem = new ToolStripMenuItem();
            ordenarDescendenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colLado = new DataGridViewTextBoxColumn();
            colB = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            colBorde = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            coltipo = new DataGridViewTextBoxColumn();
            txtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrdenar, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.new_copy_32px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 51);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_32px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 51);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_32px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 51);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.filled_filter_32px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 51);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.refresh_32px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 51);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ordenarAscendenteToolStripMenuItem, ordenarDescendenteToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.sorting_arrows_32px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 51);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ordenarAscendenteToolStripMenuItem
            // 
            ordenarAscendenteToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            ordenarAscendenteToolStripMenuItem.Image = Properties.Resources.Acendente_32px;
            ordenarAscendenteToolStripMenuItem.Name = "ordenarAscendenteToolStripMenuItem";
            ordenarAscendenteToolStripMenuItem.Size = new Size(188, 22);
            ordenarAscendenteToolStripMenuItem.Text = "Ordenar Ascendente";
            ordenarAscendenteToolStripMenuItem.Click += ordenarAscendenteToolStripMenuItem_Click;
            // 
            // ordenarDescendenteToolStripMenuItem
            // 
            ordenarDescendenteToolStripMenuItem.Image = Properties.Resources.Descendente_32px;
            ordenarDescendenteToolStripMenuItem.Name = "ordenarDescendenteToolStripMenuItem";
            ordenarDescendenteToolStripMenuItem.Size = new Size(188, 22);
            ordenarDescendenteToolStripMenuItem.Text = "Ordenar Descendente";
            ordenarDescendenteToolStripMenuItem.Click += ordenarDescendenteToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_32px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(36, 51);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 54);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtCantidad);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 396);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colLado, colB, colRelleno, colBorde, colArea, colPerimetro, coltipo });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 330);
            dgvDatos.TabIndex = 0;
            // 
            // colLado
            // 
            colLado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLado.HeaderText = "LadoA";
            colLado.Name = "colLado";
            colLado.ReadOnly = true;
            colLado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colB
            // 
            colB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colB.HeaderText = "LAdoB";
            colB.Name = "colB";
            colB.ReadOnly = true;
            colB.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelleno
            // 
            colRelleno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRelleno.HeaderText = "Relleno";
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            colRelleno.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colBorde
            // 
            colBorde.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBorde.HeaderText = "Borde";
            colBorde.Name = "colBorde";
            colBorde.ReadOnly = true;
            colBorde.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colArea
            // 
            colArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colArea.HeaderText = "Area";
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPerimetro
            // 
            colPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPerimetro.HeaderText = "Perimetro";
            colPerimetro.Name = "colPerimetro";
            colPerimetro.ReadOnly = true;
            colPerimetro.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // coltipo
            // 
            coltipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            coltipo.HeaderText = "Tipo de Cuadrilatero";
            coltipo.Name = "coltipo";
            coltipo.ReadOnly = true;
            coltipo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(101, 21);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridViewTextBoxColumn colLado;
        private DataGridViewTextBoxColumn colB;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colBorde;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn coltipo;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem ordenarAscendenteToolStripMenuItem;
        private ToolStripMenuItem ordenarDescendenteToolStripMenuItem;
    }
}