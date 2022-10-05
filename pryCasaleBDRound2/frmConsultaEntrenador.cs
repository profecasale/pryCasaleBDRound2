using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCasaleBDRound2
{
    public partial class frmConsultaEntrenador : Form
    {
        frmMain objMainBaseDatos = new frmMain();

        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void frmConsultaEntrenador_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception mensajito)
            {
                lblDatos.Text = mensajito.Message;
                //throw;
            }

        }
    }
}
