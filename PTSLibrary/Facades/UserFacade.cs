using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTSLibrary.Models;

namespace PTSLibrary.Facades
{
    internal class UserFacade : SuperFacade
    {
        private new DataAccess.UserDAO dao;

        public UserFacade() : base(new DataAccess.UserDAO())
        {
            dao = (DataAccess.UserDAO)base.dao;
        }
        public UserModel Authenticate(string email, string password)
        {
            if (email == null || password == null)
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(email, password);
        }

        public ProjectModel[] GetListOfProjects(int teamId)
        {
            return (dao.GetListOfProjects(teamId).ToArray());
        }
    }
}
