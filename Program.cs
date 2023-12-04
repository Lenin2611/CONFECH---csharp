internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Numero de universidades: ");
        int numero = int.Parse(Console.ReadLine());
        int uniAceptan = 0;
        int uniRechazan = 0;
        int uniEmpate = 0;
        for (int i = 0; i < numero; i++)
        {
            bool loop = true;
            int aceptan = 0;
            int rechazan = 0;
            int blancos = 0;
            int nulos = 0;
            Console.Write("\nUniversidad: ");
            string universidad = Console.ReadLine();
            while (loop)
            {
                Console.Write("Voto: ");
                string opcion = Console.ReadLine().ToLower();
                if (opcion == "a")
                {
                    aceptan += 1;
                }
                else if (opcion == "r")
                {
                    rechazan += 1;
                }
                else if (opcion == "b")
                {
                    blancos += 1;
                }
                else if (opcion == "x")
                {
                    loop = false;
                }
                else
                {
                    nulos += 1;
                }
            }
            Console.WriteLine($"{universidad}: {aceptan} aceptan, {rechazan} rechazan, {blancos} blancos, {nulos} nulos.");
            if (aceptan > rechazan)
            {
                uniAceptan += 1;
            }
            else if (aceptan < rechazan)
            {
                uniRechazan += 1;
            }
            else
            {
                uniEmpate += 1;
            }
        }
        Console.WriteLine($"\nUniversidades que aceptan: {uniAceptan} \nUniversidades que rechazan: {uniRechazan} \nUniversidades con empate: {uniEmpate}");
    }
}