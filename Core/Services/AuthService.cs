using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Abstract;
using Core.Models;
using Data.DataAccess;

namespace Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _ctx;

        public AuthService()
        {
            _ctx = new DataContext();
        }

        public bool CheckLogin(string login, string password)
        {
            return _ctx.Workers.SingleOrDefault(w => w.Login == login && w.Password == password) != null;
        }
    }
}
