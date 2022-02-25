using CRUD_Restaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PLayer
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Inserir(txtNome.Text, txtCidade.Text, txtEmail.Text, txtCelular.Text,txtData.Text);
            MessageBox.Show("Cadastro realizado com sucesso!");
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            txtNome.Text = "";
            txtData.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Localiza(Id);
            txtNome.Text = cliente.nome;
            txtCidade.Text = cliente.cidade;
            txtEmail.Text = cliente.email;
            txtCelular.Text = cliente.celular;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Atualizar(Id,txtNome.Text, txtCidade.Text, txtEmail.Text, txtCelular.Text);
            MessageBox.Show("Cadastro atualizado com sucesso!");
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            txtNome.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtData.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Exclui(Id);
            MessageBox.Show("Cadastro excluído com sucesso!");
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            txtNome.Text = "";
            txtCidade.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtData.Text = "";
        }
    }
}
