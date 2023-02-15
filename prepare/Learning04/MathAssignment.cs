
// create sub class to Assignment
public class MathAssignment : Assignment
{
    private string _section;
    private string _problem;

    // create constructor that calls base class and sets attributes

    public MathAssignment(string studentName, string topic, string section, string problem)
        :base (studentName,topic)
    {
        _section = section;
        _problem = problem;
    }
// Method for Get Homeworklist
    public string GetHomeworkList()
       {
        return _section + " and  " + _problem;
       }

}