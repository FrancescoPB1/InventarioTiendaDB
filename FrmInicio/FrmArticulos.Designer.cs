namespace FrmInicio
{
    partial class FrmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.gbxDetallesArticulo = new System.Windows.Forms.GroupBox();
            this.txtDescripcionDetalles = new System.Windows.Forms.TextBox();
            this.txtNombreDetalles = new System.Windows.Forms.TextBox();
            this.txtCodigoDetalles = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.cmbFiltroArticulo = new System.Windows.Forms.ComboBox();
            this.lblFiltroArticulo = new System.Windows.Forms.Label();
            this.lblBuscarArticulo = new System.Windows.Forms.Label();
            this.txtBuscarArticulo = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblCargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbxDetallesArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(38, 66);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 92;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(700, 374);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // gbxDetallesArticulo
            // 
            this.gbxDetallesArticulo.Controls.Add(this.txtDescripcionDetalles);
            this.gbxDetallesArticulo.Controls.Add(this.txtNombreDetalles);
            this.gbxDetallesArticulo.Controls.Add(this.txtCodigoDetalles);
            this.gbxDetallesArticulo.Controls.Add(this.lblDescripcion);
            this.gbxDetallesArticulo.Controls.Add(this.lblNombreArticulo);
            this.gbxDetallesArticulo.Controls.Add(this.lblCodigo);
            this.gbxDetallesArticulo.Controls.Add(this.pbxArticulo);
            this.gbxDetallesArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetallesArticulo.Location = new System.Drawing.Point(751, 29);
            this.gbxDetallesArticulo.Name = "gbxDetallesArticulo";
            this.gbxDetallesArticulo.Size = new System.Drawing.Size(262, 448);
            this.gbxDetallesArticulo.TabIndex = 1;
            this.gbxDetallesArticulo.TabStop = false;
            this.gbxDetallesArticulo.Text = "Detalles del artículo";
            // 
            // txtDescripcionDetalles
            // 
            this.txtDescripcionDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDetalles.Location = new System.Drawing.Point(80, 344);
            this.txtDescripcionDetalles.Margin = new System.Windows.Forms.Padding(1);
            this.txtDescripcionDetalles.Multiline = true;
            this.txtDescripcionDetalles.Name = "txtDescripcionDetalles";
            this.txtDescripcionDetalles.ReadOnly = true;
            this.txtDescripcionDetalles.Size = new System.Drawing.Size(157, 89);
            this.txtDescripcionDetalles.TabIndex = 6;
            // 
            // txtNombreDetalles
            // 
            this.txtNombreDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDetalles.Location = new System.Drawing.Point(79, 313);
            this.txtNombreDetalles.Margin = new System.Windows.Forms.Padding(1);
            this.txtNombreDetalles.Name = "txtNombreDetalles";
            this.txtNombreDetalles.ReadOnly = true;
            this.txtNombreDetalles.Size = new System.Drawing.Size(157, 22);
            this.txtNombreDetalles.TabIndex = 5;
            // 
            // txtCodigoDetalles
            // 
            this.txtCodigoDetalles.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDetalles.Location = new System.Drawing.Point(79, 284);
            this.txtCodigoDetalles.Margin = new System.Windows.Forms.Padding(1);
            this.txtCodigoDetalles.Name = "txtCodigoDetalles";
            this.txtCodigoDetalles.ReadOnly = true;
            this.txtCodigoDetalles.Size = new System.Drawing.Size(157, 22);
            this.txtCodigoDetalles.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(10, 345);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 16);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción: ";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(24, 313);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(56, 16);
            this.lblNombreArticulo.TabIndex = 2;
            this.lblNombreArticulo.Text = "Nombre: ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(29, 284);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código: ";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Image = global::FrmInicio.Properties.Resources.imagen_no_disponible;
            this.pbxArticulo.Location = new System.Drawing.Point(27, 19);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(210, 245);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 0;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(91, 473);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(138, 46);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarArticulo.Location = new System.Drawing.Point(312, 473);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(138, 46);
            this.btnEditarArticulo.TabIndex = 3;
            this.btnEditarArticulo.Text = "Editar";
            this.btnEditarArticulo.UseVisualStyleBackColor = true;
            this.btnEditarArticulo.Click += new System.EventHandler(this.btnEditarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(536, 473);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(138, 46);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // cmbFiltroArticulo
            // 
            this.cmbFiltroArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroArticulo.FormattingEnabled = true;
            this.cmbFiltroArticulo.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Marca",
            "Categoría",
            "Precio"});
            this.cmbFiltroArticulo.Location = new System.Drawing.Point(73, 26);
            this.cmbFiltroArticulo.Name = "cmbFiltroArticulo";
            this.cmbFiltroArticulo.Size = new System.Drawing.Size(89, 21);
            this.cmbFiltroArticulo.TabIndex = 5;
            this.cmbFiltroArticulo.SelectionChangeCommitted += new System.EventHandler(this.cmbFiltroArticulo_SelectionChangeCommitted);
            // 
            // lblFiltroArticulo
            // 
            this.lblFiltroArticulo.AutoSize = true;
            this.lblFiltroArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroArticulo.Location = new System.Drawing.Point(35, 29);
            this.lblFiltroArticulo.Name = "lblFiltroArticulo";
            this.lblFiltroArticulo.Size = new System.Drawing.Size(37, 16);
            this.lblFiltroArticulo.TabIndex = 6;
            this.lblFiltroArticulo.Text = "Filtro:";
            // 
            // lblBuscarArticulo
            // 
            this.lblBuscarArticulo.AutoSize = true;
            this.lblBuscarArticulo.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarArticulo.Location = new System.Drawing.Point(316, 29);
            this.lblBuscarArticulo.Name = "lblBuscarArticulo";
            this.lblBuscarArticulo.Size = new System.Drawing.Size(45, 16);
            this.lblBuscarArticulo.TabIndex = 7;
            this.lblBuscarArticulo.Text = "Buscar:";
            // 
            // txtBuscarArticulo
            // 
            this.txtBuscarArticulo.Location = new System.Drawing.Point(365, 27);
            this.txtBuscarArticulo.Name = "txtBuscarArticulo";
            this.txtBuscarArticulo.Size = new System.Drawing.Size(173, 20);
            this.txtBuscarArticulo.TabIndex = 8;
            this.txtBuscarArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarArticulo_KeyPress);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(173, 27);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(48, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(221, 26);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(78, 21);
            this.cmbCriterio.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(553, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 28);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(634, 22);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(87, 28);
            this.btnLimpiarFiltros.TabIndex = 12;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.Location = new System.Drawing.Point(761, 491);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(120, 26);
            this.lblCargando.TabIndex = 13;
            this.lblCargando.Text = "Cargando...";
            this.lblCargando.Visible = false;
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 534);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.txtBuscarArticulo);
            this.Controls.Add(this.lblBuscarArticulo);
            this.Controls.Add(this.lblFiltroArticulo);
            this.Controls.Add(this.cmbFiltroArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnEditarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.gbxDetallesArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmArticulos";
            this.Text = "FrmArticulos";
            this.Activated += new System.EventHandler(this.FrmArticulos_Activated);
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbxDetallesArticulo.ResumeLayout(false);
            this.gbxDetallesArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox gbxDetallesArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.ComboBox cmbFiltroArticulo;
        private System.Windows.Forms.Label lblFiltroArticulo;
        private System.Windows.Forms.Label lblBuscarArticulo;
        private System.Windows.Forms.TextBox txtBuscarArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.TextBox txtDescripcionDetalles;
        private System.Windows.Forms.TextBox txtNombreDetalles;
        private System.Windows.Forms.TextBox txtCodigoDetalles;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblCargando;
    }
}