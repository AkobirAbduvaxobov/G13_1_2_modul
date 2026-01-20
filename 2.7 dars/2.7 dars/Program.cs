namespace _2._7_dars;

internal class Program
{
    static void Main(string[] args)
    {

        User user = new User();

        user.FirstName = "Akobir";
        var name = user.FirstName;

        user.Password = "1234";



        //Code code = new Code()
        //{
        //    Language = "C#",
        //    Database = "SQL"
        //};

        //CodeService codeService = new CodeService();
        //codeService.AddCode(code);
        //codeService.GetAllCodes();




        //Code code1 = new Code();
        //code1.CodeId = Guid.NewGuid();

        //ChildCode childCode = new ChildCode();
        //childCode.Database = "sd";

    }

}
