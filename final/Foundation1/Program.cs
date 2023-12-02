using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int _commentNumber;

        Video v1 = new Video("Unboxing a Ganondorf Figurine!", "UnboxersRUs", 1);
        Comment c1 = new Comment("John", "This video sucks!");
        v1.StoreComments(c1);
        Comment c2 = new Comment("Selene", "That figurine looks sick.");
        v1.StoreComments(c2);
        Comment c3 = new Comment("Dan", "This video is the best on the internet!");
        v1.StoreComments(c3);
        
        Video v2 = new Video("Celeste Part 1", "Drakooryx", 20);
        c1 = new Comment("Sam", "I like the voice acting.");
        v2.StoreComments(c1);
        c2 = new Comment("Madeline", "I know this guy!");
        v2.StoreComments(c2);
        c3 = new Comment("Don", "It's funny.");
        v2.StoreComments(c3);
        Comment c4 = new Comment("Roon", "Just another person trying to get views.");
        v2.StoreComments(c4);

        Video v3 = new Video("Reacting to Chaos", "ReactingToAll", 10);
        Console.WriteLine();
        c1 = new Comment("Sun", "Who is this guy?");
        v3.StoreComments(c1);
        c2 = new Comment("Tad", "This is a strange video.");
        v3.StoreComments(c2);
        c3 = new Comment("Alex", "I love this.");
        v3.StoreComments(c3);

        Console.WriteLine($"{v1._title} by {v1._author}, length: {v1._length} minutes");
        Console.WriteLine();
        foreach(Comment item in v1._comments)
        {
            item.Display();
        }
        _commentNumber = v1.ReturnCommentNumber();
        Console.WriteLine($"Number of comments: {_commentNumber}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"{v2._title} by {v2._author}, length: {v2._length} minutes");
        Console.WriteLine();
        foreach(Comment item in v2._comments)
        {
            item.Display();
        }
        _commentNumber = v2.ReturnCommentNumber();
        Console.WriteLine($"Number of comments: {_commentNumber}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"{v3._title} by {v3._author}, length: {v3._length} minutes");
        Console.WriteLine();
        foreach(Comment item in v3._comments)
        {
            item.Display();
        }
        _commentNumber = v3.ReturnCommentNumber();
        Console.WriteLine($"Number of comments: {_commentNumber}");
    }
}