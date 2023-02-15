public class Assignment
{
// Set attributes
    protected string _studentName;
    private string _topic;

// class contstructor takes in and sets
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
// method for GetSummary
    public string GetSummary()
    {
        return _studentName + " , " + _topic;
    }
}


    
