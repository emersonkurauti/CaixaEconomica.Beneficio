using System;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public class Beneficio : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DatainicioVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public bool Ativo { get; set; }

        private readonly HashSet<BeneficioPessoa> _beneficioPessoas = new HashSet<BeneficioPessoa>();
        public IEnumerable<BeneficioPessoa> BeneficioPessoa => _beneficioPessoas.ToList().AsReadOnly();

        public void AdicionarBeneficioPessoa(BeneficioPessoa beneficioPessoa)
        {
            if (beneficioPessoa != null)
                _beneficioPessoas.Add(beneficioPessoa);
        }
    }
}
