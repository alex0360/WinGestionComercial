namespace LIB.Clases
{
    public static class Show
    {
        public static void ShowObject(object objeto)
        {
            System.Windows.Forms.MessageBox.Show(objeto.ToString());

            System.Console.Write(objeto.ToString());
            System.Console.Read();
        }
    }
}
