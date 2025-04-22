class Transaccion
{
  public int ID { get; set; }
  public string Type { get; set; }
  public double Amount { get; set; }

  public Transaccion(int id, string name, double amount)
  {
    ID = id;
    Type = name;
    Amount = amount;
  }
}