class Player
{
    public string Name { get; set; }
    public int Number { get; set; }
    public string Position { get; set; }
    public string Team { get; set; }




    public void ScoreGoal(){
        System.Console.WriteLine($"Name:{Name}\nNumber:{Number}\n GOOOOOOOOOL");
    }


    public void AssistGoal(string player_name){
        System.Console.WriteLine($"Name:{Name}\nAssist:{player_name}");

    }
    public void GetInfo(){
        System.Console.WriteLine($"Name:{Name}\nNumber:{Number}\nPosition:{Position}\nTeam:{Team}");
    }
}