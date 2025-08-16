using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace examenemiliocalderon
{
    public partial class Form1 : Form
    {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-LOURDES;Initial Catalog=Producto2; Integrated Security=True");
        public Form1()

        {
            InitializeComponent();
        }

        private void agregar()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from perfumes", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "a");
            dataGridView1.DataSource = ds.Tables["a"].DefaultView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO perfumes (nombre, precio, stock) VALUES('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text +  "')", conn);
            sda.SelectCommand.ExecuteNonQuery();
            agregar();
            MessageBox.Show("Producto registrado");
            conn.Close();

        }
        private void CargarDatos()
        {
            string connectionString = "Server=localhost;Database=Producto2;Integrated Security=True;";
            string query = "SELECT * FROM perfumes";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Producto2;Integrated Security=True;";
            string query = "UPDATE perfumes SET Nombre = @nombre, precio = @precio, Stock = @stock WHERE Id = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@precio", textBox2.Text);
                        cmd.Parameters.AddWithValue("@stock", textBox3.Text);
                        cmd.Parameters.AddWithValue("@id", textBox4.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto modificado correctamente.");
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con ese ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM perfumes WHERE ID=" + textBox4.Text;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            conn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    textBox4.Text = reader[0].ToString();
                    textBox1.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();
                }
                else
                    MessageBox.Show("Ningun registro encontrado con el Id ingresado !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            textBox5.Text = "";
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM perfumes WHERE ID=" + textBox5.Text;

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro eliminado correctamente !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Conexion Exitosa");
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporte1 rm1 = new Reporte1();
            rm1.ShowDialog();
        }
    }
}
