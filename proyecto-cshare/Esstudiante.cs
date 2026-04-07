class Estudiante
{
    public int Codigo;
    public string Nombre;
    public string Apellido;
    public string Direccion;
    public string Celular;
    public string Email;

    public ListaMaterias Materias = new ListaMaterias();

    public void Mostrar()
    {
        Console.WriteLine($"{Codigo} - {Nombre} {Apellido}");
    }
}

