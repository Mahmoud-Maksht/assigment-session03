namespace session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Q2
            Book book = new Book();
            book.titel = "Dream";
            book.pages = 50;
            Book book2 = book;
            book2.titel = "Future";
            book2.pages = 54;
            Console.WriteLine(book.ToString());  //convert from int to string
            Console.WriteLine(book.GetHashCode());  //return hash code that represents the object
            Console.WriteLine(book2.GetHashCode());  //return hash code that represents the object
            Console.WriteLine(book.Equals(book2));  //compare between two values
            Console.WriteLine(book.GetType().Name);  //return the name of object
            #endregion

            #region Q3
             int pages = "646"     //compile error
            #endregion
            #region Q4
            try  //handles exception
            {
              int num = 10;
                Console.WriteLine(num / 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot divid by zero");
            }
            finally
            {
                Console.WriteLine("done");
            }
            #endregion
            #region Q5
            int pages = 300;
            double webpages = pages;  //implicit casting
            Console.WriteLine(webpages);
            #endregion
            */
            #region Q6
            double prise = 49.49;
            int realprice = (int)prise;  //explicit casting
            Console.WriteLine(realprice);
            #endregion

        }
    }
}
