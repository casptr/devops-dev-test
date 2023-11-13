﻿using Domain.Formulas;
using Fakers.Common;

namespace Fakers.Formulas;

public class FormulaFaker : EntityFaker<Formula>
{
    private static int id = 100;
    public FormulaFaker(string locale = "nl") : base(locale)
    {
        CustomInstantiator(f => new Formula(new FoodtruckFaker(), f.Commerce.ProductName(), f.Commerce.ProductDescription(), new Uri(f.Image.PicsumUrl()))).RuleFor(f => f.Id, s => id++);
    }
}
