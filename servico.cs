  class servico :item {
    public double valorAPagarServico {get;set;}
    public  servico(int tipoDeCliente, int quantidade) : base(tipoDeCliente, quantidade){
    }
    public override double reajustarDesconto()
    {
        if(tipoDeCliente == 1)
        {
            preco = preco * quantidade;
            valorAPagarServico = (preco - (preco * 0.20)); 
        }
        else if(tipoDeCliente == 2)
        {
            preco = preco *quantidade;
            valorAPagarServico = (preco - (preco * 0.15)); 
        }
           else if(tipoDeCliente == 3)
        {
            preco = preco *quantidade;
            valorAPagarServico = (preco -(preco * 0.10)); 
        }
        return valorAPagarServico;
    }
    
}