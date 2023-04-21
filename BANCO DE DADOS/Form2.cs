using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANCO_DE_DADOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=agenda;password=;");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tarefas (tarefas) VALUES (@TAREFAS)", conn);
            cmd.Parameters.AddWithValue("@TAREFAS", textBox1.Text);
            
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("DADOS inseridos com sucesso!");
            }
            else
            {
                MessageBox.Show("falha ao inserir dados.");
            }


        }
    }
}
