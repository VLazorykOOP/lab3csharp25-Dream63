namespace Lab3 {
public class Magazine : PrintedWork {
    private  double price;

    public Magazine(string Author, int NumOfPages, double Price) : base(Author, NumOfPages) {
        price = Price;
    }

    public Magazine() :base() {
        price = 0;
    }

    public new string Show() {
        return "Magazine --- Price: " + price + " | " + base.Show(); 
    }
}
}

