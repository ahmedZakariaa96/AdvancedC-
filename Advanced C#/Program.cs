//async and await
//1.2
//using Advanced_C_.MultiThrading;

//    var ctx = new CancellationTokenSource();
//    Console.WriteLine("Main thread is "+ Environment.CurrentManagedThreadId);
//    await MultiThrading.Process1(ctx);
//    await MultiThrading.Process2(ctx);
//    Console.ReadLine();
 



//-------------------------------------------------
//multiThrading
//1.1
//using Advanced_C_.MultiThrading;
    //var thrd1 = new Thread(MultiThrading.Process1);
    //var thrd2 = new Thread(MultiThrading.Process2);
    //thrd1.IsBackground = true;
    //thrd2.IsBackground = true;
    //thrd1.Priority = ThreadPriority.Highest;
    //thrd1.Priority = ThreadPriority.BelowNormal;
    //thrd1.Start();
    //thrd2.Start();
    //Console.ReadKey();
//------------------------------------------------------------------------------------------
    //var ctx = new CancellationTokenSource();
    //ThreadPool.QueueUserWorkItem(MultiThrading.Process1, ctx.Token);
    //ThreadPool.QueueUserWorkItem(MultiThrading.Process2, ctx.Token);
    //Thread.Sleep(100);
    //ctx.Cancel();

//-------------------------------------------------
    ////3.2 delegate

    //using Advanced_C_.Delegate;
    //using Advanced_C_.EmployeeHandler;
    //var empData = EmployeeData.SeedEmployeesData();
    //CalculateSalary.employeeSalaryCalculatedEvent+=LogEmployee.logEmployeeSalary;
    //CalculateSalary.employeeSalaryCalculatedEvent+=SendEmail.SendEmailSalary;
    //Console.WriteLine("--------------------------------Start----------------------");

    //Console.WriteLine("-----------------------------Old Calculate---------------------------");
    //CalculateSalary.OldCalculateSalary(empData,2000);
    //Console.WriteLine("-----------------------------Modern Calculate---------------------------");
    // CalculateSalary.ModernCalculateSalary(empData, x => x.BasicSalary<2000);
    //Console.WriteLine("-----------------------------New Predicate--------------------------");
    // CalculateSalary.ModernCalculateSalary(empData, x => x.BasicSalary<2000&&x.Bouns<=300);
    //Console.WriteLine("--------------------------------End----------------------");




//-------------------------------------------------
    //3.1 delegate

    //using Advanced_C_.Delegate;

    //int num1 = 10, num2 = 5;
    //var result=DelegateClass.OldCalculate(num1 , num2,'+');
    //Console.WriteLine(result);
    //DelegateClass.GenericDelegate dlg = DelegateClass.Add;
    //DelegateClass.ModernCalculate(num1, num2, dlg);
    //DelegateClass.ModernCalculate(num1, num2, DelegateClass.Sub);
    //DelegateClass.ModernCalculate(num1, num2, (x, y) => { return x*y; });
    //DelegateClass.ModernCalculate(num1, num2, (x, y) =>  x/y);





//-------------------------------------------------
    //2

    //Console.WriteLine("Please Enter Value ");
    //var value=Console.ReadLine();

    //Console.WriteLine(value.RemoveWhiteSpace().Reverse());

//-------------------------------------------------
    ////1
    //int value = -10;
    ////if(NumberExtenstion.IsBetween(value,0,100))
    //if (value.IsBetween( 0, 100))

    //{
    //    Console.WriteLine("Is Valid Number ");
    //}
    //else
    //{
    //Console.WriteLine("Is Not Valid Number");
    //}
//-------------------------------------------------
