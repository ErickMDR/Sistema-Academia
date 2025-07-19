namespace Sistema_Academia.Entidades
{
    public class Nota
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }
        public decimal Valor { get; set; }
        // Puedes agregar campos como fecha, observaciones, etc.
    }
}