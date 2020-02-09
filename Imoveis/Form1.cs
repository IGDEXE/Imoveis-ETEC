using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Imoveis
{
    public partial class frmBusca : Form
    {
        public frmBusca()
        {
            InitializeComponent();
        }
        ImoveisDAL imvD = new ImoveisDAL();

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvBusca.DataSource = null;
            dgvBusca.DataSource = imvD.ConsultaCidade(txtBusca.Text);
        }

        private void frmBusca_Load(object sender, EventArgs e)
        {

        }

        private void imgSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
