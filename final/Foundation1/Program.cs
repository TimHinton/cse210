using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.SetTitle("Memes of Today");
        video1.SetAuthor("ThatOneKid");
        video1.SetLength("10:52");

        Comment vid1Comment1 = new Comment();
        vid1Comment1.SetCommenter("Haterade");
        vid1Comment1.SetCommentText("Memes? More like borophyl...");
        video1.AddComment(vid1Comment1);

        Comment vid1Comment2 = new Comment();
        vid1Comment2.SetCommenter("Thugga-chicka82");
        vid1Comment2.SetCommentText("Those cats always get me!");
        video1.AddComment(vid1Comment2);
        
        Comment vid1Comment3 = new Comment();
        CreateComment(vid1Comment3, "Strong-Bad", "Yo, that was dope. Me and The Cheat were rofl'ing.", video1);
        video1.AddComment(vid1Comment3);


        Video video2 = new Video();
        video2.SetTitle("Reaction to Her Reaction Video");
        video2.SetAuthor("WhatsHerFace2004");
        video2.SetLength("Way too long");

        Comment vid2Comment1 = new Comment();
        CreateComment(vid2Comment1, "Dave2thegrave", "She done got bodied!.", video2);
        Comment vid2Comment2 = new Comment();
        CreateComment(vid2Comment2, "MSeeHammer", "Did she ever react back to your reaction video of her reaction?", video2);
        Comment vid2Comment3 = new Comment();
        CreateComment(vid2Comment3, "Strong-Bad", "Yo, that was dope. Me and The Cheat were rofl'ing.", video2);


        Video video3 = new Video();
        video3.SetTitle("Watch to the End");
        video3.SetAuthor("Wut?");
        video3.SetLength("2:22");

        Comment vid3Comment1 = new Comment();
        CreateComment(vid3Comment1, "Strong-Sad", "Why can't the squirrels just have the nuts?", video3);
        Comment vid3Comment2 = new Comment();
        CreateComment(vid3Comment2, "Coach Z", "Good jeeooorrrb!", video3);
        Comment vid3Comment3 = new Comment();
        CreateComment(vid3Comment3, "@TheRealCheat", "Don't listen to anything Strong-Bad says, he doesn't know what he's talking about.", video3);

        List<Video> videoList = new List<Video>();

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();
        }
    }

    static void CreateComment(Comment name, string author, string comment, Video video)
    {
        name.SetCommenter(author);
        name.SetCommentText(comment);
        video.AddComment(name);
    }
}