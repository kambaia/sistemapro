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
    public partial class Tesouraria : Form
    {
        public Tesouraria()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmIncricao matricula = new frmIncricao();
            matricula.Show();
        }

        private void btn_ConfMatricula_Click(object sender, EventArgs e)
        {
            frm_ConfMatriculas confirmacao = new frm_ConfMatriculas();
            confirmacao.Show();
        }

        private void btn_PagPropinas_Click(object sender, EventArgs e)
        {
            frm_PagPropinas propinas = new frm_PagPropinas();
            propinas.Show();
        }

        private void btn_Documentos_Click(object sender, EventArgs e)
        {
            frm_Documentos documentos = new frm_Documentos();
            documentos.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frm_Visu_Inscricao visualizar = new frm_Visu_Inscricao();
            visualizar.Show();
        }
    }
}
