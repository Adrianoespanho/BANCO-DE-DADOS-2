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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=agenda;password=;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefas", conn);

            DataTable dt = new DataTable();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            dataGridView1.DataSource= dt;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = textBox1.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=agenda;password=;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarefas where tarefas like '%"+pesquisa+"%'", conn);

            DataTable dt = new DataTable();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fcadastro = new Form2();
            fcadastro.Show();

        }
    }
}
