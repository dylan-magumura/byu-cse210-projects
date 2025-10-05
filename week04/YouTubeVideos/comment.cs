
class Comment
{
    public string CommenterName { get; }
    public string CommentText { get; }

    public Comment(string name, string text)
    {
        CommenterName = name;
        CommentText = text;
    }
}