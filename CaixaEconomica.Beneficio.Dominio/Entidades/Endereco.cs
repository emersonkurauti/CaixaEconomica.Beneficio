using CaixaEconomica.Beneficio.Dominio.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public class Endereco : Entidade, IEquatable<Endereco>
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int TipoEnderecoId { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public bool Equals(Endereco other)
        {
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Rua))
                NotificacaoDominio.AddErro("Erro: Rua deve ser informada.");
            if (Numero == 0)
                NotificacaoDominio.AddErro("Erro: Número deve ser informado.");
            if (TipoEnderecoId == 0)
                NotificacaoDominio.AddErro("Erro: Tipo de Endereco deve ser informado.");
        }
    }
}
