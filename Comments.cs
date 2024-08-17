using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

public class Comments{
    public int Id { get; set; }
    public int EvaluationId { get; set; }
    public int EmployeeId { get; set; }
    public int ManagerId { get; set; }
    public bool IsAdmin { get; set; }
    public string Teamwork { get; set; }  = string.Empty;
    public string BestPractices { get; set; } = string.Empty;
    public string CodeAsthetics { get; set; } = string.Empty;
    public string KnowledgeProblemSolving { get; set; } = string.Empty;
    public string Communitcation { get; set; } = string.Empty;
    public string SelfEvaluation { get; set; } = string.Empty;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}