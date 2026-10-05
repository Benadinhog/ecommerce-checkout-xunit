namespace EcommerceCheckout.App;

public class PedidoService
{
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        return $"{regiao.ToUpper()}-{numeroPedido:D4}";
    }

    public int CalcularPontosFidelidade(int valorTotal)
    {
        return (valorTotal / 10) * 2;
    }

    public bool TemDireitoAFreteGratis(int valorTotal, bool clienteVIP)
    {
        return valorTotal >= 200 || clienteVIP;
    }
}