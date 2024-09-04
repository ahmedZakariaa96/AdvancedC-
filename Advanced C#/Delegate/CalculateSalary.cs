using Advanced_C_.EmployeeHandler;

namespace Advanced_C_.Delegate
{
    public static class CalculateSalary
    {
        public   delegate bool EmployeeDelgate(Employee employee);
        public static event EmployeeSalaryCalculatedEventHandler employeeSalaryCalculatedEvent;
        public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);
        public static void ModernCalculateSalary(List<Employee> employees, EmployeeDelgate predicate)
        {
            var salary = 0;
            foreach (var emp in employees)
            {
                if (predicate(emp))
                {
                    salary=emp.BasicSalary+emp.Bouns+emp.Dedection;
                    employeeSalaryCalculatedEvent?.Invoke(emp, salary);

                }

            }

        }

        public static void OldCalculateSalary(List<Employee> employees,int maxBasicSalary)
        {
            var salary = 0;
            foreach (var emp in employees)
            {
                if(emp.BasicSalary<= maxBasicSalary)
                {
                    salary=emp.BasicSalary+emp.Bouns+emp.Dedection;
                    employeeSalaryCalculatedEvent?.Invoke(emp, salary);
                 }

            }

        }
    }

}
