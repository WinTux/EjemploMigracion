using System;

namespace EjemploMigracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PAso 1: Agregar paquete NuGet: Microsoft.EntityFrameworkCore.SqlServer
            //Paso 2: Crear folder Modelos y crear las clases Empleado, Producto.
            //Paso 3: Crear la clase de contexto.
            //Paso 4: Abrir consola: Herramientas > Admin de paquetes NuGet > Consola...
            //Paso 5: Agregar paquete NuGet: Microsoft.EntityFrameworkCore.Tools

            /*
             Ejecutamos:
            PM> add-migration "inicial"

            PM> update-database

            si hemos creado otra migración:
            PM> add-migration "version1"

            podemos eliminarla con
            PM> remove-migration

            pero si, tras crear la migración, ya ejecutamos update-database, entonces 
            no podremos removerla hasta retroceder a otra migración anterior como
            cambiarnos a:
            PM> update-database "inicial"
            PM> remove-migration

            Finalmente, podemos generar scripts de migración para ejecutarlos directamente
            en el servidor de DDBB:
            PM> script-migration

             */
        }
    }
}
