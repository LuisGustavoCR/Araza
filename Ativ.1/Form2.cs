/*Atividade 1 - Luis Gustavo Correa Resende
 * Data: 07/10/2022
 * Forms2: Contiua o cadastro dos clientes registrados no forms1 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ativ._1
{
    public partial class Form2 : Form
    {
        //Criação do objeto
        Cadastro cli = new Cadastro();
        public static String sexo;

        public Form2()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            //Consultar
            string consulta = "CPF: " + Form1.cpf +
                              "\n Nome Completo: " + Form1.nome +
                              "\n Data de Nascimento: " + Form1.nasc +
                              "\n Email: " + Form1.email +
                              "\n Senha: " + Form1.senha +
                              "\n \n -----------------------" +
                              "\n Sexo: " + sexo +
                              "\n Estado: " + cli.getestado() +
                              "\n Cidade: " + cli.getcidade() +
                              "\n Rua: " + cli.getrua() +
                              "\n CEP: " + cli.getcep() +
                              "\n Profissão: " + cli.getprofissao() +
                              "\n Salário: " + cli.getsalario() +
                              "\n Estado Civil: " + cli.getest_civil();



         MessageBox.Show(consulta, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Application.Exit();
            

        }
        // Definição dos 3 botões
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sexo = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sexo = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sexo = radioButton3.Text;
        }

        private void button1_Click_1(object sender, EventArgs e) // Salvar informações forms 2
        {
            cli.setestado(textBox1.Text);
            cli.setcidade(textBox2.Text);
            cli.setrua(textBox3.Text);
            cli.setcep(textBox4.Text);
            cli.setprofisssao(textBox5.Text);
            cli.setsalario(float.Parse(textBox6.Text));
            cli.setest_civil(textBox7.Text);

            MessageBox.Show("Cliente cadastro com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
