using Server.Controllers;
using Server.Model;

namespace Server.Services;

public class SpendService : ISpendService
{
    private readonly List<Spend> spends = new();
    
    public bool AddSpend(Spend spendToAdd)
    {
        this.spends.Add(spendToAdd);
        return true;
    }

    public List<Spend> GetAllSpend()
    {
        return this.spends;
    }
}