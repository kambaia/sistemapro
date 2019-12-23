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
    public partial class AreaPedagogica : Form
    {
        public AreaPedagogica()
        {
            InitializeComponent();
        }

        private void btn_AP_Profs_Click(object sender, EventArgs e)
        {
            frm_AP_Professores professores = new frm_AP_Professores();
            professores.Show();
        }

        private void btn_AP_Discip_Click(object sender, EventArgs e)
        {
            frm_AP_Disciplinas disciplinas = new frm_AP_Disciplinas();
            disciplinas.Show();
        }

        private void btn_AP_Notas_Click(object sender, EventArgs e)
        {
            frm_AP_Notas notas = new frm_AP_Notas();
            notas.Show();
        }

        private void btn_AP_Classes_Click(object sender, EventArgs e)
        {
            frm_AP_Classes classes = new frm_AP_Classes();
            classes.Show();
        }
    }
}
