# Votaciones de la CONFECH

1. La CONFECH, en su afán de agilizar el proceso de recuento de las votaciones, le ha encargado el desarrollo de un programa de registro de votación por universidades.
   Primero, el programa debe solicitar al usuario ingresar la cantidad de universidades que participan en el proceso.
   Luego, para cada una de las universidades, el usuario debe ingresar el nombre de la universidad y los votos de sus alumnos, que pueden ser: aceptar (A), rechazar (R), nulo (N) o blanco (B). El término de la votación se indica ingresando una X, tras lo cual se debe mostrar los totales de votos de la universidad, con el formato que se muestra en el ejemplo.
   Finalmente, el programa debe mostrar el resultado de la votación, indicando la cantidad de universidades que aceptan, que rechazan y en las que hubo empate entre estas dos opciones.

   ```c#
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
   ```

# 