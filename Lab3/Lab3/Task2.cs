namespace Lab3
{
    internal class Task2
    {
        public void Task() {
            Console.WriteLine(">>> Task2");
            PrintedWork[] works= { new Magazine(), new SchoolBook("Shevchenko", 50, "Ukrainian"), new Book("Stephen King", 120, "Fantasy") };
            
            Console.WriteLine("Unordered array");
            foreach(PrintedWork work in works)
                Console.WriteLine(work.Show());
            works = works.OrderBy(x => x.GetNumberOfPages()).ToArray();

            Console.WriteLine("Ordered array");
            foreach(PrintedWork work in works)
                Console.WriteLine(work.Show());
        }
    }
}