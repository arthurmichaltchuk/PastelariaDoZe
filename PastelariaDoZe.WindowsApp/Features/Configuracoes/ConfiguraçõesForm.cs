using System;
using System.Configuration;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp.Features.Configuracoes
{
    public partial class ConfiguraçõesForm : Form
    {
        public ConfiguraçõesForm()
        {
            InitializeComponent();
            CarregarConfiguracoes();
            SetColor();
        }

        private void SetColor()
        {


        }
        public void CarregarConfiguracoes()
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja gravar as configurações atuais?",
            "Configurações do Sistema",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string resultadoValidacao = "ESTA_VALIDO";

                if (resultadoValidacao == "ESTA_VALIDO")
                {
                    AtualizarLinguagemPadrao();
                    TelaPrincipalForm.Instancia.AtualizarRodape("Configurações salvadas com sucesso!");
                }
                else
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(resultadoValidacao);
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void txtBoxJustNumbers_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBoxZerado_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_JurosDiarios.Text))
            {
                txt_JurosDiarios.Text = "0";
            }
            else if (String.IsNullOrEmpty(txt_MultaAtraso.Text))
            {
                txt_MultaAtraso.Text = "0";
            }           
        }

        private void AtualizarLinguagemPadrao()
        {           
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxLinguagem.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();

            if (checkboxReiniciar.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
