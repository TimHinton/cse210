public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _commentList;

    public Video()
    {
        _commentList = new List<Comment>();
    }


    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public void SetLength(string length)
    {
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _commentList.Count();
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title} by {_author}, {_length}.");
        Console.WriteLine(GetNumberOfComments() + "comments.");
        Console.WriteLine("");

        foreach (Comment comment in _commentList)
        {
            Console.WriteLine(GetCommentAuthor + ":" + GetCommentText() + "\n");
        }
    }

}