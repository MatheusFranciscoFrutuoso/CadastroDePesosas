﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas.Modelos
{
    public class PessoaFisica : Pessoa
    {
        OperacoesPessoaFisica crud = new OperacoesPessoaFisica();
        public string Rg { get; set; }
        public string Cpf { get; set; }

        public PessoaFisica(string nome, DateTime dataNasc, string Rg, string cpf, Endereco endereco)
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Rg = Rg;
            this.Cpf = cpf;
            this.Enderecoo = endereco;
        }
        public PessoaFisica()
        {

        }
        public override string ToString()
        {
            return $"\n\tNome: {Nome}\n\tData de Nascimento: {DataNascimento.ToString("MM/dd/yyyy")}\n\tRG: {Rg}\n\tCPF: {Cpf}\n\tEndereço: {Enderecoo}";
        }
    }
}

