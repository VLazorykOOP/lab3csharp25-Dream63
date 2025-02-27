namespace Lab3
{
    public class Book : PrintedWork {
        private string genre;

        public Book(String Author, int NumOfPages, String Genre) : base(Author, NumOfPages) {
            genre = Genre;
        }

        public Book() : base() {

            genre = "unknowm";
        }

        public new string Show() {
            return "Book --- Genre: " + genre + " | " + base.Show(); 
        }
    }
}