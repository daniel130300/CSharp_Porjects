using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PruebaConexionSQL
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand command;
        SqlDataReader dataReader;
        DataTable dataTable;
        SqlDataAdapter dataAdapter;
        DataSet data;

        
        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=LAPTOP-Q57JSIBS\\SQLEXPRESS;Initial Catalog=Prueba_BDD;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }
        
        public string Insertar (string identidad, string nombre, string apellido, DateTime fecha)
        {

            string salida = "El registro se inserto correctamente";

            try
            {
                String query = "INSERT INTO Alumnos (Identidad, Nombre, Apellido, Fecha_nacimiento) VALUES (@identidad ,@nombre, @apellido, @fecha)";

                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@identidad", identidad);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error insertando el registro: " + ex.ToString();
            }

            return salida;
        }

        public string Eliminar (int id)
        {

            string salida = "El registro se elimino correctamente";

            try
            {
                String query = "DELETE FROM Alumnos where Id = @Id";

                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error eliminado el registro: " + ex.ToString();
            }

            return salida;
        }

        public string Modificar (int id, string identidad, string nombre, string apellido, DateTime fecha)
        {

            string salida = "El registro se modifico con éxito";

            try
            {
                String query =  "UPDATE Alumnos SET Identidad = @identidad, Nombre = @nombre, Apellido = @apellido, Fecha_nacimiento = @fecha where Id = @Id";

                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@identidad", identidad);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error modificando el registro: " + ex.ToString();
            }

            return salida;
        }

        public int AlumnoRegistrado(string identidad)
        {
            int contador = 0;

            try
            {
                String query = "SELECT * FROM Alumnos where Identidad = @identidad";

                command = new SqlCommand(query, cn);
                command.Parameters.AddWithValue("@identidad", identidad);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    contador++;
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }

            return contador;
        }

        public void cargarAlumnos(DataGridView dgv)
        {
            try
            {
                String query = "SELECT * FROM Alumnos";
                dataAdapter = new SqlDataAdapter(query, cn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        /*
        public void BusquedaAlumno(String query, ref DataGridView dgv)
        {
            dataAdapter = new SqlDataAdapter(query, cn);

            cn.Open();

            data = new DataSet();
            dataAdapter.Fill(data, "Alumnos");
            dgv.DataSource = data;
            dgv.DataMember = "Alumnos";
        }
        */
    }
}
