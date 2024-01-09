var st1 = new Student();
st1.Name = "Sabr";
st1.GradeLevel = 11;
st1.AddScores(90);
st1.AddScores(90);
st1.AddScores(90);
System.Console.WriteLine(st1.GetAvarage());
var st2 = new Student();
st2.Name = "Akmal";
st2.GradeLevel = 22;
st2.AddScores(70);
st2.AddScores(70);
st2.AddScores(70);
System.Console.WriteLine(st1.GetAvarage());
var st3 = new Student();
st3.Name = "Aziz";
st3.GradeLevel = 33;
st3.AddScores(60);
st3.AddScores(60);
st3.AddScores(60);
System.Console.WriteLine(st1.GetAvarage());
var st4 = new Student();
st4.Name = "Ustod";
st4.GradeLevel = 44;
st4.AddScores(50);
st4.AddScores(50);
st4.AddScores(50);
System.Console.WriteLine(st1.GetAvarage());
var st5 = new Student();
st5.Name = "Shogird";
st5.GradeLevel = 55;
st5.AddScores(75);
st5.AddScores(75);
st5.AddScores(75);
System.Console.WriteLine(st1.GetAvarage());

List<Student> students = new List<Student>();
students.Add(st1);
students.Add(st2);
students.Add(st3);
students.Add(st4);
students.Add(st5);

foreach (var item in students)
{
    if (item.GetAvarage() > 85) { System.Console.WriteLine("продолжай в том же духе :" + item.Name); }
    else if (item.GetAvarage() < 70) { System.Console.WriteLine("побольще занимайся уроками:" + item.Name); }
    else {System.Console.WriteLine(" не плохо но трудись усерднее:" + item.Name);}
}