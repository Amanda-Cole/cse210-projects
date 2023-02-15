class WritingAssignment : Assignment
{
    private string _assignTitle;

    public WritingAssignment (string studentName,string topic,string title)
        :base (studentName,topic)
        {
        _assignTitle = title;
        }

    public string GetWritingAssignment()
    {
        
        return _assignTitle + " by " + _studentName;
    }









}