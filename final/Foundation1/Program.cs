using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {   
        Console.WriteLine();
        Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        Console.WriteLine("__________________________________________________________");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

         List <Author> Authors = new List<Author>
            {
                new Author { Name = "John Smith" },
                new Author { Name = "Jane Doe" },
                new Author { Name = "Michael Johnson" }
            };


        Video video1 = new Video
        {
            Title = "The Secrets of the Universe",
            VideoAuthor = "John Kleber",
            Length = 120,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video1.Comments.Add(
            Authors[0],
            new List<Comment>
            {
                new Comment { Author = Authors[0], Text = "Great video!" },
            });

        video1.Comments.Add(
            Authors[1],
            new List<Comment>
            {
                new Comment { Author = Authors[1], Text = "Well explained." },
            });

        video1.Comments.Add(
            Authors[2],
            new List<Comment>
            {
                new Comment { Author = Authors[2], Text = "Nice presentation." },
            });

        videos.Add(video1);

        Authors = new List<Author>
            {
                new Author { Name = "Emily Wilson" },
                new Author { Name = "David Thompson" },
                new Author { Name = "Joana D'arc" }
            };

        Video video2 = new Video
        {
            Title = "Exploring Ancient Civilizations",

            VideoAuthor = "Renata santiago",

            Length = 180,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video2.Comments.Add(
            Authors[0],
            new List<Comment>
            {
                new Comment { Author = Authors[0], Text = "Helpful content." },
            });

        video2.Comments.Add(
            Authors[1],
            new List<Comment>
            {
                new Comment { Author = Authors[1], Text = "Well done!" },
            });

        video2.Comments.Add(
            Authors[2],
            new List<Comment>
            {
                new Comment { Author = Authors[2], Text = "Interesting!" },
            });

        videos.Add(video2);

        Authors = new List<Author>
            {
                new Author { Name = "Sarah Davis" },
                new Author { Name = "Robert Johnson" },
                new Author { Name = "Olivia Brown" },
                new Author { Name = "Matthew Wilson" }
            };

        Video video3 = new Video
        {
            Title = "Mastering the Art of Cooking",
            VideoAuthor = "Renata santiago",
            Length = 240,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video3.Comments.Add(
            Authors[0],
            new List<Comment>
            {
                new Comment { Author = Authors[0], Text = "Well articulated." },
            });

        video3.Comments.Add(
            Authors[1],
            new List<Comment>
            {
                new Comment { Author = Authors[1], Text = "Good job!" },
            });

        video3.Comments.Add(
            Authors[2],
            new List<Comment>
            {
                new Comment { Author = Authors[2], Text = "Inspirational content." },
            });

        video3.Comments.Add(
            Authors[3],
            new List<Comment>
            {
                new Comment { Author = Authors[3], Text = "Looking forward to more videos." },
            });

        videos.Add(video3);

        Authors = new List<Author>
            {
                new Author { Name = "Daniel Clark" },
                new Author { Name = "Julia Neira" },
                new Author { Name = "Karim Abdalah" }
            };

        Video video4 = new Video
        {
            Title = "Adventures in Outer Space",
            VideoAuthor = "Stephen King",
            Length = 150,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video4.Comments.Add(
            Authors[0],
            new List<Comment>
            {
                new Comment { Author = Authors[0], Text = "Nice visuals." },
            });

        video4.Comments.Add(
            Authors[1],
            new List<Comment>
            {
                new Comment { Author = Authors[1], Text = "Short and sweet." },
            });

        video4.Comments.Add(
            Authors[2],
            new List<Comment>
            {
                new Comment { Author = Authors[2], Text = "Nice video!" },
            });
        videos.Add(video4);
    
    foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine();
            Console.WriteLine("Video's Author: " + video.VideoAuthor);

            Console.WriteLine();
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine();
            Console.WriteLine("Comments ("+ video.GetNumberOfComments()+"):");
            foreach (KeyValuePair<Author, List<Comment>> commentList in video.Comments)
            {   
                Console.WriteLine();
                Author author = commentList.Key;
                List<Comment> comments = commentList.Value;

                Console.WriteLine("• " + author.Name + ":");
                foreach (Comment comment in comments)
                {
                    Console.WriteLine("- " + comment.Text);
                }
            }
            Console.WriteLine("________________________________________________________"); 
            Console.WriteLine();
        }
    }
}
