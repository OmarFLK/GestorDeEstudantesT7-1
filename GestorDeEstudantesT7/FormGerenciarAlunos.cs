using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            //Preencher tabela com alguns alunos do banco de dados XD
            preencherTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

        }

        //Métodos para preencher tabela com alguns alunos do banco de dados XDXD
        public void preencherTabela(MySqlCommand comando)
        {
            // Impede que os dados exibidos na tabela sejam alterados.
            dataGridViewListaDeAlunos.ReadOnly = true;
            // Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            // Determina uma altura padrão para as linhas da tabela.
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            // Determina a origem dos dados da tabela.
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            // Determinar qual SERÁ a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;

            //Mosta o total de alunos
            labeltotaldealunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }

        private void dataGridViewListaDeAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewListaDeAlunos_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[1].Value.ToString();
            textBoxSobrenome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerNascimento.Value = (DateTime)dataGridViewListaDeAlunos.CurrentRow.Cells[3].Value;

            if (dataGridViewListaDeAlunos.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                radioButtonFeminino.Checked = true;
            }
            else
            {
                radioButtonMasculino.Checked = true;
            }

            textBoxTelefone.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[5].Value.ToString();
            textBoxEndereco.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[6].Value.ToString();

            byte[] imagem;
            imagem = (byte[])dataGridViewListaDeAlunos.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream(imagem);
            pictureBoxFoto.Image = Image.FromStream(fotoDoAluno);

        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            textBoxID.Text = " ";
            textBoxNome.Text = " ";
            textBoxSobrenome.Text = " ";
            textBoxEndereco.Text = " ";
            textBoxTelefone.Text = " ";
            radioButtonFeminino.Checked = true;
            dateTimePickerNascimento.Value = DateTime.Now;
            pictureBoxFoto.Image = null;
            //apenas para save
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Abre janela para pesquisar a imagem no computador.
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonbaixarfoto_Click(object sender, EventArgs e)
        {
            SaveFileDialog baixarFoto = new SaveFileDialog();
            baixarFoto.FileName = "Estudante_" + textBoxID.Text;

            //se não tiver foto = erro
            if (pictureBoxFoto.Image == null)
            {
                MessageBox.Show("Não tem foto para baixar.");
            }

            else
            {
                baixarFoto.ShowDialog();    
                pictureBoxFoto.Image.Save(baixarFoto.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }

        }

        private void buttonbuscardados_Click(object sender, EventArgs e)
        {
            string pesquisa = "SELECT * FROM `estudantes` WHERE CONCAT" + "(`nome`,`sobrenome`,`endereco`) LIKE'%" +textBoxbuscardados.text+"%'" ;
            MySqlCommand comando = new MySqlCommand(pesquisa);
            preencherTabela(comando);
        }
    }
}
