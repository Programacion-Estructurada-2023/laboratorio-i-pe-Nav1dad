using System;
using System.Data.Common;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            // PARTE 1
            // DECLARACION DE VARIABLES DE TIPO TEXTO, CAPTURANDO SU VALOR DESDE CONSOLA

            string? Despartamento;
            string? Municipio;
            string? Ciudad;

            // DECLARACION DE DOS VARIABLES DE TEXTO, ASIGNANDO SU VALOR DESDE LA DECLARACION

            string? ColoniaDondeVive = "La Perla";
            string? ColorDeCasa = "Verde";

            int AñosDeVivirEnSuResidenciaActual;
            int EdadActual;

            // DECLARA DOS VARIABLES DE TIPO DATE TIME, ASGINANDO SU VALOR DESDE LA DECLARACION

            DateTime FechaDenacimiento = new DateTime(2002, 8, 30, 4, 30, 00);
            DateTime FechaActual = DateTime.Now;

            // IMPRESION DE DATOS DESDE LA TERMINAL
            // VARIABLES DE TIPO TEXTO

            
            Console.WriteLine("<<<<<<<<<< INICIO DE INGRESO DE VARIABLES TIPO TEXTO >>>>>>>>>>\n");
            Console.WriteLine("Ingrese su departamento");
            Despartamento = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su municipio");
            Municipio = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su ciudad");
            Ciudad = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<< FINAL DE INGRESO DE VARIABLES DE TIPO TEXTO >>>>>>>>>>\n");
            Console.WriteLine();

            // IMPRESION DE DATOS DESDE LA TERMINAL
            // VARIABLES DE TIPO ENTERA


            Console.WriteLine("<<<<<<<<<< INICIO DE INGRESO DE VARIABLES TIPO ENTERO >>>>>>>>>>\n");
            Console.WriteLine("Ingrese los años de vivir en su residencia actual");
            AñosDeVivirEnSuResidenciaActual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad actual");
            EdadActual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<< FINAL DE INGRESO DE VARIABLES TIPO ENTERO >>>>>>>>>>\n");
            Console.WriteLine();


            // PARTE II RELIZAR EL PROCESO DE ASGINACION DE FUNCIONES
            // VARIABLES DE TIPO TEXTO DECLARADAS REALIZAR LA APLICACION DE LAS SIGUIENTES FUNCIONES

            // APLICACION FUNCION PARA COMPARAR CADENAS

            bool comparar = Despartamento == Municipio;

            // APLICAR FUNCION PARA CONCATENAR TEXTO

            string? concatenar = Municipio + "  " + Ciudad;

            //APLICAR FUNCION MAYUSCULA

            string? mayuscula = Municipio.ToUpper();

            //APLICAR FUNCION DE LIMPIADO DE CADENA

            string? prueba = "      Mi nombre es Pedro";
            string? sinespacio = prueba.Trim();

            // APLICAR FUNCION DE LONGITUD DE CADENA, AL MENOS A DOS VARIABLES

            int logitudCadena1 = Municipio.Length;
            int logitudCadena2 = Ciudad.Length;


            // VARIABLES DE TIPO TEXTO DECLARADAS REALIZAR LA APLICACION DE LAS SIGUIENTES FUNCIONES

            // APLICAR FUNCION DE FORMATEO DE FECHA MOSTRARLA DIA/MES/AÑO

            string? fechaformateada = FechaDenacimiento.ToString("dd/MM/yyyy");

            //ADICIONAR 2 SEMANAS A CADA FECHA INGRESADA

            DateTime sumaDosSemanas = FechaDenacimiento.AddDays(14);
            DateTime suma2Semanas = FechaActual.AddDays(14);

            // COMPARAR LAS FECHAS, FECHA1 MAYOR A FECHA2 Y FECHA1 MENOR A FECHA2

            
            bool fecha1 = FechaDenacimiento > FechaActual;
            bool fecha2 = FechaDenacimiento < FechaActual;


            // PARTE III IMPRESION DE VALORES EN CONSOLA

            // IMPRIMIR LOS VALORES INGRESADOS EN LAS VARIABLES DE TEXTO

            Console.WriteLine("<<<<<<<<<< INICIO DE VARIABLES DE TIPO TEXTO >>>>>>>>>>\n");
            Console.WriteLine("Su departamento es: " + Despartamento);
            Console.WriteLine();
            Console.WriteLine("Su municipio es: " +  Municipio);
            Console.WriteLine();
            Console.WriteLine("Su ciudad es: " + Ciudad);
            Console.WriteLine();
            Console.WriteLine("La colonia donde vive es: " + ColoniaDondeVive);
            Console.WriteLine();
            Console.WriteLine("El color de su casa es: " + ColorDeCasa);
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<< FIN DE VARIABLES DE TIPO TEXTO >>>>>>>>>>\n");
            Console.WriteLine();


            // IMPRIMIR LOS VALORES DE LAS VARIABLES ENTERAS

            Console.WriteLine("<<<<<<<<<< INICO DE VARIABLES ENTERAS >>>>>>>>>>\n");
            Console.WriteLine("Los años de vivir en su recidencia actual son: " + AñosDeVivirEnSuResidenciaActual + " años");
            Console.WriteLine();
            Console.WriteLine("Su edad actual es: " + EdadActual + " años");
            Console.WriteLine();
            Console.WriteLine("Su feche de nacimiento es: " +  FechaDenacimiento);
            Console.WriteLine();
            Console.WriteLine("La fecha actual es: "  + FechaActual);
            Console.WriteLine("\n<<<<<<<<<< FINAL DE VARIABLES TIPO ENTERAS >>>>>>>>>>\n");
            Console.WriteLine();


            // IMPRIMIR EN CONSOLA LOS VALORES INTEGRADOS EN LAS COMPARACIONES DE CADENAS

            Console.WriteLine("<<<<<<<<<< INICO DE VALORES INTEGRADOS EN LAS CADENAS >>>>>>>>>>\n");
            Console.WriteLine("Comparacion: " + comparar);
            Console.WriteLine();
            Console.WriteLine("Mayuscula municipio: " + mayuscula);
            Console.WriteLine();
            Console.WriteLine("Limpiado de cadena: " + sinespacio);
            Console.WriteLine();
            Console.WriteLine("La longitud de cadena de municipio es: " + logitudCadena1);
            Console.WriteLine();
            Console.WriteLine("La longitud de cadena de ciudad es: " + logitudCadena2);
            Console.WriteLine("\n<<<<<<<<<< FINAL DE VALORES INTEGRADOS EN LAS CADENAS >>>>>>>>>>\n");
            Console.WriteLine();


            // IMPRIMIR EN CONSOLA LOS VALORES OBTENIDOS DE LAS FUNCIONES DE FECHA

            Console.WriteLine("<<<<<<<<<< INICIO DE VALORES OBTENIDOS EN LAS FUNCIONES DE FECHA >>>>>>>>>>\n");
            Console.WriteLine("La fecha formateada es: " + fechaformateada);
            Console.WriteLine();
            Console.WriteLine("Se suman dos semanas a fecha de nacimiento: " + sumaDosSemanas);
            Console.WriteLine();
            Console.WriteLine("Se suman 14 dias a la fecha actual: " + suma2Semanas);
            Console.WriteLine();
            Console.WriteLine("la fecha1 es mayor a la fecha2?: " + fecha1);
            Console.WriteLine();
            Console.WriteLine("La fecha1 es menor a la fecha2?: " + fecha2);
            Console.WriteLine("\n<<<<<<<<<< FINAL DE VALORES OBTENIDOS EN LAS FUNCIONES DE FECHA >>>>>>>>>>\n");

            // NOMBRE: PEDRO ANTONIO ALVAREZ HERNANDEZ
            // CODIGO U20230697
            // AUTOEVALUACION 10

        

            
        }
    }
}