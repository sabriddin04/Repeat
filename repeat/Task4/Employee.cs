class Employee
{
    public string FirstName{ get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public string Position { get; set; }
    public decimal Salary { get; set; }



    public void SetSalary(decimal salary){
        Salary=salary;
    }
    
    public decimal GetSalary(){
        return Salary;
    }

    public string GetInfo(){
        return $"Name:{FirstName}\nLastName:{LastName}\nAge:{Age}\nPosition:{Position}\nSalary:{Salary}";
    }


}