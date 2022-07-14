using System.Text;

namespace ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {

            Book book1 = new Book("Harry Potter", "JKRowling",400);
            Book book2 = new Book("Lord Angga", "Tolkeir", 700);

            // G, PG, PG-13, R, NR
            book1.Title = "Rich Dad Poor Dad";
            Console.WriteLine(book1.Title);

            book2.Title = "G";
            Console.WriteLine(book2.Title);

            Console.ReadLine();
        }


    }
}
