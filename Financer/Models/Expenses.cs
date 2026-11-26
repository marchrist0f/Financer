namespace Financer.Models;

public class Expenses
{
    public int Id {get; set;}
    
    public int UserId {get; set;}

    public string Title {get; set;}="";

    public decimal Amount {get; set;}

    public string Category {get; set;}="";

    public DateTime ExpenseDate {get; set;}

    public DateTime CreatedAt {get; set;}= DateTime.UtcNow;

    public string PaymentMethod {get; set;}="";

    public User User {get; set;}=null; //FK Relationship
}