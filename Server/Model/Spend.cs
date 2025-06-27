using Server.Data.Enums;

namespace Server.Model;

public class Spend
{
    public DateTime SpendDate { get; }
    public string Location { get; }
    public double Amount { get; }
    public SpendCategory Category { get; }
    public Recurring Recurring { get; }
    public string Notes { get; }

    public Spend(DateTime spendDate, string location, double amount, SpendCategory category, Recurring recurring, string notes)
    {
        if (spendDate > DateTime.Now)
            throw new ArgumentException("SpendDate cannot be in the future");
        if (string.IsNullOrEmpty(location))
            throw new ArgumentException("Location cannot be null or empty");
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative");
        if (string.IsNullOrEmpty(notes))
            throw new ArgumentException("Notes cannot be null or empty");
        
        this.SpendDate = spendDate;
        this.Location = location;
        this.Amount = amount; 
        this.Category = category;
        this.Recurring = recurring;
        this.Notes = notes;
    }
}