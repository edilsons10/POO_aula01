public class Cartao
{
   public  virtual void Debitar(decimal valor)
   {
      Console.WriteLine($"Debito de {valor:C} realizado no cartao");
   }
 
}
    
