class Program
{
     /*
     Tipo de Clientes.
      1 - Premium
      2- Gold
      3- Silver
      */
     static void Main(string []args)
     {
     /* Instanciar Classes e Passar Valores */
     clientes c = new clientes();
     c.tipoDeCliente =1;
     c.nome ="Adilson";

     // Espera o numero do clinete e a quantidade de Serviço a receber
     servico s = new servico(2,1);
     s.preco=1200;

     produto p = new produto(2,2);
     p.preco = 2000;
     double valorAPagarProduto = p.reajustarDesconto();
     /* Imprimir valores */
     double valorAPagarServico = s.reajustarDesconto();
  
     Console.WriteLine($"O Cliente {c.nome} tem o valor a pagar de "+valorAPagarServico + " Valor do Serviço a ser pago "+ valorAPagarProduto);
      
     }
}