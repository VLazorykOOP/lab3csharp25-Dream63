namespace Lab3
    {
    public class PrintedWork {
        string author;
        int numOfPages;

        public PrintedWork(string Author, int NumOfPages) {
            author = Author;
            numOfPages = NumOfPages;
        }
        public PrintedWork() {
            author = "Unknown";
            numOfPages = 1;
        }

        public String Show() {
            return "Author: " + author + " | number of pages: " + numOfPages; 
        }

        public int GetNumberOfPages() { return numOfPages; }
    }
}