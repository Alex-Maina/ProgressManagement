using PTSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.DataAccess
{
    public interface IDataConnection
    {
        ProjectModel Create_Project(ProjectModel model);
    }
}
