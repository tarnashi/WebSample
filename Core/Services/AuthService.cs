using System.Collections.Generic;
using System.Linq;
using System.Xml.Xsl;
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

        public bool CheckUserRole(string login, string role)
        {
            var worker = _ctx.Workers.FirstOrDefault(w => w.Login == login);
            if (worker != null)
            {
                return worker.AccessGroups.Any(a => a.Name == role);
            }

            return false;
        }

    }
}
