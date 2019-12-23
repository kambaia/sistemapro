using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            openChildForm(new TelaPrincipal());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            painel.Controls.Add(childForm);
            painel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AreaPedagogica());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Tesouraria());
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            openChildForm(new TelaPrincipal());
        }
    }
}
