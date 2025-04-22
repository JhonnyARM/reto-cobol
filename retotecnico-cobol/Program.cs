using System;
using System.IO;
using System.Collections.Generic;
// Obtener Balance
/* Operaciones operacion = new Operaciones(); */
string op;

// RutaArchivo
string path = "transaccion.csv";


// Calcular balance final
do
{
  Console.WriteLine("Procesamiento de transacciones: ");
  Console.WriteLine("1. Generar reporte");
  Console.WriteLine("2. Salir");
  op = Console.ReadLine();


  switch (op)
  {
    case "1":
      Operaciones operacion = new Operaciones();
      operacion.GenerarReporte(path);
      break;
    case "2":
      Console.WriteLine("Saliendo...");
      Environment.Exit(0);
      break;
    default:
      Console.WriteLine("Opción no válida.");
      break;
  }
} while (op != "2");


