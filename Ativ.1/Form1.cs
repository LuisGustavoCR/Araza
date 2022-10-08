/*Atividade 1 - Luis Gustavo Correa Resende
 * Data: 07/10/2022
 * Forms1: Inicia o cadastro de clientes */



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
    public partial class Form1 : Form
    {
        //Declaração forms 2
        Form complete_cadastro = new Form2();
        
        //Declaração de classes globais
        public static String cpf;
        public static String nome;
        public static String nasc;
        public static String email;
        public static String senha;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //botao que salva e continua para o proximo forms
        {

            cpf = textBox1.Text;
            nome = textBox2.Text;
            nasc = textBox3.Text;
            email = textBox4.Text;
            senha = textBox5.Text;

            this.Hide();
            complete_cadastro.ShowDialog();
        }
    }
}








