namespace EstudiantesCRUD.Models;

public partial class Estudiante
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Matricula { get; set; } = null!;

    public string Carrera { get; set; } = null!;

    public string Cuatrimestre { get; set; } = null!;

    public string Asignatura { get; set; } = null!;

    public decimal? Nota { get; set; }
}
