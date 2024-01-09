class Student
{
    public string Name { get; set; }
    public int GradeLevel { get; set; }
     List<int>scores=new List<int>();

     public void AddScores(int first){
        scores.Add(first);
     }

     public double GetAvarage(){

int sum=0;
        foreach (var item in scores)
        {
            sum+=item;
        }
        return sum/scores.Count;
     }
}