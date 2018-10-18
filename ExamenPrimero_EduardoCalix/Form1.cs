using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimero_EduardoCalix
{
    public partial class frmReseña : Form
    {
        public frmReseña()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            private void btnCargarMonedas_Click(object sender, EventArgs e)
            {
                // Crear el query
                string sqlSelect = @"SELECT CurrencyCode
                                 FROM Sales.Currency";

                // Crear el comando
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);

                try
                {
                    // Establecer la conexión
                    conn.Open();

                    // Ejecutar el query vía un Execute Reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        lstCodigoMoneda.Items.Add(rdr[0]);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
                }
                finally
                {
                    // Cerrar la conexión
                    conn.Close();
                }
            }

            private void btnEliminarMoneda_Click(object sender, EventArgs e)
            {
                // Crear el comando que va a llamar al Stored Procedure
                SqlCommand cmd = new SqlCommand("sp_DeleteCurrency", conn);

                // Establecer el comando como un Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Parámetro del Stored Procedure
                    cmd.Parameters.Add(new SqlParameter("currencyCode", SqlDbType.NVarChar, 3));
                    cmd.Parameters["currencyCode"].Value = lstCodigoMoneda.SelectedItem.ToString();

                    // Establecer la conexión
                    conn.Open();

                    // Eliminación de la moneda
                    if (lstCodigoMoneda.SelectedIndex == -1)
                    {
                        MessageBox.Show("Favor seleccionar una moneda antes de ejecutar la acción de eliminar", "Información");
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        lblEstadoEliminacion.Text = "¡Moneda eliminada satisfactoriamente!";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Recarge el valor del listado de monedas " + ex.StackTrace, "Detalles de la excepción");
                }
                finally
                {
                    // Cerrar la conexión
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
