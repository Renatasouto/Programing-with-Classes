class Video
{
    public string Title { get; set; }
    public string VideoAuthor {get; set;}
    public int Length { get; set; }
    public Dictionary<Author, List<Comment>> Comments { get; set; }

    public int GetNumberOfComments()
    {
        int count = 0;
        foreach (var commentsList in Comments.Values)
        {
            count += commentsList.Count;
        }
        return count;
    }
}