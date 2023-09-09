using suite.Estudiante;
using System.Text.Json;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        byte cuantos = ConvertirEntradaNumerica<byte>("Cuantos estudiantes va a registrar: ");
        if (cuantos < 1)
        {
            Console.Clear();
            Console.WriteLine("No se ingresaron estudiantes. Se cerrara el progrma");
            Console.Write("Presione cualquier tecla para cerrar el programa.");
            Console.ReadKey();
            return;
        }
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
        Random rnd = new Random();
        for (int i = 0; i < cuantos; i++)
        {
            Estudiante estudiante = new Estudiante();
            // Codigo
            estudiante.Codigo = Convert.ToString(rnd.Next(10000, 99999));

            // Nombre
            Console.Write("Ingrese el nombre del estudiante: ");
            estudiante.Nombre = Console.ReadLine();

            // Email
            Console.Write("Ingrese el email del estudiante: ");
            estudiante.Email = Console.ReadLine();

            // Edad
            estudiante.Edad = ConvertirEntradaNumerica<byte>("Ingrese la edad del estudiante: ");

            // Direccion
            Console.Write("Ingrese la direccion del estudiante: ");
            estudiante.Direccion = Console.ReadLine();

            // Añadir a la lista
            listaEstudiantes.Add(estudiante);
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            estudiante.Quices = new List<float?>() { null, null, null, null };
            estudiante.Trabajos = new List<float?>() { null, null };
            estudiante.Parciales = new List<float?>() { null, null, null };

        }
        bool menuCiclo = true;
        while (menuCiclo)
        {
            Console.Clear();
            Console.WriteLine("1. Ver estudiantes registrados");
            Console.WriteLine("2. Cambiar notas de estudiante");
            Console.WriteLine("3. Ver notas finales estudiantes");
            Console.WriteLine("\n0. Salir del programa");
            byte opcionMenu = ConvertirEntradaNumerica<byte>("Opcion: ");
            switch (opcionMenu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6}", "Codigo Estudiante", "Nombre", "Q1", "Q2", "Q3", "T1", "T2", "P1", "P2", "P3");
                    for (int i = 0; i < listaEstudiantes.Count; i++)
                    {
                        Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6}", listaEstudiantes[i].Codigo, listaEstudiantes[i].Nombre, listaEstudiantes[i].Quices[0], listaEstudiantes[i].Quices[1], listaEstudiantes[i].Quices[2], listaEstudiantes[i].Trabajos[0], listaEstudiantes[i].Trabajos[1], listaEstudiantes[i].Parciales[0], listaEstudiantes[i].Parciales[1], listaEstudiantes[i].Parciales[2]);
                    }
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6}", "Codigo Estudiante", "Nombre", "Q1", "Q2", "Q3", "T1", "T2", "P1", "P2", "P3");
                    for (int i = 0; i < listaEstudiantes.Count; i++)
                    {
                        Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6}", listaEstudiantes[i].Codigo, listaEstudiantes[i].Nombre, listaEstudiantes[i].Quices[0], listaEstudiantes[i].Quices[1], listaEstudiantes[i].Quices[2], listaEstudiantes[i].Trabajos[0], listaEstudiantes[i].Trabajos[1], listaEstudiantes[i].Parciales[0], listaEstudiantes[i].Parciales[1], listaEstudiantes[i].Parciales[2]);
                    }
                    Console.Write("Codigo del estudiante: ");
                    string codigoEstudiante = Console.ReadLine();
                    Console.Clear();
                    for (sbyte i = 0; i < listaEstudiantes.Count; i++)
                    {
                        if (listaEstudiantes[i].Codigo.Equals(codigoEstudiante))
                        {
                            Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6}", "Codigo Estudiante", "Nombre", "Q1", "Q2", "Q3", "T1", "T2", "P1", "P2", "P3");
                            Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6} {6,6} {7,6} {8,6} {9,6}", listaEstudiantes[i].Codigo, listaEstudiantes[i].Nombre, listaEstudiantes[i].Quices[0], listaEstudiantes[i].Quices[1], listaEstudiantes[i].Quices[2], listaEstudiantes[i].Trabajos[0], listaEstudiantes[i].Trabajos[1], listaEstudiantes[i].Parciales[0], listaEstudiantes[i].Parciales[1], listaEstudiantes[i].Parciales[2]);
                            Console.WriteLine("1. Ingresar valores quizes");
                            Console.WriteLine("2. Ingresar valores trabajos");
                            Console.WriteLine("3. Ingresar valores parciales");
                            byte opcionN = ConvertirEntradaNumerica<byte>("Opcion: ");
                            switch (opcionN)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine($"Quizes Estudiante {listaEstudiantes[i].Codigo}\n");
                                    for (sbyte q = 0; q < 4; q++)
                                    {
                                        if (listaEstudiantes[i].Quices[q] == null)
                                        {
                                            Console.WriteLine($"Quiz {q + 1} : No asignada");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Quiz {q + 1} : {listaEstudiantes[i].Quices[q]}");
                                        }
                                    }
                                    Console.WriteLine("\n1. Quiz 1");
                                    Console.WriteLine("2. Quiz 2");
                                    Console.WriteLine("3. Quiz 3");
                                    Console.WriteLine("4. Quiz 4");
                                    sbyte quiz = ConvertirEntradaNumerica<sbyte>("Opcion: ");
                                    Console.Clear();
                                    if (quiz > 0 && quiz < 5)
                                    {
                                        Console.WriteLine($"Estudiante codigo {listaEstudiantes[i].Codigo}");
                                        if (listaEstudiantes[i].Quices[quiz - 1] == null){
                                            Console.WriteLine($"Nota Actual Parcial {quiz}: No asignada");
                                        }
                                        else{Console.WriteLine($"Nota Actual Trabajo {quiz}: {listaEstudiantes[i].Quices[quiz - 1]}");}
                                        double nuevaNotaQuiz = Math.Round(ConvertirEntradaNumerica<float>($"Nueva nota para Quiz {quiz}: "), 1);
                                        listaEstudiantes[i].Quices[quiz - 1] = (float)nuevaNotaQuiz;
                                        break;
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine($"Trabajo Estudiante {listaEstudiantes[i].Codigo}");
                                    for (sbyte t = 0; t < 2; t++)
                                    {
                                        if (listaEstudiantes[i].Trabajos[t] == null)
                                        {
                                            Console.WriteLine($"Trabajo {t + 1} : No asignada");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Trabajo {t + 1} : {listaEstudiantes[i].Trabajos[t]}");
                                        }
                                    }
                                    Console.Clear();
                                    Console.WriteLine("1. Trabajo 1");
                                    Console.WriteLine("2. Trabajo 2");
                                    sbyte trabajo = ConvertirEntradaNumerica<sbyte>("Opcion: ");
                                    Console.Clear();
                                    if (trabajo > 0 && trabajo < 3)
                                    {
                                        Console.WriteLine($"Estudiante codigo {listaEstudiantes[i].Codigo}");
                                        if (listaEstudiantes[i].Trabajos[trabajo - 1] == null){
                                            Console.WriteLine($"Nota Actual Parcial {trabajo}: No asignada");
                                        }
                                        else{Console.WriteLine($"Nota Actual Trabajo {trabajo}: {listaEstudiantes[i].Trabajos[trabajo - 1]}");}
                                        double nuevaNotaTrabajo = Math.Round(ConvertirEntradaNumerica<float>($"Nueva nota para Trabajo {trabajo}: "), 1);
                                        listaEstudiantes[i].Trabajos[trabajo - 1] = (float)nuevaNotaTrabajo;
                                        
                                        break;
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine($"Parciales Estudiante {listaEstudiantes[i].Codigo}");
                                    for (sbyte p = 0; p < 3; p++)
                                    {
                                        if (listaEstudiantes[i].Parciales[p] == null)
                                        {
                                            Console.WriteLine($"Parcial {p + 1} : No asignada");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Parcial {p + 1} : {listaEstudiantes[i].Parciales[p]}");
                                        }
                                    }
                                    Console.WriteLine("1. Parcial 1");
                                    Console.WriteLine("2. Parcial 2");
                                    Console.WriteLine("3. Parcial 3");
                                    sbyte parcial = ConvertirEntradaNumerica<sbyte>("Opcion: ");
                                    Console.Clear();
                                    if (parcial > 0 && parcial < 4)
                                    {
                                        Console.WriteLine($"Estudiante codigo {listaEstudiantes[i].Codigo}");
                                        if (listaEstudiantes[i].Parciales[parcial - 1] == null){
                                            Console.WriteLine($"Nota Actual Parcial {parcial}: No asignada");
                                        }
                                        else {Console.WriteLine($"Nota Actual Parcial {parcial}: {listaEstudiantes[i].Parciales[parcial - 1]}");}
                                        double nuevaNotaParcial = Math.Round(ConvertirEntradaNumerica<float>($"Nueva nota para Parcial {parcial}: "), 1);
                                        listaEstudiantes[i].Parciales[parcial - 1] = (float)nuevaNotaParcial;
                                        break;
                                    }
                                    break;
                                default:
                                    Console.Clear();
                                    Console.Write("No se ingreso un valor valido...");
                                    Console.ReadLine();
                                    break;
                            }
                        }
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("{0,17} {1,-40} {2,6} {3,6} {4,6} {5,6}", "Codigo Estudiante", "Nombre", "DQ", "DT", "DP", "NF");
                    for (int i = 0; i < listaEstudiantes.Count; i++)
                    {
                        float? definitivaQuices = 0;
                        float? definitivaTrabajos = 0;
                        float? definitivaParciales = 0;
                        for (byte q = 0; q < listaEstudiantes.Count; q++)
                        {
                            foreach (float? nota in listaEstudiantes[q].Quices)
                            {
                                if (nota != null)
                                {
                                    definitivaQuices += nota / 4;
                                }
                            }
                        }
                        for (byte t = 0; t < listaEstudiantes.Count; t++)
                        {
                            foreach (float? nota in listaEstudiantes[t].Trabajos)
                            {
                                if (nota != null)
                                {
                                    definitivaTrabajos += nota / 2;
                                }
                            }
                        }
                        for (byte p = 0; p < listaEstudiantes.Count; p++)
                        {
                            foreach (float? nota in listaEstudiantes[p].Parciales)
                            {
                                if (nota != null)
                                {
                                    definitivaParciales += nota / 3;
                                }
                            }
                        }
                        definitivaQuices = (float)Math.Round((decimal)definitivaQuices, 1);
                        definitivaTrabajos = (float)Math.Round((decimal)definitivaTrabajos, 1);
                        definitivaParciales = (float)Math.Round((decimal)definitivaParciales, 1);
                        double? notaFinal = Math.Round(((definitivaQuices * 0.25) + (definitivaTrabajos * 0.15) + (definitivaParciales * 0.6)).Value, 1);
                        Console.WriteLine("{0,-17} {1,-40} {2,6} {3,6} {4,6} {5,6}",listaEstudiantes[i].Codigo, listaEstudiantes[i].Nombre, definitivaQuices, definitivaTrabajos, definitivaParciales, notaFinal);
                    }

                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 0:
                    menuCiclo = false;
                    break;
            }
        }
    }
    // Funcion, metodo? Que permite tomar un string y transformarlo al tipo de dato que se requiera, manejando las excepciones automaticamente. Todo gracias a la posibilidad de usar T como tipo de dato adaptable.
    public static T ConvertirEntradaNumerica<T>(string mensaje)
    {
    while (true)
    {
        try
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            return (T)Convert.ChangeType(entrada, typeof(T), CultureInfo.InvariantCulture); // Culture info permite el reconocer correctamnente cuando se ingresa un decimal por string, creo.
        }
        catch (FormatException)
        {
            Console.WriteLine("La entrada no es un número válido.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        catch (OverflowException)
        {
            Console.WriteLine("El valor ingresado está fuera del rango válido.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Se produjo un error inesperado: {e.Message}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
    }
}