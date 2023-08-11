namespace V.Ods.Abstractions.Models;

public class JobModel
{
    public List<string> InitParams{get;set;}

    public int Type{get;set;}

    public string Name{get;set;}

    public DateTime BeginTime{get;set;}

    public DateTime EndTime{get;set;}

    
}