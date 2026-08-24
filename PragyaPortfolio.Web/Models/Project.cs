namespace PragyaPortfolio.Web.Models;
public class Project
{
    public int Id {get; set;}
    public string Name {get;set;} = "";
    public string Description {get;set;}="";
    public List<string> Technologies {get;set;} = new List<string>();
    public string GithubLink {get;set;} = "";
    public string LiveDemoLink {get;set;} = "";
}