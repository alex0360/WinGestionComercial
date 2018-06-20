using System;
namespace LIB.Clases
{
    public class Usuario
    {
        LIB.StUsuario user = 
            new LIB.StUsuario();
        #region Get y Set
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public DateTime Edad { get; set; }
        public Boolean Genero { get; set; }
        public String[] Comentario { get; set; }
        public String Experiencia { get; set; }
        #endregion
        /// <summary>
        /// Guardar los Datos del Usuario en la Struct.
        /// </summary>
        public void Guardar()
        {
            user.Nombre = Nombre;
            user.Apellido = Apellido;
            user.Edad = Edad;

            // sexo
            if(Genero)
                user.Sexo = LIB.Genero.Hombre;
            else
                user.Sexo = LIB.Genero.Mujer;
            // Comentario
            if(Comentario != null)
                user.Comentario = Comentario;
            // Experiencia de Usuario
            if(Experiencia != null)
                user.Experiencia = Experiencia.ToString();
        }

        /// <summary>
        /// Cargar los Datos del Usuario del Struct.
        /// </summary>
        /// <returns>Mostrar Datos</returns>
        public string Cargar()
        {// Nota: esta Metodo sera el que Carge los Datos guardados  Anterios Mente
            String mString = "";

            mString += user.Nombre + "\n";
            mString += user.Apellido + "\n";
            // Valores No String
            mString += user.Edad.ToShortDateString() + "\n";
            mString += user.Sexo.ToString() + "\n";

            // Mostrar el Array de Comentarios
            // Solo si es diferente es null si no da error
            if(user.Comentario != null) {
                foreach(String com in user.Comentario)
                    mString += "  " + com + "\n";
            mString += user.Experiencia.ToString();
            }
            return mString;
        }
    }
}
