using DataBase.Models;
using EntityFramework.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Criando uma venda
                var conta = new Conta();
                conta.Login = "Teste";
                conta.Senha = "123";

                using (var ctx = new ProvaContext())
                {
                    ctx.Contas.Add(conta);
                    ctx.SaveChanges();
                }
                //    VendasContexto context = new VendasContexto();
                //// adicionando os registros e salvando
                //context.Clientes.Add(NovoCliente);
                //context.Vendas.Add(NovaVenda);
                //context.SaveChanges();
                MessageBox.Show("Registro adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu durante o processo: " + ex.Message);
            }
        }
    }
}
