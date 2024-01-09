class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }


    public string GetFullName(){
        return$"My name is {FirstName} {LastName}";
    }
    
    public int GetBirthYear(){
        return Age;
    }
}