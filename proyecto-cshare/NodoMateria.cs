class NodoMateria
{
    public Materia Data;
    public NodoMateria Siguiente;

    public NodoMateria(Materia data)
    {
        Data = data;
        Siguiente = null;
    }
}