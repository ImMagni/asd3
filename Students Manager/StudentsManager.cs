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


namespace Students_Manager
{
    public partial class StudentsManager : Form
    {

        public static class GlobalVariables
        {
            public static String[] Students;
        }

        //private Button ActButton;
        private Form ActiveForm;
        public StudentsManager()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false; 
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel.Controls.Add(childForm);
            this.panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Estudiantes";
            OpenChildForm(new Forms.FormStudents(), sender);
        }

        private void btnAleatorizador_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "Aleatorizador";
            OpenChildForm(new Forms.FormRandomizer(), sender);
        }
    }
}
