namespace FrmInicio
{
    partial class FrmMarcaCategoria
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblBuscarMarcaCategoria = new System.Windows.Forms.Label();
            this.txtBuscarMarcaCategoria = new System.Windows.Forms.TextBox();
            this.gbxSeleccion = new System.Windows.Forms.GroupBox();
            this.rbtCategoria = new System.Windows.Forms.RadioButton();
            this.rbtMarca = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiarSeleccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.gbxSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToResizeColumns = false;
            this.dgvMarcas.AllowUserToResizeRows = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(1390, 268);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(7);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.RowHeadersWidth = 92;
            this.dgvMarcas.Size = new System.Drawing.Size(276, 564);
            this.dgvMarcas.TabIndex = 2;
            this.dgvMarcas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMarcas_DataBindingComplete);
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(1413, 172);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(243, 64);
            this.lblMarcas.TabIndex = 3;
            this.lblMarcas.Text = "MARCAS";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(1802, 268);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(7);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 92;
            this.dgvCategorias.Size = new System.Drawing.Size(270, 564);
            this.dgvCategorias.TabIndex = 5;
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(1766, 172);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(343, 64);
            this.lblCategorias.TabIndex = 6;
            this.lblCategorias.Text = "CATEGORÍAS";
            // 
            // lblBuscarMarcaCategoria
            // 
            this.lblBuscarMarcaCategoria.AutoSize = true;
            this.lblBuscarMarcaCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMarcaCategoria.Location = new System.Drawing.Point(570, 628);
            this.lblBuscarMarcaCategoria.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBuscarMarcaCategoria.Name = "lblBuscarMarcaCategoria";
            this.lblBuscarMarcaCategoria.Size = new System.Drawing.Size(118, 39);
            this.lblBuscarMarcaCategoria.TabIndex = 12;
            this.lblBuscarMarcaCategoria.Text = "Buscar:";
            // 
            // txtBuscarMarcaCategoria
            // 
            this.txtBuscarMarcaCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarcaCategoria.Location = new System.Drawing.Point(705, 621);
            this.txtBuscarMarcaCategoria.Margin = new System.Windows.Forms.Padding(7);
            this.txtBuscarMarcaCategoria.Name = "txtBuscarMarcaCategoria";
            this.txtBuscarMarcaCategoria.Size = new System.Drawing.Size(377, 47);
            this.txtBuscarMarcaCategoria.TabIndex = 15;
            this.txtBuscarMarcaCategoria.TextChanged += new System.EventHandler(this.txtBuscarMarcaCategoria_TextChanged);
            // 
            // gbxSeleccion
            // 
            this.gbxSeleccion.Controls.Add(this.rbtCategoria);
            this.gbxSeleccion.Controls.Add(this.rbtMarca);
            this.gbxSeleccion.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSeleccion.Location = new System.Drawing.Point(136, 356);
            this.gbxSeleccion.Name = "gbxSeleccion";
            this.gbxSeleccion.Size = new System.Drawing.Size(1015, 205);
            this.gbxSeleccion.TabIndex = 16;
            this.gbxSeleccion.TabStop = false;
            this.gbxSeleccion.Text = "Seleccionar ";
            // 
            // rbtCategoria
            // 
            this.rbtCategoria.AutoSize = true;
            this.rbtCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCategoria.Location = new System.Drawing.Point(569, 95);
            this.rbtCategoria.Name = "rbtCategoria";
            this.rbtCategoria.Size = new System.Drawing.Size(218, 50);
            this.rbtCategoria.TabIndex = 21;
            this.rbtCategoria.TabStop = true;
            this.rbtCategoria.Text = "Categoría";
            this.rbtCategoria.UseVisualStyleBackColor = true;
            // 
            // rbtMarca
            // 
            this.rbtMarca.AutoSize = true;
            this.rbtMarca.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMarca.Location = new System.Drawing.Point(202, 95);
            this.rbtMarca.Name = "rbtMarca";
            this.rbtMarca.Size = new System.Drawing.Size(158, 50);
            this.rbtMarca.TabIndex = 20;
            this.rbtMarca.TabStop = true;
            this.rbtMarca.Text = "Marca";
            this.rbtMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1747, 881);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(325, 100);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1390, 881);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(331, 100);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar ";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(234, 593);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(262, 100);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiarSeleccion
            // 
            this.btnLimpiarSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarSeleccion.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarSeleccion.Location = new System.Drawing.Point(1390, 1034);
            this.btnLimpiarSeleccion.Margin = new System.Windows.Forms.Padding(7);
            this.btnLimpiarSeleccion.Name = "btnLimpiarSeleccion";
            this.btnLimpiarSeleccion.Size = new System.Drawing.Size(682, 100);
            this.btnLimpiarSeleccion.TabIndex = 22;
            this.btnLimpiarSeleccion.Text = "Limpiar Selección";
            this.btnLimpiarSeleccion.UseVisualStyleBackColor = true;
            this.btnLimpiarSeleccion.Click += new System.EventHandler(this.btnLimpiarSeleccion_Click);
            // 
            // FrmMarcaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2354, 1258);
            this.Controls.Add(this.btnLimpiarSeleccion);
            this.Controls.Add(this.gbxSeleccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscarMarcaCategoria);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblBuscarMarcaCategoria);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.dgvMarcas);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmMarcaCategoria";
            this.Text = "FrmMarcaCategoria";
            this.Load += new System.EventHandler(this.FrmMarcaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.gbxSeleccion.ResumeLayout(false);
            this.gbxSeleccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblBuscarMarcaCategoria;
        private System.Windows.Forms.TextBox txtBuscarMarcaCategoria;
        private System.Windows.Forms.GroupBox gbxSeleccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.RadioButton rbtCategoria;
        private System.Windows.Forms.RadioButton rbtMarca;
        private System.Windows.Forms.Button btnLimpiarSeleccion;
    }
}