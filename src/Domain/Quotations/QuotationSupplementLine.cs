using Ardalis.GuardClauses;
using Domain.Common;
using Domain.Supplements;

namespace Domain.Quotations;

    public class QuotationSupplementLine : Entity
{
	public string Name { get; } = default!;
	public string Description { get; } = default!;
	public Category Category { get; } = default!;
	public Money Price { get; } = default!;
	public int Quantity { get; set; } = default!;
	public bool IncludedInFormula { get; } = default!;

	/// <summary>
	/// Database Constructor
	/// </summary>
	private QuotationSupplementLine() { }

	public QuotationSupplementLine(SupplementItem supplementItem, bool includedInFormula)
	{
		Guard.Against.Null(supplementItem, nameof(supplementItem));
		Supplement supplement = supplementItem.Supplement;
		Name = supplement.Name;
		Description = supplement.Description;
		Category = supplement.Category;
		Price = supplement.Price.Copy();
		Quantity = supplementItem.Quantity;

		IncludedInFormula = includedInFormula;
	}
}
