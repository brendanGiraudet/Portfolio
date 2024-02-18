namespace Portfolio.App.Models;

public class Experience
{
    public string Title { get; set; }
    
    public string Date { get; set; }

    public IEnumerable<ExperienceDetail> ExperienceDetails { get; set; }
}