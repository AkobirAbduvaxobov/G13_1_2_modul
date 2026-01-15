
namespace _2._5_dars;

public class BookService : BookAbstractService
{
    List<Book> Books = new List<Book>();

    public void DeleteBook()
    {
        Console.WriteLine("DeleteBook method ishga tushdi BookService classda");
    }
    public override void GetBooks()
    {
        Console.WriteLine("GetBooks method isjga tushdi BookService classda");
    }

    public override Guid AddBook()
    {
        Console.WriteLine("AddBook ishgA TUSHDI BookService CALSSDA");
        return Guid.NewGuid();
    }
}
