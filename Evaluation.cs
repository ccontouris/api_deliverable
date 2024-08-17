using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

public class Evaluation
{
    public int EvaluationId { get; set; }
    public int EmployeeId { get; set; }
    public int ManagerId { get; set; }  
    public int EvaluationTotal { get; set; }    
    public int TeamworkTotal { get; set; }
    public int BestPracticesTotal { get; set; }
    public int CodeAstheticsTotal { get; set; }
    public int KnowledgeProblemSolvingTotal { get; set; }   
    public int CommunicationTotal { get; set; }
    public string SelfEvaluation { get; set; } = string.Empty;
    public int ExpectedEvaluationTotal { get; set; }
    public bool IsAdmin { get; set; }
    public List<Comments> Comments { get; set; } = new List<Comments>();
    public DateTime CreatedOn { get; set; } = DateTime.Now;             
}