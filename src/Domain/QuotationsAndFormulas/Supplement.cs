﻿using Ardalis.GuardClauses;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.QuotationsAndFormulas
{
	public class Supplement : Entity
	{
		private string name = default!;
		public string Name
		{
			get => name;
			set => name = Guard.Against.NullOrWhiteSpace(value, nameof(Name));
		}

		private string description = default!;
		public string Description
		{
			get => description;
			set => description = Guard.Against.NullOrWhiteSpace(value, nameof(Description));
		}

		private string category = default!;
		public string Category
		{
			get => category;
			set => category = Guard.Against.NullOrWhiteSpace(value, nameof(Category));
		}

		private Money price = default!;
		public Money Price
		{
			get => price;
			set => price = Guard.Against.Null(value, nameof(Price));
		}

		private readonly List<string> imageUrls = new();
		public IReadOnlyCollection<string> ImageUrls => imageUrls.AsReadOnly();

		private int amountAvailable = default!;
		public int AmountAvailable
		{
			get => amountAvailable;
			set => amountAvailable = Guard.Against.Negative(value, nameof(AmountAvailable));
		}

		private Supplement() { }

		public Supplement(string name, string description, string category, Money price, int amountAvailable)
		{
			Name = name;
			Description = description;
			Category = category;
			Price = price;
			AmountAvailable = amountAvailable;
		}

		public void AddImageUrl(string imageUrl)
		{
			Guard.Against.NullOrEmpty(imageUrl, nameof(imageUrl));
			if(imageUrls.Contains(imageUrl))
			{
				throw new ApplicationException($"{nameof(Supplement)} '{name}' already contains the imageUrl:{imageUrl}");
			}
			imageUrls.Add(imageUrl);
		}

	}
}
