using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Operaciones
{
  // Lee el CSV y almacenarlo en una lista
  public List<Transaccion> LeerCSV(string path)
  {
    string[] lines = File.ReadAllLines(path);
    /* Iteramos por fila y descomponemos en un nuevo array */
    bool primeraLinea = true;
    List<Transaccion> transacciones = new List<Transaccion>();
    foreach (string line in lines)
    {
      if (primeraLinea)
      {
        primeraLinea = false;
        continue;
      }

      string[] values = line.Split(',');
      transacciones.Add(new Transaccion(
                        int.Parse(values[0]),
                        values[1],
                        double.Parse(values[2], CultureInfo.InvariantCulture)
                    ));
    }
    return transacciones;
  }
  public double SumarPorTipo(List<Transaccion> obj, string tipo)
  {
    double total = 0;
    foreach (Transaccion transaccion in obj)
    {
      if (transaccion.Type == tipo)
      {
        total += transaccion.Amount;
      }
    }
    return total;
  }
  public double CalcularBalanceTotal(double credito, double debito)
  {
    return credito - debito;
  }
  public Transaccion? ObtenerTransaccionMayor(List<Transaccion> obj)
  {
    var result = obj.OrderByDescending(x => x.Amount).FirstOrDefault();

    if (result == null)
    {
      Console.WriteLine("No se encontraron transacciones.");
      return null;
    }
    return result;
  }

  public int ObtenerTotalPorTipo(List<Transaccion> obj, string tipo)
  {
    return obj.Count(t => t.Type.Equals(tipo, StringComparison.OrdinalIgnoreCase));
  }

  public void GenerarReporte(string path)
  {
    var transacciones = LeerCSV(path);

    var SumaCredito = SumarPorTipo(transacciones, "Crédito");
    var SumaDebito = SumarPorTipo(transacciones, "Débito");
    var BalanceFinal = CalcularBalanceTotal(SumaCredito, SumaDebito);
    var TransaccionMayor = ObtenerTransaccionMayor(transacciones);
    var TotalCredito = ObtenerTotalPorTipo(transacciones, "Crédito");
    var TotalDebito = ObtenerTotalPorTipo(transacciones, "Débito");

    Console.WriteLine("\nReporte de Transacciones");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine($"Balance Final: {BalanceFinal:F2}");
    Console.WriteLine($"Transacción de Mayor Monto: ID {TransaccionMayor.ID} - {TransaccionMayor.Amount:F2}");
    Console.WriteLine($"Conteo de Transacciones: Crédito: {TotalCredito} Débito: {TotalDebito}");
    Console.WriteLine("---------------------------------------------");
  }

}