﻿using Ardalis.GuardClauses;
using Domain.Common;

namespace Domain.Quotations
{

	public class Reservation : Entity
	{
		private DateTime start = default!;
		public DateTime Start { get => start; set => start = Guard.Against.OutOfRange(value, nameof(Start), DateTime.Now.AddDays(1), DateTime.Now.AddYears(5)); } // TODO

		private DateTime end = default!;
		public DateTime End { get => end; set => end = Guard.Against.OutOfRange(value, nameof(End), DateTime.Now.AddDays(1), DateTime.Now.AddYears(5)); } // TODO

		private string description = default!;
		public string Description { get => description; set => description = Guard.Against.NullOrEmpty(value, nameof(Description)); }

		private Status status = default!;
		public Status Status { get => status; set => status = Guard.Against.Null(value, nameof(Status)); }

		/// <summary>
		/// Database Constructor
		/// </summary>
		private Reservation() { }

		public Reservation(DateTime start, DateTime end, string description, Status status = Status.VOORGESTELD)
		{
			Start = start;
			End = end;
			Description = description;
			Status = status;
		}
	}
	//TODO define the possible statusses
	public enum Status
	{
		VOORGESTELD,
		BEVESTIGD,
		BETAALD
	}
}
