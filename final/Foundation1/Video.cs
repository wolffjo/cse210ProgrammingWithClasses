public class Video
{
    public string _title;
    public string _author;
    public int _length;
    int _videoComments;
    //int _overallComments;
    public List<Comment> _comments = new List<Comment>();
    
    public void StoreComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int ReturnCommentNumber()
    {
        foreach(Comment item in _comments)
        {
            _videoComments += 1;
        }
        return _videoComments;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
}