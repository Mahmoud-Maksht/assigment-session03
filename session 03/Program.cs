namespace session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book();
            book.pages = 100;
            book.titel = "C# Programming";
            Console.WriteLine(book.pages);
            Console.WriteLine(book.titel);
            #endregion
        }
    }
}
