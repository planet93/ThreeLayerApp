using System;

namespace LibBase.Entity{
	public interface IBaseCreatedOn {
		/// <summary>
		/// Дата создания
		/// </summary>
		DateTime CreatedOn { get; set; }
	}
}
