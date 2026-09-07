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
            #region Q6
            double prise = 49.49;
            int realprice = (int)prise;  //explicit casting
            Console.WriteLine(realprice);
            #endregion
            #region Q7
            string pagestext = "464";
            int numpagestext = Convert.ToInt32(pagestext);  //convert from string to int
            Console.WriteLine(numpagestext);
            #endregion
            #region Q8
            string yeartext = "2023";
            int text = int.Parse( yeartext );  //convert from string to int
            Console.WriteLine(text);
            string badtext = "abc";
            if (int.TryParse(badtext, out int number))  //convert from string to int safely
            { 
            Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("invalid number");
            }
            #endregion
            #region Q9
            int pages = 898;
            string pagestext = pages.ToString();  //convert from int to string
            Console.WriteLine(pagestext);
            Console.WriteLine(pagestext.GetType().Name);  // return name of data type
            #endregion
            */
            #region Q10
            int copies = 5;
            object obj = copies;  //boxing
            Console.WriteLine(obj);
            int files = (int)obj;  //unboxing
            Console.WriteLine(files);
            #endregion

        }
    }
}
