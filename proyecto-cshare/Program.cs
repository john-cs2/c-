class Program
{
    static ListaEstudiantes lista = new ListaEstudiantes();
    static int contador = 1;

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n1. Agregar");
            Console.WriteLine("2. Listar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Materias");
            Console.WriteLine("6. Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Agregar(); break;
                case 2: lista.Listar(); break;
                case 3: Buscar(); break;
                case 4: Eliminar(); break;
                case 5: GestionMaterias(); break;
            }

        } while (opcion != 6);
    }

    static void Agregar()
    {
        Estudiante e = new Estudiante();

        e.Codigo = contador++;
        Console.Write("Nombre: ");
        e.Nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        e.Apellido = Console.ReadLine();

        lista.Agregar(e);
    }

    static void Buscar()
    {
        Console.Write("Código: ");
        int cod = int.Parse(Console.ReadLine());

        var nodo = lista.Buscar(cod);

        if (nodo != null)
            nodo.Data.Mostrar();
        else
            Console.WriteLine("No encontrado");
    }

    static void Eliminar()
    {
        Console.Write("Código: ");
        int cod = int.Parse(Console.ReadLine());

        lista.Eliminar(cod);
    }

    static void GestionMaterias()
{
    Console.Write("Código estudiante: ");
    int cod = int.Parse(Console.ReadLine());

    var nodo = lista.Buscar(cod);

    if (nodo == null)
    {
        Console.WriteLine("No existe.");
        return;
    }

    int op;
    do
    {
        Console.WriteLine("\n1. Agregar materia");
        Console.WriteLine("2. Listar");
        Console.WriteLine("3. Editar nota");
        Console.WriteLine("4. Eliminar");
        Console.WriteLine("5. Volver");

        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Materia m = new Materia();
                Console.Write("Nombre: ");
                m.Nombre = Console.ReadLine();
                Console.Write("Nota: ");
                m.Nota = double.Parse(Console.ReadLine());
                nodo.Data.Materias.Agregar(m);
                break;

            case 2:
                nodo.Data.Materias.Listar();
                break;

            case 3:
                Console.Write("Materia: ");
                string nom = Console.ReadLine();
                Console.Write("Nueva nota: ");
                double nota = double.Parse(Console.ReadLine());
                nodo.Data.Materias.Editar(nom, nota);
                break;

            case 4:
                Console.Write("Materia: ");
                nodo.Data.Materias.Eliminar(Console.ReadLine());
                break;
        }

    } while (op != 5);
}
}