using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {

        private MySqlConnection con;
        private MySqlDataAdapter da;
        private DataTable dtProdutos;
        public Form1()
        {
            InitializeComponent();

            string connectionString = "Server=localhost;Database=Loja;Uid=root;Pwd=uninove;";
            con = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Abrir conexão com o banco de dados
                con.Open();

                // Criar comando SQL para selecionar produtos
                string sql = "SELECT id, produto, marca, valor FROM produtos";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Executar comando e obter dados em um DataTable
                da = new MySqlDataAdapter(cmd);
                dtProdutos = new DataTable();
                da.Fill(dtProdutos);

                // Atualizar DataGridView com os dados da tabela
                dgvProdutos.DataSource = dtProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            finally
            {
                // Fechar conexão com o banco de dados
                con.Close();
            }
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir conexão com o banco de dados
                con.Open();

                // Criar comando SQL para selecionar produtos
                string sql = "SELECT id, produto, marca, valor FROM produtos";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Executar comando e obter dados em um DataTable
                da = new MySqlDataAdapter(cmd);
                dtProdutos = new DataTable();
                da.Fill(dtProdutos);

                // Atualizar DataGridView com os dados da tabela
                dgvProdutos.DataSource = dtProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            finally
            {
                // Fechar conexão com o banco de dados
                con.Close();
            }
        }
    }
}