using BlazorProject.Models.Models;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsers();
    Task<User> GetUser(int userId);
    Task<AddUpdateModel> AddUser(AddUpdateModel user);
    Task<AddUpdateModel> UpdateUser(AddUpdateModel user);
    Task<User> DeleteUser(int userId);
    Task<User> LoginUser(LoginModel loginModel);
}