using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        
        int x = 32;
        int w = 45;
        int y = 16;
        int z = 32;
        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;
            

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add(string.Concat("b = ", b));
            resultadoListBox.Items.Add(string.Format("c = {0}", c));
            resultadoListBox.Items.Add($"d = {d}"); //string interpolada

            resultadoListBox.Items.Add("---------------------------------------");

            resultadoListBox.Items.Add("c * d = " + (c*d));
            resultadoListBox.Items.Add("c / d = " + (c / d));
            resultadoListBox.Items.Add("d % a = " + (d % a));



        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x = " + x);

            x = x - 3;
            x -= 3;

         
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;

            int b;
            b = 5;

            resultadoListBox.Items.Add("Exemplo Pré-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + ++a " +( 2+ ++a));
            resultadoListBox.Items.Add("a = " + a);

            resultadoListBox.Items.Add("Exemplo Pós-Incremental");
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add("2 + b++ " + (2 + b++));
            resultadoListBox.Items.Add("b = " + b);

        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            ApresentarVariaveis();

            resultadoListBox.Items.Add("w <= x = " + (w <= x));
            resultadoListBox.Items.Add("x == z = " + (x == z));
            resultadoListBox.Items.Add("x != z = " + (x != z));
        }

        private void ApresentarVariaveis()
        {
            resultadoListBox.Items.Add("x = " + x);
            resultadoListBox.Items.Add("w = " + w);
            resultadoListBox.Items.Add("y = " + y);
            resultadoListBox.Items.Add("z = " + z);

            resultadoListBox.Items.Add(new string('-', 50)); //cria varios tracejados --------------
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApresentarVariaveis();
            resultadoListBox.Items.Add("w <= x || y == 16 = " + (w <= x || y==16));
            resultadoListBox.Items.Add("x == z && x != z = " + (x == z && x != z));
            resultadoListBox.Items.Add("!(y > w) = " + (!(y > w)));
         
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2020;

            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
                ano % 4 == 0 ? "Sim" : "Não" ));

            ano = 2014;
            resultadoListBox.Items.Add(string.Format("O ano {0} é bissexto? {1}.", ano,
               DateTime.IsLeapYear(ano) ? "Sim" : "Não"));
        }
    }
}
