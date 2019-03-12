using System;

namespace LibBase.Entity{
	public interface IBaseDateRange {
		DateTime DateFrom { get; set; }
		DateTime DateTo { get; set; }
	}
}