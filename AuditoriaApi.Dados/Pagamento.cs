namespace AuditoriaApi.Dados
{
    public class Pagamento
    {
        public decimal Valor { get; set; }

        public string RegistrarPagamento()
        {
            return $@"Foi realizado um pagamento no valor de: R$ {Valor.ToString("0.##")}.";
        }
    }
}
