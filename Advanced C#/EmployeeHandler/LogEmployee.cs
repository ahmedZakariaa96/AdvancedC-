namespace Advanced_C_.EmployeeHandler
{
    public static class LogEmployee
    {
        public static void logEmployeeSalary(Employee emp, int salary)
        {
            Console.WriteLine($"{emp.Name} and salary {salary} and Bouns is {emp.Bouns}");
            Console.WriteLine("logeed Saved");

        }
    }

}
