using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{

    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public  async Task<List<Department>> FindAllAssync()
        {

            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public void Inset(Department department)
        {
            _context.Add(department);
            _context.SaveChanges();
        }
    }


}
