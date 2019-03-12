
using System;

namespace LibBase.Entity {
	public interface IBaseDateable {
		/// <summary>
		/// Дата создания
		/// </summary>
		DateTime CreatedOn { get; set; }
		/// <summary>
		/// Дата модификации
		/// </summary>
		DateTime UpdatedOn { get; set; }
	}
}
