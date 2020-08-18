using CaixaEconomica.Beneficio.Dominio.Notification;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public class Pessoa : Entidade
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public int QtdFilhos { get; set; }
        public int CodigoOcupacao { get; set; }

        private readonly HashSet<Endereco> _enderecos = new HashSet<Endereco>();
        public IEnumerable<Endereco> Enderecos => _enderecos.ToList().AsReadOnly();

        public Pessoa()
        {
            SetNotificacao(new NotificacaoDominio());
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            if (endereco == null)
            {
                NotificacaoDominio.AddErro("Erro: endereço deve ser instanciado");
            }
            else
            {
                endereco.SetNotificacao(NotificacaoDominio);
                endereco.Validar();
                if (endereco.EhValido())
                    _enderecos.Add(endereco);
                else
                    NotificacaoDominio.AddErro("Erro: endereço inválido");
            }
        }

        private readonly HashSet<BeneficioPessoa> _beneficioPessoas = new HashSet<BeneficioPessoa>();
        public IEnumerable<BeneficioPessoa> BeneficioPessoa => _beneficioPessoas.ToList().AsReadOnly();

        public void AdicionarBeneficioPessoa(BeneficioPessoa beneficioPessoa)
        {
            if (beneficioPessoa != null)
                _beneficioPessoas.Add(beneficioPessoa);
        }
    }
}
