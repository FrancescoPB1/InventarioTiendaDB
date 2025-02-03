using Conexion;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInicio
{
    public partial class FrmAgregarEditarArticulo : Form
    {
        private Articulo articuloRecibido=null;
        private ArticuloNegocio articuloNegocio=new ArticuloNegocio();
        private CategoriaNegocio categoriaNegocio=new CategoriaNegocio();
        private MarcaNegocio marcaNegocio=new MarcaNegocio();
        public FrmAgregarEditarArticulo()
        {
            InitializeComponent();
        }
        public FrmAgregarEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            articuloRecibido = articulo;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmAgregarEditarArticulo_Load(object sender, EventArgs e)
        {
            cmbCategoriaNuevo.DisplayMember = "Descripcion";
            cmbCategoriaNuevo.ValueMember = "Id";
            cmbMarcaNuevo.DisplayMember = "Descripcion";
            cmbMarcaNuevo.ValueMember = "Id";
            cmbMarcaNuevo.DataSource = marcaNegocio.listar();
            cmbCategoriaNuevo.DataSource = categoriaNegocio.listar();
            if (articuloRecibido == null)
            {
                this.Text = "Agregar Artículo";
                btnAgregarEditar.Text = "Agregar";
                articuloRecibido=new Articulo();
            }
            else
            {
                
                this.Text = "Editar Artículo";
                mostrarDatosArticulo();
                btnAgregarEditar.Text = "Editar";

                
            }
            lblTitulo.Text=this.Text;

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenNuevo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImagenNuevo.Image=Properties.Resources.imagen_no_disponible;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtCodigoNuevo.Text == "" || txtNombreNuevo.Text == "" || txtDescripcionNuevo.Text == "" ||
                    txtImagenUrlNuevo.Text == "" || txtPrecioNuevo.Text == "")
                {
                    MessageBox.Show("Debe de ingresar todos los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lecturaDatosArticulo();
                if (btnAgregarEditar.Text == "Agregar")
                {

                    articuloNegocio.agregar(articuloRecibido);
                    MessageBox.Show("Artículo guardado exitosamente!", "Agregado");
                    this.Close();

                }
                if (btnAgregarEditar.Text == "Editar")
                {
                    DialogResult respuesta = MessageBox.Show($"Esta seguro de editar los datos del artículo '{articuloRecibido.Nombre}'?","Editar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if(respuesta == DialogResult.Yes)
                    {
                        articuloNegocio.editar(articuloRecibido);
                        MessageBox.Show("Editado correctamente!","Editar");
                        this.Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void lecturaDatosArticulo()
        {
            articuloRecibido.Codigo = txtCodigoNuevo.Text;
            articuloRecibido.Nombre = txtNombreNuevo.Text;
            articuloRecibido.Descripcion = txtDescripcionNuevo.Text;
            articuloRecibido.Marca = (Marca)cmbMarcaNuevo.SelectedItem;
            articuloRecibido.Categoria = (Categoria)cmbCategoriaNuevo.SelectedItem;
            articuloRecibido.ImagenUrl=txtImagenUrlNuevo.Text;
            articuloRecibido.Precio = Convert.ToDecimal(txtPrecioNuevo.Text);
        }
        private void mostrarDatosArticulo()
        {
            txtCodigoNuevo.Text = articuloRecibido.Codigo.ToString();
            txtNombreNuevo.Text = articuloRecibido.Nombre.ToString();
            txtDescripcionNuevo.Text = articuloRecibido.Descripcion.ToString();
            
            cmbCategoriaNuevo.SelectedValue = articuloRecibido.Categoria.Id;
            cmbMarcaNuevo.SelectedValue = articuloRecibido.Marca.Id;
            txtImagenUrlNuevo.Text = articuloRecibido.ImagenUrl.ToString();
            txtPrecioNuevo.Text = articuloRecibido.Precio.ToString();
            cargarImagen(txtImagenUrlNuevo.Text);
        }

        private void txtImagenUrlNuevo_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrlNuevo.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPrecioNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeros
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&e.KeyChar!='.')
                e.Handled = true;
            if(e.KeyChar=='.'&&(sender as TextBox).Text.IndexOf('.')>-1)
                e.Handled=true;
            
        }
    }
}
