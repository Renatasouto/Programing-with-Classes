public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = default;
    public int _endYear = default;

    public Job()
    {
    }

    public void DisplayJobDetails()
    {
       Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}


