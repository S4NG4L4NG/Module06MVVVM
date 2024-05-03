using Module06MVVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Threading.Tasks;

namespace Module06MVVVM.ViewModel
{

    public class EmployeeViewModel
    {
        //public EmployeeModel EmployeeModelSet { get; set; }
        //public EmployeeViewModel()
        //    {
        //        EmployeeModelSet = new EmployeeModel
        //        {
        //            Id = 1,
        //            Name = "Leandro Sangalang",
        //            Email = "Leandro@gmail.com",
        //            Address = "Bamban Ruins"

        //        };
        //    }

        private Services.DatabaseContext getContext()
        {
            return new Services.DatabaseContext();
        }

        public int InsertEmployee (EmployeeModel obj)
        {
            var _dbContext = getContext();
            _dbContext.Employees.Add(obj);
            int c = _dbContext.SaveChanges();
            return c;
        }

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var _dbContext = getContext();
            var res = await _dbContext.Employees.ToListAsync();
            return res;
        }

    }
    }
