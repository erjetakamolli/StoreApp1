using Microsoft.EntityFrameworkCore;
using StoreApp1.Data;
using StoreApp1.Models;
using StoreApp1.View;

namespace StoreApp1.Services

{
    public class EmployeeService
    {
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }
        public void AddEmployee(EmployeeVM employee)
        {
            var _employee = new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Dept = employee.Dept,
                Address = employee.Address,
                IsActive = employee.IsActive,
                DateOfBirth = employee.DateOfBirth,
                Position = employee.PositionId,
                ModifiedDate = employee.ModifiedDate,

            };
            _context.Employees.Add(_employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees() => _context.Employees.ToList();
#pragma warning disable CS8603 // Possible null reference return.
        public Employee GetEmployeeById(int? id) => _context.Employees.FirstOrDefault(x => x.Id == id);

        public Employee UpdateEmployeeById(int id, EmployeeVM employee)
        {
            var _employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (_employee != null)
            {
                employee.FirstName = employee.FirstName;
                employee.LastName = employee.LastName;
                employee.Dept = employee.Dept;
                employee.Address = employee.Address;
                employee.IsActive = employee.IsActive;
                employee.DateOfBirth = employee.DateOfBirth;
                employee.PositionId = employee.PositionId;
                employee.ModifiedDate = employee.ModifiedDate;

                _context.SaveChanges();
            }
#pragma warning disable CS8603 // Possible null reference return.
            return _employee;
        }

        public void DeleteEmployeeById(int id)
        {
            var _employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (_employee != null)
            {
                _context.Employees.Remove(_employee);
                _context.SaveChanges();
            }
        }
    }
}
