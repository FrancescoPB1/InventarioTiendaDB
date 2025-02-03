
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInicio
{
    public partial class FrmArticulos : Form
    {
        private ArticuloNegocio articuloNegocio=new ArticuloNegocio();
        private List<Articulo> articuloList;
        private Articulo articulo = null;
        public FrmArticulos()
        {
            InitializeComponent();
            temaCargado();
            
        }
        private void temaCargado()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = TemaColor.PrimaryColor;
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.FlatAppearance.BorderColor = TemaColor.SecondColor;
                }
            }
        }
        private void cargaDgvDB()
        {
            
            articuloList = articuloNegocio.listar();
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articuloList;
            if (dgvArticulos.Rows.Count > 0)
            {
                
                dgvArticulos.ClearSelection();
                //seleccionar primera fila
                //dgvArticulos.Rows[0].Selected = true;
                cargarDetalles();
            }
            else
            {
                txtNombreDetalles.Text = "";
                txtCodigoDetalles.Text = "";
                txtDescripcionDetalles.Text = "";
                pbxArticulo.Image = Properties.Resources.imagen_no_disponible;
            }
            
            

        }

        
        private void configurarDgv()
        {
            //Centrar los encabezados del dgv
            foreach (DataGridViewColumn columna in dgvArticulos.Columns)
            {
                columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgvArticulos.RowHeadersVisible = false; 
            if (dgvArticulos.Columns["Id"] != null)
                dgvArticulos.Columns["Id"].Visible = false;     
            if (dgvArticulos.Columns["ImagenUrl"] != null)
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
            if (dgvArticulos.Columns["Descripcion"] != null)
                dgvArticulos.Columns["Descripcion"].Width = 197;
        }
        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            temaCargado();
            configurarDgv();
            try
            {
                cargaDgvDB();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            configurarDgv();

            
            
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxArticulo.Image = Properties.Resources.imagen_no_disponible;
            }
        }
        private void cargarDetalles()
        {
            if (dgvArticulos.CurrentRow != null)
            {
                articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articulo.ImagenUrl);
                txtNombreDetalles.Text = articulo.Nombre.ToString();
                txtCodigoDetalles.Text = articulo.Codigo.ToString();
                txtDescripcionDetalles.Text = articulo.Descripcion.ToString();
            }
            
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            articulo = new Articulo();

            cargarDetalles();
        }
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarEditarArticulo frmAgregarEditarArticulo = new FrmAgregarEditarArticulo();
                frmAgregarEditarArticulo.ShowDialog();
                //articuloList.Clear();
                lblCargando.Visible = true;
                cargaDgvDB();
                configurarDgv();
                lblCargando.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.SelectedCells.Count==0)
                {
                    MessageBox.Show("Debe de seleccionar un elemento a editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (dgvArticulos.CurrentRow != null)
                {
                    FrmAgregarEditarArticulo frmAgregarEditarArticulo = new FrmAgregarEditarArticulo(articulo);
                    frmAgregarEditarArticulo.ShowDialog();
                    //articuloList.Clear();
                    lblCargando.Visible = true;
                    cargaDgvDB();
                    configurarDgv();
                    lblCargando.Visible = false;
                }
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Debe de seleccionar un elemento a eliminar","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                DialogResult respuesta = MessageBox.Show($"Estas seguro de eliminar el artículo '{articulo.Nombre}'?\nSus datos se eliminarán de forma permanente!", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    articuloNegocio.eliminar(articulo);
                    MessageBox.Show("Artículo eliminado correctamente!", "Eliminar");


                    //dgvArticulos.DataSource = null;
                    lblCargando.Visible = true;
                    cargaDgvDB();
                    configurarDgv();
                    lblCargando.Visible = false;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        private void aniadirElementosCmbCriterio(string criterio1,string criterio2,string criterio3)
        {
            cmbCriterio.Items.Clear();
            cmbCriterio.Items.Add(criterio1);
            cmbCriterio.Items.Add(criterio2);
            cmbCriterio.Items.Add(criterio3);
        }

        private void cmbFiltroArticulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbFiltroArticulo.SelectedItem.ToString()=="Precio")
            {
                
                aniadirElementosCmbCriterio("Menor a","Mayor a","Igual a");
            }
            else
            {
                
                aniadirElementosCmbCriterio("Comienza con","Termina con","Contiene");
            }
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltroArticulo.SelectedItem==null||cmbCriterio.SelectedItem==null||txtBuscarArticulo.Text=="")
                {
                    MessageBox.Show("Debe de ingresar todos los campos para realizar la búsqueda!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                ArticuloNegocio negocio = new ArticuloNegocio();
                string campo = cmbFiltroArticulo.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString();
                string filtro = txtBuscarArticulo.Text;

                dgvArticulos.DataSource = negocio.FiltrarArticulos(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los artículos: " + ex.Message);
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbFiltroArticulo.SelectedIndex=-1;
            cmbCriterio.Items.Clear();
            txtBuscarArticulo.Text = "";
            //articuloNegocio.listar().Clear();
            cargaDgvDB();
            configurarDgv();
        }

        private void FrmArticulos_Activated(object sender, EventArgs e)
        {

        }

        private void txtBuscarArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFiltroArticulo.Text == "Precio")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                    e.Handled = true;
            }
        }
    }
}

