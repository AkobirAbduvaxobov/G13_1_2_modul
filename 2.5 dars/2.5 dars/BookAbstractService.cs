namespace _2._5_dars;

public abstract class BookAbstractService
{

    public void DeleteBook()
    {
        Console.WriteLine("DeleteBook method ishga tushdi abstract classda");
    }
    public virtual void GetBooks()
    {
        Console.WriteLine("GetBooks method isjga tushdi abstract classda");
    }
    public abstract Guid AddBook();

}
