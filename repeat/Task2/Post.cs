class Post
{
    public string Text { get; set; }

    public int Likes { get; set; }

    public List<string> strings { get; set; }=new List<string>();



    public void SetPost(string text){
        Text=text;
    }
    
    public void AddLike(){
        Likes++;
    }

    public void AddComment(string comment){

        strings.Add(comment);
    }

    public string GetInfo(){
        return $"Text={Text}\nLikes :{Likes}";
    }

    public void Cout(){
        foreach (var item in strings)
        {
            System.Console.WriteLine(item);
        }
    }
}