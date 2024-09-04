namespace Advanced_C_.EmployeeHandler
{
    public static class EmployeeData
    {
        public static List<Employee> SeedEmployeesData()
        {
            List<Employee> Employeelist = new();
            for (int i = 0; i < 10; i++)
            {
                Employee emp = new Employee()
                {
                    Name = $"Employee {i + 1}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Dedection = Random.Shared.Next(0, 501),
                    Bouns = Random.Shared.Next(0, 1000)
                };
                Employeelist.Add(emp);
            }

            return Employeelist;


        }

    }

}
