class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    public void GetInfo(){
        System.Console.WriteLine($"FirstName:{FirstName}\nLastName:{LastName}\nAge:{Age}");
    }
}