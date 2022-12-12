using TYPES;
using DATABASE;
namespace LOGIC;
public interface ILoginService
{
    public Customer TryLogin (string email, string passWord);
}