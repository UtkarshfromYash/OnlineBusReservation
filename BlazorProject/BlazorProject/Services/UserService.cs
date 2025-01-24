using BlazorProject.Models.Models;

public class UserService:IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository=userRepository;
    }
    public async Task<AddUpdateModel> AddUser(AddUpdateModel user)
    {
         var result = await _userRepository.AddUser(user);
        
        // Return a new instance instead of the entity directly
        return new AddUpdateModel
        {
            FirstName = result.FirstName,
            LastName = result.LastName,
            Email = result.Email,
            Password = result.Password,
            ContactNo = result.ContactNo,
            Address = result.Address,
            DateofBirth = result.DateofBirth,
            Gender = result.Gender,
            WalletBalance = result.WalletBalance,
            CreatedAt = result.CreatedAt,
            IsActive = result.IsActive,
            Role = result.Role
        };
    }

    public Task<User> DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUser(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetUsers()
    {
        throw new NotImplementedException();
    }

    public Task<AddUpdateModel> UpdateUser(AddUpdateModel user)
    {
        throw new NotImplementedException();
    }

    public async Task<User> LoginUser(LoginModel loginModel){
        return await _userRepository.LoginUser(loginModel);
    }
}