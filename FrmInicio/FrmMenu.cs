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
    public partial class FrmMenu : Form
    {
        //archivos
        private Button botonActual;
        private Random random;
        private int tempIndex;
        private Form formActivo;

        public FrmMenu()
        {
            InitializeComponent();
            random = new Random();
            this.MinimumSize = new Size(1150, 700);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color seleccionTemaColor()
        {
            int i = random.Next(TemaColor.colorList.Count);
            while (tempIndex == i)
            {
                i = random.Next(TemaColor.colorList.Count);
            }
            tempIndex = i;
            string color = TemaColor.colorList[i];
            return ColorTranslator.FromHtml(color);
        }
        //System.Windows.Media.Color
        private void activarBoton(object btnSender)
        {
            if (btnSender != null)
            {
                if (botonActual != (Button)btnSender)
                {
                    desactivarBoton();
                    Color color = seleccionTemaColor();
                    botonActual = (Button)btnSender;
                    botonActual.BackColor = color;
                    botonActual.ForeColor = Color.White;
                    botonActual.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = TemaColor.cambiarBrilloColor(color,-0.3);
                    TemaColor.PrimaryColor = color;
                    TemaColor.SecondColor= TemaColor.cambiarBrilloColor(color, -0.3);
                }
            }
        }
        private void desactivarBoton()
        {
            foreach (Control btnPrevio in panelMenu.Controls)
            {
                if (btnPrevio.GetType() == typeof(Button))
                {
                    btnPrevio.BackColor = Color.FromArgb(51, 51, 76);
                    btnPrevio.ForeColor = Color.Gainsboro;
                    btnPrevio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender,string titulo)
        {
            if (formActivo != null)
                formActivo.Close();
            activarBoton(btnSender);
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelEscritorio.Controls.Add(childForm);
            this.panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloInicio.Text = titulo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //private void btnInicio_Click(object sender, EventArgs e)
        //{
        //    activarBoton(sender, color);
        //}

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmArticulos(),sender,"ARTÍCULOS");
        }

        private void btnMarcasCategorias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMarcaCategoria(),sender,"MARCAS Y CATEGORÍAS");
        }

        

        private void restaurar()
        {
            desactivarBoton();
            lblTituloInicio.Text = "INICIO";
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            botonActual = null;

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
