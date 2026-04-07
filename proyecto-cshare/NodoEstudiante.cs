class NodoEstudiante
{
    public Estudiante Data;
    public NodoEstudiante Siguiente;

    public NodoEstudiante(Estudiante data)
    {
        Data = data;
        Siguiente = null;
    }
}