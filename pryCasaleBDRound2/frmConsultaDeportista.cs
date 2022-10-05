using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace pryCasaleBDRound2
{
    public partial class frmConsultaDeportista : Form
    {

        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeLaBase;
        OleDbDataReader lectorDeConsultas;
        string varRutaDeBaseDeDatos =
            "D:\\Escritorio\\pryCasaleBDRound2\\pryCasaleBDRound2\\DEPORTE.accdb";
        
        public frmConsultaDeportista()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportista_Load(object sender, EventArgs e)
        {

            try
            {                
                conexionBase = new OleDbConnection(
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                    varRutaDeBaseDeDatos);

                conexionBase.Open();

                queQuieroDeLaBase = new OleDbCommand();

                queQuieroDeLaBase.Connection = conexionBase;
                queQuieroDeLaBase.CommandType = CommandType.TableDirect;
                queQuieroDeLaBase.CommandText = "DEPORTISTA";
                
                lectorDeConsultas = queQuieroDeLaBase.ExecuteReader();

                lblDatos.Text = "";

                while (lectorDeConsultas.Read())
                {
                    lblDatos.Text += lectorDeConsultas["Nombre"].ToString() + "\n";
                }

                lectorDeConsultas.Close();
                conexionBase.Close();

                //REDUCIR LA RUTA EL ARCHIVO, QUE INDIQUE A LA CARPETA DEL PROYECTO
                //VINCULAR LA GRILLA CON LOS DATOS

            }
            catch (Exception mensajito)
            {
                lblDatos.Text = mensajito.Message;
                
            }

        }
    }
}
