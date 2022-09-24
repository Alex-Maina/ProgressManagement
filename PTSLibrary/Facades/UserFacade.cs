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
        private new DataAccess.StudentDAO dao;

        public UserFacade() : base(new DataAccess.StudentDAO())
        {
            dao = (DataAccess.StudentDAO)base.dao;
        }

        public int Authenticate(string email, string password)
        {
            if (email == null || password == null)
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(email, password);
        }
    }
}
