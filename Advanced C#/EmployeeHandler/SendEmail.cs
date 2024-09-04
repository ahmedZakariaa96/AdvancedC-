namespace Advanced_C_.EmployeeHandler
{
    public static class SendEmail
    {
        public static void SendEmailSalary(Employee emp, int salary)
        {
            Console.WriteLine($"{emp.Name} and salary {salary} and Bouns is {emp.Bouns}");
            Console.WriteLine("Email Send");


        }
    }

}
