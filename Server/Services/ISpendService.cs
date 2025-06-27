using Server.Model;

namespace Server.Services;

public interface ISpendService
{
	public bool AddSpend(Spend spendToAdd);
	public List<Spend> GetAllSpend();
}