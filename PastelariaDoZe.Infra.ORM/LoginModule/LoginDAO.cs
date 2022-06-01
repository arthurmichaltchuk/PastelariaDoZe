﻿using PastelariaDoZe.Infra.Logger;
using PastelariaDoZe.Infra.ORM.FuncionarioModule;

namespace PastelariaDoZe.Infra.ORM.LoginModule
{
    public class LoginDAO
    {
        private FuncionarioDAO funcionarioService;
        public LoginDAO(FuncionarioDAO funcionarioService)
        {
            this.funcionarioService = funcionarioService;
        }
        public string ValidarLogin(string usuario, string senha)
        {
            string resultado = ValidarChaves(usuario, senha);

            switch (resultado)
            {
                case "valido": Serilogger.Logger.Information("LOGIN FEITO | USUÁRIO {Usuario}", usuario); break;

                case "Senha Incorreta": Serilogger.Logger.Information("TENTATIVA DE LOGIN | USUÁRIO {Usuario}", usuario); break;

                case "Usuário Inexistente": Serilogger.Logger.Information("ERRO DE LOGIN | USUÁRIO INEXISTENTE"); break;

                default: break;
            }

            return resultado;
        }

        private string ValidarChaves(string usuario, string senha)
        {
            if (usuario == "admin" && senha == "admin")
                return "valido";

            bool usuarioExiste = false;
            var funcionarios = funcionarioService.GetAll();

            foreach (var funcionario in funcionarios)
            {
                if (usuario == funcionario.Usuario)
                {
                    usuarioExiste = true;
                    if (senha == funcionario.Senha)
                        return "valido";
                }
            }
            return (usuarioExiste) ? "Senha Incorreta" : "Usuário Inexistente";
        }
    }
}
