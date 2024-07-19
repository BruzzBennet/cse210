using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos=new List<Video>();

        Video video1= new Video();
        Comments comment1a=new Comments();
        Comments comment1b=new Comments();
        Comments comment1c=new Comments();

        video1.SetAuthor("Vine Compilations");
        video1.SetTitle("Top 100 Vines of 2010");
        video1.SetDuration(800);
        comment1a.SetUsername("lol101");
        comment1a.SetComment("I miss vines so much");
        video1.AddComment(comment1a);
        comment1b.SetUsername("wacko");
        comment1b.SetComment("7:10 was my favorite");
        video1.AddComment(comment1b);
        comment1c.SetUsername("miami memes");
        comment1c.SetComment("I love vines");
        video1.AddComment(comment1c);

        videos.Add(video1);

        Video video2= new Video();
        Comments comment2a=new Comments();
        Comments comment2b=new Comments();
        Comments comment2c=new Comments();

        video2.SetAuthor("Relaxing Music");
        video2.SetTitle("Music to fall asleep to");
        video2.SetDuration(36000);
        comment2a.SetUsername("GoodMom7");
        comment2a.SetComment("I love this so much");
        video2.AddComment(comment2a);
        comment2b.SetUsername("Jenn Stirling");
        comment2b.SetComment("So relaxing");
        video2.AddComment(comment2b);
        comment2c.SetUsername("miami memes");
        comment2c.SetComment("I love vines");
        video2.AddComment(comment2c);

        videos.Add(video2);

        Video video3= new Video();
        Comments comment3a=new Comments();
        Comments comment3b=new Comments();
        Comments comment3c=new Comments();
        Comments comment3d=new Comments();

        video3.SetAuthor("Relaxing Music");
        video3.SetTitle("Music to fall asleep to");
        video3.SetDuration(36000);
        comment3a.SetUsername("ProjectJamesify");
        comment3a.SetComment("Who even cares about the Grammys anymore?");
        video3.AddComment(comment3a);
        comment3b.SetUsername("howow638");
        comment3b.SetComment("this is a song that I cant get enough of listening to cause of its beautiful emotions, this and 'Loveblinded' by Mysteriousic are 2 really the songs that truly make you feel something, i wish i can never get enough of this song");
        video3.AddComment(comment3b);
        comment3c.SetUsername("user-or6yn8pm3c");
        comment3c.SetComment("Michael Jackson lives in the Weeknd");
        video3.AddComment(comment3c);
        comment3d.SetUsername("tjtaylor5273");
        comment3d.SetComment("Simply put he's saying he'd rather die than put on a fake face and perform for a meaningless award in front of fake people");
        video3.AddComment(comment3d);

        videos.Add(video3);

        foreach (Video item in videos){
            item.Display();
            Console.WriteLine();
        }
    }
}