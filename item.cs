  abstract class item {
    
    public int tipoDeCliente {get;set;}
    public int quantidade {get;set;}
    public item(int tipoDeCliente, int quantidade)
    {
     this.tipoDeCliente = tipoDeCliente;
     this.quantidade = quantidade;   
    }
    public string ? NomeItem{get;set;}
    public  double preco{get;set;}
    
   public abstract double reajustarDesconto(); 

}