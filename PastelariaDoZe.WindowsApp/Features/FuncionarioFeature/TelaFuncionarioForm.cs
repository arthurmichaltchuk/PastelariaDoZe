using PastelariaDoZe.Dominio.FuncionarioModule;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace PastelariaDoZe.WindowsApp.Features.FuncionarioFeature
{
    public partial class TelaFuncionarioForm : Form
    {
        private Funcionario funcionario;
        public TelaFuncionarioForm()
        {
            InitializeComponent();
            SetColor();
            funcionario = new();
        }

        private void SetColor()
        {

        }

        public Funcionario Funcionario
        {
            get { return funcionario; }

            set
            {

                funcionario = value;
                text_IdFuncionario.Text = funcionario.Id.ToString();
                text_NomeFuncionario.Text = funcionario.Nome;
                text_CPFFuncionario.Text = funcionario.CpfFuncionario;
                text_salarioFuncionario.Text = funcionario.Salario.ToString();
                date_EntradaFuncionario.Value = Convert.ToDateTime(funcionario.DataEntrada);
                text_UsuarioFuncionario.Text = funcionario.Usuario;
                text_SenhaFuncionario.Text = funcionario.Senha;
            }
        }


        private void TelaFuncionarioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void bt_GravarFuncionario_Click(object sender, EventArgs e)
        {
            ConfigurarFuncionario();

            string resultadoValidacao = funcionario.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void ConfigurarFuncionario()
        {

            funcionario.Nome = text_NomeFuncionario.Text;
            funcionario.CpfFuncionario = text_CPFFuncionario.Text;
            funcionario.Usuario = text_UsuarioFuncionario.Text;
            funcionario.Senha = text_SenhaFuncionario.Text;
            funcionario.Salario = text_salarioFuncionario.Text == "" ? 0 : Convert.ToDecimal(text_salarioFuncionario.Text);
            funcionario.DataEntrada = date_EntradaFuncionario.Value;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        public void txtCampo_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
            }
        }

        public void txtCampo_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.LightCyan;
            }
        }
    }
}
