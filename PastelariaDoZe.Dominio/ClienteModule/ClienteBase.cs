﻿using PastelariaDoZe.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace PastelariaDoZe.Dominio.ClienteModule
{
    public class ClienteBase : EntidadeBase
    {
        public override string Validar()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return Nome;
        }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
