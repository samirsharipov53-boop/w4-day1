public interface IUserSer
{
    void Delete(int id);
    List<User> GetUsers();
    void Add(User user);
    void Update(int id, string fn, string ad);
}