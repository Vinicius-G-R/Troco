decimal ValorCompra, ValorPago, ValorTroco;

Console.Write("Digite o Valor da compra: ");
ValorCompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o Valor pago: ");
ValorPago = Convert.ToDecimal(Console.ReadLine());

ValorTroco = ValorPago - ValorCompra;

Console.WriteLine($"Seu troco é {ValorTroco}"); 