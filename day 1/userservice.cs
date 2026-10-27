public  class UserSer : User, IUserSer
{
    List<User> users = new List<User>();
    public UserSer(){}
    public UserSer(User user)
    {
        users.Add(user);
    }

    public void Add(User user)
    {
        users.Add(user);
        Console.WriteLine("!!!!!!!!!!!Student Aded!!!!!!!!!!!");
    }

    public void Delete(int id)
    {
       Console.WriteLine("!!!!!!!!!!!Student Deleted!!!!!!!!!!!");
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public void Update(int I, string Fn, string? Adre)
    {
        Console.WriteLine("!!!!!!!!!!!Student Updated!!!!!!!!!!!");
        foreach (var item in users)
        {
            if (item.Id == I)
            {
                item.FullNAme=Fn;
                item.Adress = Adre;
            }
        }
    }

}