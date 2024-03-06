namespace ejercicio9Repaso
{
    class program
    {
        public static void Main(String[] args)
        {
            DateTime fecha = DateTime.Today;
            string fichero = $"C:\\Users\\profesor\\Desktop\\formato\\{fecha.ToString("ddMMyyyy")}.txt";

            Console.WriteLine("Dame una frase y le intercambiamos las volcales por *");
            string frase = Console.ReadLine();

            //Separacion
            Console.WriteLine();

            //1º metodo
           string reemplazo=  cambiarCaracteres(frase);

            //Separacion
            Console.WriteLine();

            //2º , 3º y 4º metodo
            escribirFichero(reemplazo, fichero);

            //5º metodo

           /*Console.WriteLine("¿Cuantas vocales faltan?");
            int num = Int32.Parse(Console.ReadLine());
            if (num == reemplazo.) { }*/




        }



        static string cambiarCaracteres(string texto)
        {
           
            Console.WriteLine("Su oracion es: \n" + texto);

            string remplazado = texto.Replace('a', '*').Replace('e', '*').Replace('i', '*').Replace('o', '*').Replace('u', '*').Replace('A', '*').Replace('E', '*').Replace('I', '*').Replace('O', '*').Replace('U', '*');

            Console.WriteLine("El texto modificado se trata de: " + remplazado);
            return remplazado;
        }

        static void escribirFichero(string reemplazo, string fichero)
        {
            string[] trozos = reemplazo.Split(" ");

            using (StreamWriter sw = new StreamWriter(fichero))
            {
                foreach (string trozo in trozos)
                {
                    sw.WriteLine(trozo);
                }
               
            }

            string frase;
            using(StreamReader sr = new StreamReader(fichero))
            {
                int count = 1;
                frase = sr.ReadLine();
                while(frase!=null)
                {
                    
                    if (count == frase.Length | count == frase.Length - 1)
                    {
                        Console.WriteLine("La palabra se trata de:" + frase);
                    }
                    count++;
                }
               
            }

           


        }
    }
}
