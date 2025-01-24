using BlazorProject.Components;
using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context=context;
    }
    public async Task<AddUpdateModel> AddUser(AddUpdateModel model)
    {
         var user = new User
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Password = model.Password,
            ContactNo = model.ContactNo,
            Address = model.Address,
            DateofBirth = model.DateofBirth,
            Gender = model.Gender,
            WalletBalance = model.WalletBalance,
            CreatedAt = model.CreatedAt,
            IsActive = model.IsActive,
            Role = model.Role
        };

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        model.WalletBalance = user.WalletBalance;
        model.CreatedAt = user.CreatedAt;
        return model;
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
    public async Task<User> LoginUser(LoginModel loginModel)
    {
        var user = await _context.Users.Where(x => x.Email == loginModel.Email && x.Password == loginModel.Password).FirstOrDefaultAsync();
        return user;
    }
}