# Reto Técnico: Procesamiento de Transacciones Bancarias (CLI)

## Objetivo:
Desarrolla una aplicación de línea de comandos (CLI) que procese un archivo CSV con transacciones bancarias y genere un reporte que incluya:

### Balance Final:
- Suma de los montos de las transacciones de tipo **"Crédito"** menos la suma de los montos de las transacciones de tipo **"Débito"**.

### Transacción de Mayor Monto:
- Identificar el **ID** y el **monto** de la transacción con el valor más alto.

### Conteo de Transacciones:
- Número total de transacciones para cada tipo (**"Crédito"** y **"Débito"**).

## Instrucciones

### Repositorio Base:
Clona o haz un fork del repositorio base disponible en:  
[Repositorio en GitHub](https://github.com/tu-usuario/retotecnico-cobol)

### Entrada de Datos:
La aplicación deberá leer un archivo **CSV**. Como ejemplo, el contenido del archivo puede ser:

```
id,tipo,monto
1,Crédito,100.00
2,Débito,50.00
3,Crédito,200.00
4,Débito,75.00
5,Crédito,150.00
```

### Salida del Programa:
La aplicación debe mostrar el reporte final en la terminal.

#### Ejemplo de salida en la terminal:

```
Reporte de Transacciones
---------------------------------------------
Balance Final: 325.00
Transacción de Mayor Monto: ID 3 - 200.00
Conteo de Transacciones: Crédito: 3 Débito: 2
```

## Lenguaje de Programación:
Utiliza el lenguaje de programación de tu preferencia. Algunas opciones recomendadas son:
- Python
- Java
- C#
- JavaScript (Node.js)

## README del Proyecto:
Incluye un archivo **README.md** en el proyecto con la siguiente estructura:

### Introducción:
- Breve descripción del reto y su propósito.

### Instrucciones de Ejecución:
- Detalla cómo instalar dependencias (si las hay) y cómo ejecutar la aplicación.

### Enfoque y Solución:
- Explica de forma concisa la lógica implementada y las decisiones de diseño que tomaste.

### Estructura del Proyecto:
- Describe los archivos y carpetas principales que componen tu solución.

### Documentación y Calidad del Código:
- Asegúrate de que tu código esté bien documentado y sea fácil de leer.
- Explica, mediante comentarios, los pasos clave y la lógica utilizada para resolver el problema.

