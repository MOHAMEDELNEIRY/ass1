namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            Book b1 = new Book();
            b1.title = "book1";
            b1.pages = 300;
            object obj = b1;
            Console.WriteLine(obj);
            Console.WriteLine(((Book)obj).title);

            // 2
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Equals(b1));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());



            //int pages = "123"; error is in compile - time becouse the value type is String and "pages" data types is int
            // to solve this problem we can use parse method =>

            // 3
             int pages = int.Parse("464");
            Console.WriteLine(pages);



            //4
            try
            {
                int x = 10;
                int y = 0;
                int resultDiv = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
        }


            // 5
        int Pages = 300;
        double numberOfPages = Pages;
        Console.WriteLine(numberOfPages.GetType());



            //6
            double price = 49.99;
        int n = (int)price;
        Console.WriteLine(n.GetType());

            //7
            string pagesText = "464";
        int result = Convert.ToInt32(pagesText);
        Console.WriteLine(result);



            //8
            string yearText = "2023";
            int convyearText = int.Parse(yearText);
            Console.WriteLine(convyearText);


            string badText = "abc";
            bool resultOfBadText = int.TryParse(badText, out int number);





            //9
            if (resultOfBadText) { 
            
            Console.WriteLine(number);

            }
            else
            {
                Console.WriteLine("Invalid number");
            }


            int pages3 = 464;
            string conPages = pages3.ToString();
            Console.WriteLine(conPages);
            Console.WriteLine(conPages.GetType());



            //10
            int copies = 100;
            object v = copies;
            //Console.WriteLine(v.GetType());

            int newobg = (int)v;
            //Console.WriteLine(newobg.GetType());

        }
    }
}
