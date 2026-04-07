class ListaEstudiantes
{
    private NodoEstudiante cabeza;

    public void Agregar(Estudiante e)
    {
        NodoEstudiante nuevo = new NodoEstudiante(e);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            NodoEstudiante actual = cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;

            actual.Siguiente = nuevo;
        }
    }

    public NodoEstudiante Buscar(int codigo)
    {
        NodoEstudiante actual = cabeza;

        while (actual != null)
        {
            if (actual.Data.Codigo == codigo)
                return actual;

            actual = actual.Siguiente;
        }

        return null;
    }

    public void Listar()
    {
        NodoEstudiante actual = cabeza;

        while (actual != null)
        {
            actual.Data.Mostrar();
            actual = actual.Siguiente;
        }
    }

    public void Eliminar(int codigo)
{
    NodoEstudiante actual = cabeza;
    NodoEstudiante anterior = null;

    while (actual != null)
    {
        if (actual.Data.Codigo == codigo)
        {
            if (anterior == null)
                cabeza = actual.Siguiente;
            else
                anterior.Siguiente = actual.Siguiente;

            Console.WriteLine("Eliminado.");
            return;
        }

        anterior = actual;
        actual = actual.Siguiente;
    }

    Console.WriteLine("No encontrado.");
}
}
