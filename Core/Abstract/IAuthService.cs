using System.Collections.Generic;
using Core.Models;

namespace Core.Abstract
{
    public interface IAuthService
    {
        bool CheckLogin(string login, string password);
        bool CheckUserRole(string login, string role);
    }
}