using System.Data;
using Domain.Quotations;
using FluentValidation;
using Foodtruck.Shared.Customers;

namespace Foodtruck.Shared.Quotations;

public abstract class QuotationDto{

    public class Create
    {
        public CustomerDto.Create Customer { get; set; } = new();
        public QuotationVersionDto.Create QuotationVersion { get; set; } = new();

        public class Validator : AbstractValidator<Create>
        {
            public Validator(){
                RuleFor(q => q.QuotationVersion).NotNull();
            }
        }
    }
}