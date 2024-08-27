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

namespace GestorDeEstudantesT7
{
    public partial class FormImprimir : Form
    {
        public FormImprimir()
        {
            InitializeComponent();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)

        {
            //filtra os dados q serao exibidos
            // MySqlCommand comando;
            //string busca;
            //verificar se o usuario quer usar um intervalo de datas

            //if(radio button SIM.checked == true)
            //{
            //
            //string dataInicial = dateTimePickerDataInicial.Value.ToString("dd-MM-yyyy");
            //String dataFinal = dateTimePickerDataFinal.Value.ToString("dd-MM-yyyy");
            //
            //  if(radioButtonMasculino.checked)
            //  {
            //  busca = "SELECT * FROM ´estudantes´ WHERE ´nascimento´ BETWEEN´"
            //  +dataInicial + "´AND´"
            //  +dataFinal + "´AND genero = ´masculino´´"
            //  }
            //}
            //
            //comando = new MySqlCommand(busca);
            //preencherTabela(comando);
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
    }
}
