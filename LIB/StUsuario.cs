namespace LIB
{
    public enum Genero
    {
        Hombre,
        Mujer
    }
        
    public struct StUsuario
    {
        public string Nombre;
        public string Apellido;
        public System.DateTime Edad;
        public Genero Sexo;
        public string[] Comentario;
        public string Experiencia;
    }
}