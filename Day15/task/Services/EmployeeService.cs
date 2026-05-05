using System.Collections.Generic;
using System.Threading.Tasks;
using Day15.Models;

namespace Day15.Services
{
    public class EmployeeService
    {
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await Task.Run(() =>
            {
                Task.Delay(1500).Wait();
                return new List<Employee>
                {
                    new Employee { Id = 1, FullName = "Иванов Иван Иванович", Position = "Разработчик", DepartmentId = 1 },
                    new Employee { Id = 2, FullName = "Петров Петр Петрович", Position = "Менеджер", DepartmentId = 2 },
                    new Employee { Id = 3, FullName = "Сидорова Анна Сергеевна", Position = "Аналитик", DepartmentId = 1 },
                    new Employee { Id = 4, FullName = "Козлов Дмитрий Алексеевич", Position = "Разработчик", DepartmentId = 1 }
                };
            });
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await Task.Run(() => Task.Delay(500));
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await Task.Run(() => Task.Delay(500));
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await Task.Run(() => Task.Delay(500));
        }
    }
}