﻿using Domain.Quotations;
using Foodtruck.Shared.Customers;
using Foodtruck.Shared.Formulas;
using Foodtruck.Shared.Reservations;
using Foodtruck.Shared.Supplements;

namespace Foodtruck.Shared.Quotations
{
    public abstract class QuotationVersionDto
    {
        public class Index // TODO what is needed in index
        {
            public int Id { get; set; }
            public int VersionNumber { get; set; }
            public int NumberOfGuests { get; set; }
            public string? ExtraInfo { get; set; }
            public string? Description { get; set; }
            public ReservationDto.Detail? Reservation { get; set; }
            public FormulaDto.Index? Formula { get; set; }
            public AddressDto? EventAddress { get; set; }
            public AddressDto? BillingAddress { get; set; }

            public decimal FoodtruckPrice { get; set; }
            public decimal Price { get; set; }
            public decimal VatTotal { get; set; }
        }


        public class Detail
        {
            public int Id { get; set; }
            public int VersionNumber { get; set; }
            public int NumberOfGuests { get; set; }
            public string? ExtraInfo { get; set; }
            public string? Description { get; set; }
            public ReservationDto.Detail? Reservation { get; set; }
            public FormulaDto.Index? Formula { get; set; } // We do not need detail here?
            public AddressDto? EventAddress { get; set; }
            public AddressDto? BillingAddress { get; set; }

            public decimal FoodtruckPrice { get; set; }
            public decimal Price { get; set; }
            public decimal VatTotal { get; set; }

            public IEnumerable<QuotationSupplementLineDto>? FormulaSupplementLines { get; set; }
            public IEnumerable<QuotationSupplementLineDto>? ExtraSupplementLines { get; set; }

        }

        public class Create
        {
            public int NumberOfGuests { get; set; }
            public string? ExtraInfo { get; set; }
            public int? FormulaId { get; set; }
            public ReservationDto.Create Reservation { get; set; } = new();
            public AddressDto EventAddress { get; set; } = new();
            public AddressDto BillingAddress { get; set; } = new();
            public List<SupplementItemDto.Create> FormulaSupplementItems { get; set; } = new();
            public List<SupplementItemDto.Create> ExtraSupplementItems { get; set; } = new();
        }
    }
}
