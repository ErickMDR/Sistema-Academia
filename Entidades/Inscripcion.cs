namespace Sistema_Academia.Entidades
{
    public class Inscripcion
    {
        public int PersonaId { get; set; }
        public int CursoId { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materia { get; set; }
        public string Seccion { get; set; }
    }
}