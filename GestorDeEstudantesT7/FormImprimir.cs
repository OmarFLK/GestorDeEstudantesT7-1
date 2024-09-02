using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormImprimir : Form
    {
        public FormImprimir()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        public void preencheTabela(MySqlCommand comando)
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

            // Mostra o total de alunos
            //labelTotalDeAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }


        private void buttonFiltrar_Click(object sender, EventArgs e)

        {
            // Filtra os dados que serão exibidos na tabela.
            MySqlCommand comando;
            string busca;

            // verificar se o usuário quer usar um intervalo
            // de datas
            if (radioButtonSim.Checked == true)
            {
                // pega as datas que o usuário selecionou.
                string dataInicial = dateTimePickerInicial.Value.ToString("yyyy-MM-dd");
                // formato dia/mês/ano ex. 27/08/2024.
                string dataFinal = dateTimePickerFinal.Value.ToString("yyyy-MM-dd");

                if (radioButtonMasculino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '"
                        + dataInicial + "' AND '"
                        + dataFinal + "' AND genero = 'Masculino'";
                }
                else if (radioButtonFeminino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '"
                        + dataInicial + "' AND '"
                        + dataFinal + "' AND genero = 'Feminino'";
                }
                else
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '"
                        + dataInicial + "' AND '"
                        + dataFinal + "'";
                }

                comando = new MySqlCommand(busca);
                preencheTabela(comando);
            }
            else
            {
                if (radioButtonMasculino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE genero = 'Masculino'";
                }
                else if (radioButtonFeminino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE genero = 'Feminino'";
                }
                else
                {
                    busca = "SELECT * FROM `estudantes`";
                }

                comando = new MySqlCommand(busca);
                preencheTabela(comando);
            }
        }

        private void FormImprimirAlunos_Load(object sender, EventArgs e)
        {
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

            if (radioButtonNao.Checked == true)
            {
                dateTimePickerInicial.Enabled = false;
                dateTimePickerFinal.Enabled = false;
            }
        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvarEmArquivoDeTexto_Click(object sender, EventArgs e)
        {
            //salva o arquivo em arquivo de texto
            //por padrao vai salvar na area de trabalho XD

            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\lista_de_estudantes.txt";

            using (var escritor = new StreamWriter(caminho))
            {
                //verificar se o arquivo de texto ja existe
                if (!File.Exists(caminho))
                {
                    File.Create(caminho);
                }

                DateTime dataDeNascimento;

                for (int i = 0; i < dataGridViewListaDeAlunos.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewListaDeAlunos.Columns.Count; j++)
                    {
                        if (j == 3)
                        {
                            dataDeNascimento = Convert.ToDateTime(dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString());

                            escritor.Write("\t" + dataDeNascimento.ToString("dd-MM-yyyy") + "\t" + "|");

                        }

                        else if (j == dataGridViewListaDeAlunos.Columns.Count - 2)

                        {
                        escritor.Write("\t" + dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString());
                        }


                        else
                        {
                            escritor.Write("\t" + dataGridViewListaDeAlunos.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    escritor.WriteLine();
                    escritor.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                escritor.Close();
                MessageBox.Show("Dados Salvos");

            }
        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Enabled = false;
            dateTimePickerFinal.Enabled = false;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Enabled = true;
            dateTimePickerFinal.Enabled = true;
        }

        private void FormImprimir_Load(object sender, EventArgs e)
        {
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

            if (radioButtonNao.Checked == true)
            {
                dateTimePickerInicial.Enabled = false;
                dateTimePickerFinal.Enabled = false;
            }
        }
    }
}
