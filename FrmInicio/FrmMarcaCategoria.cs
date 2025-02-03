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
    public partial class FrmMarcaCategoria : Form
    {
        private MarcaNegocio marcaNegocio=new MarcaNegocio();
        private CategoriaNegocio categoriaNegocio=new CategoriaNegocio();
        private Marca marca = null;
        private Categoria categoria = null;
        
        public FrmMarcaCategoria()
        {
            InitializeComponent();
            
        }
        private void temaCargado()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = TemaColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = TemaColor.SecondColor;
                }
            }
            lblCategorias.ForeColor=TemaColor.SecondColor;
            lblMarcas.ForeColor=TemaColor.SecondColor;
        }
        private void configuracionDgvCategoria(List<Categoria> listaCategorias)
        {
            dgvCategorias.DataSource = listaCategorias;

            dgvCategorias.Columns["Id"].Visible = false;
        }
        private void configuracionDgvMarca(List<Marca> listaMarcas)
        {
            dgvMarcas.DataSource = listaMarcas;
            dgvMarcas.Columns["Id"].Visible = false;
        }
        private void limpiarSeleccionDgv()
        {
            dgvCategorias.ClearSelection();
            dgvCategorias.CurrentCell = null;
            dgvMarcas.ClearSelection();
            dgvMarcas.CurrentCell = null;
        }
        private bool validarDgv()
        {
            bool bandera=true;
            if ((dgvCategorias.CurrentRow != null && dgvMarcas.CurrentRow != null)||(dgvCategorias.CurrentCell==null&&dgvMarcas.CurrentCell==null))
            {
                MessageBox.Show("Debe seleccionar un elemento de Marca o de Categoría!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bandera = false;
            }


            return bandera;
            
        }
        private void FrmMarcaCategoria_Load(object sender, EventArgs e)
        {
            temaCargado();
            dgvCategorias.RowHeadersVisible = false;
            dgvMarcas.RowHeadersVisible = false;
            configuracionDgvCategoria(categoriaNegocio.listar());
            configuracionDgvMarca(marcaNegocio.listar());
            //if(dgvCategorias.Columns["Nombre"]!=null)
            //    dgvCategorias.Columns["Nombre"].Width = 1000;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!rbtCategoria.Checked && !rbtMarca.Checked)
            {
                MessageBox.Show("Debe seleccionar entre Marca o Categoría!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rbtCategoria.Checked)
            {
                FrmAgregarEditarMarcaCategoria frmAgregarEditarMarcaCategoria = new FrmAgregarEditarMarcaCategoria(new Categoria());
                frmAgregarEditarMarcaCategoria.Text = "Agregar Categoría";
                frmAgregarEditarMarcaCategoria.ShowDialog();
                dgvCategorias.DataSource = null;
                configuracionDgvCategoria(categoriaNegocio.listar());
            }
            if (rbtMarca.Checked)
            {
                FrmAgregarEditarMarcaCategoria frmAgregarEditarMarcaCategoria = new FrmAgregarEditarMarcaCategoria(new Marca());
                frmAgregarEditarMarcaCategoria.Text = "Agregar Marca";
                frmAgregarEditarMarcaCategoria.ShowDialog();
                dgvMarcas.DataSource = null;
                configuracionDgvMarca(marcaNegocio.listar());
            }
        }

        private void dgvMarcas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            limpiarSeleccionDgv();
        }

        private void btnLimpiarSeleccion_Click(object sender, EventArgs e)
        {
            limpiarSeleccionDgv();
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvMarcas.CurrentRow!=null)
                marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
                categoria=(Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!validarDgv())
                    return;
                if (dgvCategorias.CurrentCell!=null)
                {
                    FrmAgregarEditarMarcaCategoria frmEditarMarcaCategoria = new FrmAgregarEditarMarcaCategoria(categoria);
                    frmEditarMarcaCategoria.Text = "Editar Categoría";
                    frmEditarMarcaCategoria.ShowDialog();
                    dgvCategorias.DataSource = null;
                    configuracionDgvCategoria(categoriaNegocio.listar());
                }
                if (dgvMarcas.CurrentCell != null)
                {
                    FrmAgregarEditarMarcaCategoria frmEditarMarcaCategoria=new FrmAgregarEditarMarcaCategoria(marca);
                    frmEditarMarcaCategoria.Text = "Editar Marca";
                    frmEditarMarcaCategoria.ShowDialog();
                    dgvMarcas.DataSource = null;
                    configuracionDgvMarca(marcaNegocio.listar());
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!validarDgv())
            {
                return;
            }
            try
            {
                if (dgvCategorias.CurrentCell != null)
                {
                    if (categoriaNegocio.existeCategoriaEnArticulo(categoria))
                    {
                        MessageBox.Show("Existen artículos vinculados a esta categoría!\nElimine primero los artículos vinculados antes de eliminar la categoría", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult respuesta = MessageBox.Show($"Está seguro de eliminar la categoría '{categoria.Descripcion}'?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        categoriaNegocio.eliminar(categoria);
                        MessageBox.Show("Categoría eliminada correctamente!", "Eliminar", MessageBoxButtons.OK);
                        dgvCategorias.DataSource = null;
                        configuracionDgvCategoria(categoriaNegocio.listar());
                    }
                }
                if (dgvMarcas.CurrentCell!=null)
                {
                    if (marcaNegocio.existeMacaEnArticulos(marca))
                    {
                        MessageBox.Show("Existe uno o varios artículos vinculados a esta categoría!\nElimine primero los artículos vinculados antes de eliminar la marca", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DialogResult respuesta= MessageBox.Show($"Está seguro de eliminar la marca '{marca.Descripcion}'?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        marcaNegocio.eliminar(marca);
                        MessageBox.Show("Marca eliminada correctamente!", "Eliminar", MessageBoxButtons.OK);
                        dgvMarcas.DataSource = null;
                        configuracionDgvMarca(marcaNegocio.listar());
                    }
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.ToString()}");
            }
            
        }

        private void txtBuscarMarcaCategoria_TextChanged(object sender, EventArgs e)
        {
            if (!rbtCategoria.Checked&&!rbtMarca.Checked)
            {
                MessageBox.Show("Debes de seleccionar entre Marca y Categoría para realizar la búsqueda","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                return;
            }
            string filtro = txtBuscarMarcaCategoria.Text;
            if (rbtCategoria.Checked)
            {
                List<Categoria> listaCategoriaFiltrada;
                
                
                if (filtro.Length>1)
                {
                    listaCategoriaFiltrada = categoriaNegocio.listar().FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaCategoriaFiltrada=categoriaNegocio.listar();
                }
                configuracionDgvCategoria(listaCategoriaFiltrada);
            }
            if (rbtMarca.Checked)
            {
                List<Marca> listaMarcaFiltrada;
                if (filtro.Length > 1)
                {
                    listaMarcaFiltrada = marcaNegocio.listar().FindAll(x=>x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaMarcaFiltrada=marcaNegocio.listar();
                }
                configuracionDgvMarca(listaMarcaFiltrada);
            }
        }
    }
}
