using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmInicio
{
    public partial class FrmAgregarEditarMarcaCategoria : Form
    {
        private Marca marcaRecibida = null;
        private Categoria categoriaRecibida=null;
        private CategoriaNegocio categoriaNegocio=new CategoriaNegocio();
        private MarcaNegocio marcaNegocio=new MarcaNegocio();
        public FrmAgregarEditarMarcaCategoria()
        {
            InitializeComponent();
            
        }
        public FrmAgregarEditarMarcaCategoria(Categoria categoriaRecibida)
        {
            InitializeComponent();
            this.categoriaRecibida = categoriaRecibida;
        }
        public FrmAgregarEditarMarcaCategoria(Marca marcaRecibida)
        {
            InitializeComponent();
            this.marcaRecibida = marcaRecibida;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") { 
                MessageBox.Show("Ingrese un nombre porfavor...","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            try
            {
                if (categoriaRecibida!= null)
                {
                    categoriaRecibida.Descripcion = txtNombre.Text;
                    if (this.Text == "Agregar Categoría")
                    {


                        categoriaNegocio.insertar(categoriaRecibida);
                        MessageBox.Show("Categoría agregada correctamente!");
                        this.Close();
                    }
                    if (this.Text == "Editar Categoría")
                    {
                        categoriaNegocio.editar(categoriaRecibida);
                        MessageBox.Show("Categoría editada correctamente!");
                        this.Close();
                    }
                }
                if (marcaRecibida!=null)
                {
                    marcaRecibida.Descripcion=txtNombre.Text;
                    if (this.Text=="Agregar Marca")
                    {
                        marcaNegocio.insertar(marcaRecibida);
                        MessageBox.Show("Marca agregada correctamente!");
                        this.Close();
                    }
                    if (this.Text=="Editar Marca")
                    {
                        
                        marcaNegocio.editar(marcaRecibida);
                        MessageBox.Show("Marca editada correctamente!");
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private void FrmAgregarEditarMarcaCategoria_Load(object sender, EventArgs e)
        {
            if (categoriaRecibida!=null&& categoriaRecibida.Descripcion != null)
            {
                    txtNombre.Text = categoriaRecibida.Descripcion.ToString();
            }   
            if (marcaRecibida!=null&& marcaRecibida.Descripcion != null)
            {
                
                txtNombre.Text = marcaRecibida.Descripcion.ToString();
            }
            lblTituloAgregarEditarCategoriaMarca.Text = this.Text.ToString();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
