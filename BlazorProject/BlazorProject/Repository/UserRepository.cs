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

    public async Task<bool> DeleteUser(int userId)
    {
        var user=await _context.Users.FindAsync(userId);
        if(user!=null){
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<User> GetUser(int userId)
    {
        var user= await _context.Users.FirstOrDefaultAsync(x=>x.UserId==userId);
        return user;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        var users=await _context.Users.ToListAsync();
        return users;
    }

    public async Task<AddUpdateModel> UpdateUser(int id,AddUpdateModel user)
    {
        var existuser=await _context.Users.FindAsync(id);
        if(existuser!=null){
            existuser.FirstName=user.FirstName;
            existuser.LastName=user.LastName;
            existuser.Email=user.Email;
            existuser.Password=user.Password;
            existuser.ContactNo=user.ContactNo;
            existuser.Address=user.Address;
            existuser.DateofBirth=user.DateofBirth;
    }
        await _context.SaveChangesAsync();
        return user;
    }
    public async Task<User> LoginUser(LoginModel loginModel)
    {
        var user = await _context.Users.Where(x => x.Email == loginModel.Email && x.Password == loginModel.Password).FirstOrDefaultAsync();
        return user;
    }
}