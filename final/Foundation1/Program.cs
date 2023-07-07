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

        Video video1 = new Video
        {
            Title = "The Secrets of the Universe",

            VideoAuthor = "John Kleber",

            Authors = new List<Author>
            {
                new Author { Name = "John Smith" },
                new Author { Name = "Jane Doe" },
                new Author { Name = "Michael Johnson" }
            },
            Length = 120,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video1.Comments.Add(
            video1.Authors[0],
            new List<Comment>
            {
                new Comment { Author = video1.Authors[0], Text = "Great video!" },
            });

        video1.Comments.Add(
            video1.Authors[1],
            new List<Comment>
            {
                new Comment { Author = video1.Authors[1], Text = "Well explained." },
            });

        video1.Comments.Add(
            video1.Authors[2],
            new List<Comment>
            {
                new Comment { Author = video1.Authors[2], Text = "Nice presentation." },
            });

        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Exploring Ancient Civilizations",

            VideoAuthor = "Renata santiago",

            Authors = new List<Author>
            {
                new Author { Name = "Emily Wilson" },
                new Author { Name = "David Thompson" },
                new Author { Name = "Joana D'arc" }
            },
            Length = 180,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video2.Comments.Add(
            video2.Authors[0],
            new List<Comment>
            {
                new Comment { Author = video2.Authors[0], Text = "Helpful content." },
            });

        video2.Comments.Add(
            video2.Authors[1],
            new List<Comment>
            {
                new Comment { Author = video2.Authors[1], Text = "Well done!" },
            });

        video2.Comments.Add(
            video2.Authors[2],
            new List<Comment>
            {
                new Comment { Author = video2.Authors[1], Text = "Interesting!" },
            });

        videos.Add(video2);

        Video video3 = new Video
        {
            Title = "Mastering the Art of Cooking",
            VideoAuthor = "Renata santiago",
            Authors = new List<Author>
            {
                new Author { Name = "Sarah Davis" },
                new Author { Name = "Robert Johnson" },
                new Author { Name = "Olivia Brown" },
                new Author { Name = "Matthew Wilson" }
            },
            Length = 240,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video3.Comments.Add(
            video3.Authors[0],
            new List<Comment>
            {
                new Comment { Author = video3.Authors[0], Text = "Well articulated." },
            });

        video3.Comments.Add(
            video3.Authors[1],
            new List<Comment>
            {
                new Comment { Author = video3.Authors[1], Text = "Good job!" },
            });

        video3.Comments.Add(
            video3.Authors[2],
            new List<Comment>
            {
                new Comment { Author = video3.Authors[2], Text = "Inspirational content." },
            });

        video3.Comments.Add(
            video3.Authors[3],
            new List<Comment>
            {
                new Comment { Author = video3.Authors[3], Text = "Looking forward to more videos." },
            });

        videos.Add(video3);

        Video video4 = new Video
        {
            Title = "Adventures in Outer Space",
            VideoAuthor = "Stephen King",
            Authors = new List<Author>
            {
                new Author { Name = "Daniel Clark" },
                new Author { Name = "Julia Neira" },
                new Author { Name = "Karim Abdalah" }
            },
            Length = 150,
            Comments = new Dictionary<Author, List<Comment>>()
        };

        video4.Comments.Add(
            video4.Authors[0],
            new List<Comment>
            {
                new Comment { Author = video4.Authors[0], Text = "Nice visuals." },
            });

        video4.Comments.Add(
            video4.Authors[1],
            new List<Comment>
            {
                new Comment { Author = video4.Authors[0], Text = "Short and sweet." },
            });

        video4.Comments.Add(
            video4.Authors[2],
            new List<Comment>
            {
                new Comment { Author = video4.Authors[0], Text = "Nice video!" },
            });
        videos.Add(video4);

        Video video5 = new Video
        {
            Title = "Unleashing Your Creative Potential",
            VideoAuthor = "Rupi Kaur",
            Authors = new List<Author>
            {
                new Author { Name = "Sophia Thompson" },
                new Author { Name = "Ana Smith" },
                new Author { Name = "Marcus Trent" }
            },

            Length = 200,
            Comments = new Dictionary<Author, List<Comment>>()
        };  

            video5.Comments.Add(
            video5.Authors[0],
            new List<Comment>
            {
                new Comment { Author = video5.Authors[0], Text = "I loved." },
                new Comment { Author = video5.Authors[0], Text = "I have a couple questions. Can you share your e-mail?" },
            });
            
            video5.Comments.Add(
            video5.Authors[1],
            new List<Comment>
                {
                    new Comment { Author = video5.Authors[0], Text = "I have a couple questions. Can you share your e-mail?" },
                });

            video5.Comments.Add(
            video5.Authors[2],
            new List<Comment>
                {
                    new Comment { Author = video5.Authors[0], Text = "Thank you for this content!" },
                });

        videos.Add(video5);
    
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
