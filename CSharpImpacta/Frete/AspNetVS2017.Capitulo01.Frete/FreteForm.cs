using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();
            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            decimal percentual = 0;
            var valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<string>() {"BA", "PE", "AL" }; //parenteses() é opcional
     
            switch (ufComboBox.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;
                case "RJ":
                    percentual = 0.3m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                case "SC":
                    percentual = 0.1m;
                    break;
                case var uf when nordeste.Contains(uf):
                    percentual = 0.45m;
                    break;
                case null:
                    throw new NullReferenceException("ComboBox Nulo");
                default:
                    percentual = 0.5m;
                    break;
            }

            freteTextBox.Text = percentual.ToString("P1");
            totalTextBox.Text = (valor * (1 + percentual)).ToString("C2");
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();
            //clienteTextBox.Text == string.Empty
            if (string.IsNullOrEmpty(clienteTextBox.Text))
            {
                erros.Add("Campo Cliente Vazio.");
            }
            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione um UF.");
            }
            if (string.IsNullOrEmpty(valorTextBox.Text))
            {
                erros.Add("Campo Valor Vazio.");
            }

            if (valorTextBox.Text == string.Empty)
            {
                erros.Add("O campo Valor é obrigatório.");
            }
            else
            {
                if (!decimal.TryParse(valorTextBox.Text, out decimal valor))
                {
                    erros.Add("O campo Valor está com formato inválido.");
                }
            }

            return erros;
        }

        private void ufComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limparButton_Click(object sender, EventArgs e)
        {   //maneiras de limpar a tela
            clienteTextBox.Text = "";
            ufComboBox.SelectedIndex = -1;
            valorTextBox.Clear();
            freteTextBox.Text = null;
            totalTextBox.Text = string.Empty;

            clienteTextBox.Focus();
            //this.Close();
        }
    }
}
