using CaixaEconomica.Beneficio.Dominio.Interfaces.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEconomica.Beneficio.Dominio.Entidades
{
    public abstract class Entidade
    {
        private INotificacaoDominio _notificacaoDominio;

        protected INotificacaoDominio NotificacaoDominio
        {
            get
            {
                return _notificacaoDominio == null ?
                    throw new Exception("Erro: NotificacaoDominio não foi instanviado. Favor chamar o SetNotificacao.")
                    : _notificacaoDominio;
            }
        }

        public void SetNotificacao(INotificacaoDominio notificacaoDominio)
        {
            _notificacaoDominio = notificacaoDominio;
        }

        public bool EhValido()
        {
            return _notificacaoDominio.Validado();
        }
    }
}
