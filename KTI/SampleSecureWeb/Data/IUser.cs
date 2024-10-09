namespace SampleSecureWeb;
using SampleSecureWeb.Models;


public interface IUser
{
    User Registration(User user);
    User Login(User user);
}
