namespace _2._7_dars;

public class User
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }


    private string paswword;

    public string Password
    {
        get { return paswword; }
        set { paswword = value; }
    }




    public string LastName { get; set; }
    public string FirstName
    {
        get
        {
            return FirstName;
        }
        set
        {
            FirstName = value;
        }
    }


    public string Email;
    //public string GetEmail()
    //{
    //    return Email;
    //}
    //public void SetEmail(string email)
    //{
    //    if(email.Length > 7)
    //    {
    //        Email = email;
    //    }

    //}

}
