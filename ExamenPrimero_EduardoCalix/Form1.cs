using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamenPrimero_EduardoCalix
{
    public partial class frmReseña : Form
    {
        public frmReseña()
        {
            InitializeComponent();
        }
        // Crear la conexión con el manejador de la base de datos
        SqlConnection conn = new SqlConnection(@"server = (local);
            integrated security = true; database = AdventureWorks2014;");

        public int ID;
        private void lblNombre_Click(object sender, EventArgs e)
        {
            
           
        }
        //Boton salir
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReseña_Load(object sender, EventArgs e)
        {
            //Crear el query
           
            string sql = @"SELECT ProductID,Name From Production.Product WHERE FinishedGoodsFlag=1";

            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                // Establecer la conexión
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                  lvProductos.Items.Add(dr[0]);
                  ID=lvProductos.Items.Add(dr[1]);


                }
               

 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // 
                // Cerrar la conexión
                conn.Close();
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {


            // Crear el comando

            SqlCommand cmd = new SqlCommand("sp_crearReseña", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                using (cmd)
                {
                    cmd.Parameters.Add(new SqlParameter("@idProducto", SqlDbType.Int));
                    cmd.Parameters["@idProducto"].Value = ID;
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@name"].Value = txtNombre.Text;
                    cmd.Parameters.Add(new SqlParameter("@fechaReseña", SqlDbType.DateTime));
                    cmd.Parameters["@fechaReseña"].Value = DateTime.Now;
                    cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@correo"].Value = txtCorreo.Text;
                    cmd.Parameters.Add(new SqlParameter("@valoracion", SqlDbType.Int));
                    cmd.Parameters["@valoracion"].Value = txtValoracion.Text;
                    cmd.Parameters.Add(new SqlParameter("@comentario", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@comentario"].Value = txtComentario.Text;
                    cmd.Parameters.Add(new SqlParameter("@fechaModificacion", SqlDbType.DateTime));
                    cmd.Parameters["@fechaModificacion"].Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
                // Mostrar mensaje satisfactorio al usuario
                // lblEstado.Text = "¡Nuevo Reseña del producto guardada satisfactoriamente!";
                
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

        private void lvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = lvProductos.SelectedItem.ToString();
        }
       
    }
    }
