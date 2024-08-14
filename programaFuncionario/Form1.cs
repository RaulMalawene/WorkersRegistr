using programaFuncionario.Conexao;
using programaFuncionario.Funcionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textNome.Focus();
            imprimirFunc();
        }

        public void imprimirFunc()
        {
            ArrayList funcionarios = new ArrayList();
            conexao func = new conexao();
            funcionarios = func.imprimirFuncionarios();
            ListViewItem lstv;
            foreach (Funcionarios funcionario in funcionarios)
            {
                string[] dados = new string[] { funcionario.getCodigo() + "", funcionario.getNome(), funcionario.getDiasTrabalhados() + "", funcionario.getSalarioDiario() + "", funcionario.salarioMensal() + "" };
                lstv = new ListViewItem(dados);
                listView.Items.Add(lstv);
            }
        }


        private void editar_Click(object sender, EventArgs e)
        {

        }

        private void gravar_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            conexao conn = new conexao();
            int codigo = int.Parse(textCodigo.Text);
            string nome = textNome.Text;
            int diasTrabalhados = int.Parse(textDia_traba.Text);
            double salarioDiario = double.Parse(textSalarioDiario.Text);
            Funcionarios fun = new Funcionarios(codigo, nome, diasTrabalhados, salarioDiario);
           
                imprimirFunc();
          
        



        }

        private void remover_Click(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            
        }
    }
}
