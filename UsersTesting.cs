using ticktrax_backend.Data;
using Microsoft.AspNetCore.Identity;

namespace ticktraxtesting;

public class UsersTesting
{
    IUserService _userService;
    TickTraxContext _context;
    UserManager<User> _userManager;

    public UsersTesting()
    {
        _userService = new UserService(_context, _userManager);
    }


    //test for getting indivdual users based on username
    [Fact]
    public void GetUsersTest()
    {
        var result = _userService.GetUserByUserName("fran");

        Assert.IsType<System.Threading.Tasks.Task<User>>(result);
    }
}