<h1>Delegates_Csharp</h1>
Delegates

Delegate is a function pointer.

Which means a delegate will point to some function.

But the function’s return type and the parameters of the functions will
have to be same.

Like if the return type of a function is int than the delegate you will create
will also have the return type of int.

Similar is the case with the parameters of delegate and the function to
which it points.

Delegates are type safe.

As we already know that a delegate points to some function of the
similar signature.

So, we need a function. Let's create a function “exampleFun”.

exampleFun will have a return type “void” and will have a “string”
type parameter.

public static void exampleFun(string par1)

{

Console.WriteLine(par1);

}

Now let's create a delegate as we already have the pointing function.

There is a reserved keyword “Delegate” for creating a delegate.

In simple words you can think of creating a simple function with the
keyword “Delegate”.

public delegate void exampleDelegate(string delPar);

The above delegate can point to any function that have void return
type and string parameter.

Next step is to make the delegate point the function.

Let's create an instance of the delegate just like class in the main.

exampleDelegate delob = new exampleDelegate(exampleFun);

Delegate can be invoked using delob.

delob("Function Invoked from Delegate");

Scenario

Consider a scenario where we have an Employee class with some
basic parameters Id, Name, Salary, Experience.

Let's create a method “Promotion” which takes a list of employees
and see if an employee has 5 years of experience, he/she will get
promoted.

Let's initialize the list with some dummy data in the main by creating
a list of employees.

Consider a scenario where we have an Employee class with some basic
parameters Id, Name, Salary, Experience.

class Employee

{

public int empId { get; set; }

public string empName { get; set; }

public int empSalary { get; set; }

public int empExperience { get; set; }

}

Let's create a method “Promotion” which takes a list of employees and see if an employee has 5
years of experience, he/she will get promoted.

public void promotion(List<Employee> employeeList)

{

foreach(var employee in employeeList)

{

if(employee.empExperience >= 5)

{

Console.WriteLine(employee.empName + "Promoted");

}

}

}

Let's initialize the list with some dummy data in the main by creating a list of
employees.

List<Employee> employeeList = new List<Employee>();

employeeList.Add(new Employee { empId = 1, empName = "Awais", empSalary = 30000, empExperience = 5 });

employeeList.Add(new Employee { empId = 2, empName = "Ali", empSalary = 40000, empExperience = 7 });

employeeList.Add(new Employee { empId = 3, empName = "Ahmad", empSalary = 20000, empExperience = 3 });

employeeList.Add(new Employee { empId = 4, empName = "Sara", empSalary = 50000, empExperience = 6 });

employeeList.Add(new Employee { empId = 5, empName = "Waqas", empSalary = 10000, empExperience = 2 });

Problem

Problem with the current implementation is that if the criteria for
promotion is changed than the method inside the class needs to be
changed.

So, in the current scenario delegates can be used in order to enhance
the reusability of the class.

Like every company can have its own criteria so they will not change
the implementation of your class, but they can change the logic that
is implemented outside of class.

In the current scenario we have to move the logic from the class to
some outside function.

Currently the total dependency of promotion is based on the if
condition, if true the employee promoted and in case of false
employee does not promote.

Let’s create a function “Promote” that accepts an Employee object
and returns true or false based on the condition.

public bool Promote(Employee emp)

{

if(emp.empExperience >= 5)

{

return true;

}

else

{

return false;

}

}

Now we have to create a delegate for the “Promote” function.

delegate bool Promotable(Employee emp);

Now change the code of promotion method of the class.

This method will receive two parameters. One is the list of employees and
other is the delegate for function invocation.

if (Eligible(employee))

Now in the main we have to create an instance of delegate
Promotable.

Promotable prom = new Promotable(Promote);

And the “promotion” method that was called by ob object will now
receive prom along with the list of employees.
