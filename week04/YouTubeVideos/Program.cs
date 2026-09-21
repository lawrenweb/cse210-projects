using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = new Video(
            "Learning C# Classes",
            "Code Academy",
            620);
        firstVideo.AddComment(new Comment("Jamie", "The class examples were very clear."));
        firstVideo.AddComment(new Comment("Taylor", "I finally understand constructors."));
        firstVideo.AddComment(new Comment("Morgan", "The practice exercise was helpful."));

        Video secondVideo = new Video(
            "Easy Weeknight Recipes",
            "Home Kitchen",
            845);
        secondVideo.AddComment(new Comment("Sam", "I made this recipe for dinner and loved it."));
        secondVideo.AddComment(new Comment("Alex", "The instructions were easy to follow."));
        secondVideo.AddComment(new Comment("Riley", "I will try adding extra vegetables next time."));

        Video thirdVideo = new Video(
            "Beginner Landscape Photography",
            "Outdoor Focus",
            1130);
        thirdVideo.AddComment(new Comment("Jordan", "The lighting tips made a big difference."));
        thirdVideo.AddComment(new Comment("Casey", "The mountain examples were beautiful."));
        thirdVideo.AddComment(new Comment("Drew", "I am taking my camera outside this weekend."));

        List<Video> videos = new List<Video> { firstVideo, secondVideo, thirdVideo };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}