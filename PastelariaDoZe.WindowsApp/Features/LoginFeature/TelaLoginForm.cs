using PastelariaDoZe.Infra.ORM.LoginModule;
using PastelariaDoZe.WindowsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastelariaDoZe.WindowsApp.Features.LoginFeature
{
    public partial class TelaLoginForm : Form
    {
        private LoginDAO loginService;

        public TelaLoginForm(LoginDAO loginService)
        {
            this.loginService = loginService;
            InitializeComponent();
            SetColor();
        }


        private void SetColor()
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            string resultValidacao = loginService.ValidarLogin(usuario, senha);

            if (resultValidacao == "valido")
            {
                ChamarTelaPrincipal();
                this.Close();
            }
            else
            {
                Footer.BackColor = Color.Red;
                labelFooter.Text = resultValidacao;
                Footer.BackColor = (resultValidacao == "Senha Incorreta") ? Color.Gold : Color.Red;
            }
        }

        private void ChamarTelaPrincipal()
        {
            this.Hide();
            TelaPrincipalForm telaPrincipal = new();
            telaPrincipal.ShowDialog();
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            //Serilogger.Logger.Information("Troca de modo de exibição");
            //DarkMode.TrocarModo();
            //SetColor();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
