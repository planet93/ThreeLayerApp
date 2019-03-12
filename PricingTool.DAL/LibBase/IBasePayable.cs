using System;

namespace LibBase.Entity{
	public interface IBasePayable : IBaseCostable {
		DateTime PaidOn { get; set; }
	}
}