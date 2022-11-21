  class produto :item {
    public double valorAPagarProduto {get;set;}
    public  produto(int tipoDeCliente, int quantidade) : base(tipoDeCliente, quantidade)
    {
    }
    public override double reajustarDesconto()
    {
        if(tipoDeCliente == 1)
        {
             preco = preco * quantidade;
            valorAPagarProduto = (preco - (preco * 0.10)); 

        }
        else if(tipoDeCliente == 2)
        {
             preco = preco * quantidade;
               valorAPagarProduto = (preco - (preco * 0.10)); 
        }
           else if(tipoDeCliente == 3)
        {
             preco = preco * quantidade;
            valorAPagarProduto = (preco - (preco * 0.10)); 
        }
        return valorAPagarProduto;
    }
    
}