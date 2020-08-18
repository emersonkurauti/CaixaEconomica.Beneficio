using CaixaEconomica.Beneficio.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEconomica.Beneficio.Teste.Dominio.Entidades.Pessoa
{
    [TestClass]
    public class PessoaTemPeloMenosUmEnderecoValido
    {
        private Beneficio.Dominio.Entidades.Pessoa pessoa;
        private Endereco endereco;

        [TestInitialize]
        public void Init()
        {
            pessoa = new Beneficio.Dominio.Entidades.Pessoa();
            endereco = new Endereco() { Id = 1, Rua = "Teste", Numero = 100, TipoEnderecoId = 1 };
            pessoa.AdicionarEndereco(endereco);
        }

        [TestMethod]
        public void TestarTemPeloMenosUmEndereco()
        {
            Assert.IsTrue(pessoa.Enderecos.Any());
        }
    }
}
