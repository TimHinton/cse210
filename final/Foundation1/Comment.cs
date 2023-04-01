public class Comment
{
    private string _commentAuthor;
    private string _commentText;

    public Comment()
    {
    }


    public void SetCommenter(string commentAuthor)
    {
        _commentAuthor = commentAuthor;
    }

    public void SetCommentText(string text)
    {
        _commentText = text;
    }

    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

}