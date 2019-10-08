﻿namespace Auditoria.Dados.Entidades
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public string Moeda { get; set; }
        public int IdUsuario { get; set; }
        public Cartao Cartao { get; set; }

        public string RegistrarPagamento()
        {
            return $@"Foi realizado um pagamento no valor de: {Moeda} {Valor.ToString("0.##")}, no cartão de {Cartao.NomeProprietario}.";
        }
    }
}
