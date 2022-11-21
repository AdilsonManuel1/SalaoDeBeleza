class clientes 
{
      public string? nome{get;set;}
      public int tipoDeCliente{get;set;}
     public int Numero ;
 /*   public clientes (int tipoDeCliente,string nome)
    {
       this.tipoDeCliente = tipoDeCliente; 
       this.nome = nome;
    }
    */

   public void valor(){
      Numero = this.tipoDeCliente; 
   }

}