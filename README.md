# Procesador de Transacciones - Consola C#

## Introducción

Este proyecto consiste en una aplicación de consola en C# que procesa un archivo CSV de transacciones financieras. El objetivo es generar un reporte con la suma de créditos y débitos, balance final, transacción de mayor monto y conteo por tipo.

## Instrucciones de Ejecución

1. Clona el repositorio o copia el código en tu entorno local.
2. Asegúrate de tener .NET SDK 8+ instalado.
3. Coloca un archivo `transaccion.csv` en la misma ruta del proyecto.
4. Ejecuta la aplicación desde terminal con:

```bash
dotnet run
```

## Solucion

- Se utiliza una clase Transaccion para mapear cada fila del CSV.

- La clase Operaciones centraliza toda la lógica: lectura de CSV, sumatorias por tipo, balance final, mayor transacción y conteo.

- Se aplica LINQ (OrderByDescending, Count) para operaciones de búsqueda y conteo eficientes.

- Comparaciones de tipo son case-insensitive (StringComparison.OrdinalIgnoreCase).

## Estructura

/retotecnico-cobol
│
├── Program.cs  
├── Operaciones.cs  
├── Transaccion.cs  
├── transaccion.csv  
└── README.md

## Resultados

### Entrada de datos

- Entrada de Datos:
La aplicación deberá leer un archivo CSV. Como ejemplo, el contenido del archivo puede ser:

id,tipo,monto
1,Crédito,100.00
2,Débito,50.00
3,Crédito,200.00
4,Débito,75.00
5,Crédito,150.00

### Resultado esperado

Salida del Programa:
La aplicación debe mostrar el reporte final en la terminal.
Ejemplo de salida en la terminal:
Reporte de Transacciones

---

Balance Final: 325.00
Transacción de Mayor Monto: ID 3 - 200.00
Conteo de Transacciones: Crédito: 3 Débito: 2
