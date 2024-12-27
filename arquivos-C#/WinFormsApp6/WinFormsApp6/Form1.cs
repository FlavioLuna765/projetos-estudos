using WinFormsApp6.Model;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa { Id = 1, Nome = "João", Idade = 25 },
                new Pessoa { Id = 2, Nome = "Maria", Idade = 30 },
                new Pessoa { Id = 3, Nome = "Pedro", Idade = 22 }
            };

            dataGridView1.DataSource = pessoas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {

                MessageBox.Show("Preecnha o campo");
            }
            else{
                MessageBox.Show($"{textBox1.Text}");
            }
        }
    }
}