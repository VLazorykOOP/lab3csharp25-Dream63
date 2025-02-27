namespace Lab3 {
public class SchoolBook : PrintedWork {
    private string lesson;

    public SchoolBook(string Author, int NumOfPages, String Lesson) : base(Author, NumOfPages) {
        lesson = Lesson;
    }

    public SchoolBook() : base() {
        lesson = "unknown";
    }

    public new string Show() {
        return "SchoolBook --- Lesson: " + lesson + " | " + base.Show(); 
    }
}
}

