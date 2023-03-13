namespace Ejercicios_tema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void Ejercicio1()
        {
            Console.WriteLine("Introduzca un número.");

            int num = Convert.ToInt16(Console.ReadLine());

            if (num > 0) { Console.WriteLine("El número es positivo."); }
            else if (num == 0) { Console.WriteLine("El número es cero."); }
            else { Console.WriteLine("El número es negativo."); }
        }

        public static void Ejercicio2()
        {
            Console.WriteLine("Introduzca un número menor a 3.");

            int numeroWhile = Convert.ToInt16(Console.ReadLine());

            while (numeroWhile < 3)
            {
                Console.WriteLine(numeroWhile);
                numeroWhile++;
            }
        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Introduzca un número menor a 3.");

            int numeroWhile = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.Write(numeroWhile);
                numeroWhile++;
            }
            while (numeroWhile < 3);
        }

        public static void Ejercicio4()
        {
            int numeroFor = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(numeroFor);
                numeroFor++;
            }
        }

        public static void Ejercicio5()
        {
            Console.WriteLine("Ingrese una estación del año");

            string estacion = (Console.ReadLine()).ToLower();
            

            switch (estacion)
            {
                case "primavera":
                    Console.WriteLine("La estación es primavera");
                    break;

                case "verano":
                    Console.WriteLine("La estación es verano");
                    break;

                case "otoño":
                    Console.WriteLine("La estación es otoño");
                    break;

                case "invierno":
                    Console.WriteLine("La estación es invierno");
                    break;

                default: Console.WriteLine("ha habido un error");
                    break;
            }
        }
    }
}