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

namespace WinFormsApp8
{
    public partial class FormCadastro : Form
    {

        private MySqlConnection con;
        public FormCadastro()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=Loja;Uid=root;Pwd=uninove;";
            con = new MySqlConnection(connectionString);
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "" || txtMarca.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                // Abrir conexão com o banco de dados
                con.Open();

                // Criar comando SQL para inserir novo produto
                string sql = "INSERT INTO produtos (produto, marca, valor) VALUES (@produto, @marca, @valor)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Adicionar parâmetros para o comando SQL
                cmd.Parameters.AddWithValue("@produto", txtProduto.Text);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@valor", decimal.Parse(txtValor.Text));

                // Executar comando SQL para inserir o novo produto
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");

                // Limpar campos do formulário
                txtProduto.Text = "";
                txtMarca.Text = "";
                txtValor.Text = "";

                // Fechar formulário
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
            }
            finally
            {
                // Fechar conexão com o banco de dados
                con.Close();
            }
        }
    }
}
