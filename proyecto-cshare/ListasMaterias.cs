class ListaMaterias
{
    private NodoMateria cabeza;

    public void Agregar(Materia m)
    {
        if (Existe(m.Nombre))
        {
            Console.WriteLine("La materia ya existe.");
            return;
        }

        NodoMateria nuevo = new NodoMateria(m);

        if (cabeza == null)
            cabeza = nuevo;
        else
        {
            NodoMateria actual = cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;

            actual.Siguiente = nuevo;
        }
    }

    public bool Existe(string nombre)
    {
        NodoMateria actual = cabeza;

        while (actual != null)
        {
            if (actual.Data.Nombre == nombre)
                return true;

            actual = actual.Siguiente;
        }

        return false;
    }

    public void Listar()
{
    NodoMateria actual = cabeza;

    while (actual != null)
    {
        Console.WriteLine($"{actual.Data.Nombre} - {actual.Data.Nota}");
        actual = actual.Siguiente;
    }
}

public void Editar(string nombre, double nuevaNota)
{
    NodoMateria actual = cabeza;

    while (actual != null)
    {
        if (actual.Data.Nombre == nombre)
        {
            actual.Data.Nota = nuevaNota;
            return;
        }

        actual = actual.Siguiente;
    }
}

public void Eliminar(string nombre)
{
    NodoMateria actual = cabeza;
    NodoMateria anterior = null;

    while (actual != null)
    {
        if (actual.Data.Nombre == nombre)
        {
            if (anterior == null)
                cabeza = actual.Siguiente;
            else
                anterior.Siguiente = actual.Siguiente;

            return;
        }

        anterior = actual;
        actual = actual.Siguiente;
    }
}
}