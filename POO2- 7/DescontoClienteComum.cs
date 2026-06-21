public class DescontoClienteComum : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor - (valor * 0.05m);
    }
}