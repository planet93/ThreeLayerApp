using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using LibBase.Entity;

namespace Phoenix.Domain.Model.Base {
	/// <summary>
	/// Базовый класс для всех классов модели приложения (POCO-объекты)
	/// </summary>
	public abstract class BaseEntity : IBaseEntity {
		/// <inheritdoc />
		/// <summary>
		/// Идентификатор
		/// </summary>
		[Key]
		public virtual long Id { get; set; }
		/// <inheritdoc />
		/// <summary>
		/// Дата занесения записи
		/// </summary>
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		/// <summary>
		/// Дата модификации записи
		/// </summary>
		public DateTime UpdatedOn { get; set; } = DateTime.Now;
		/// <inheritdoc />
		/// <summary>
		/// Активен
		/// </summary>
		[DefaultValue(true)]
		public bool Active { get; set; } = true;
		/// <inheritdoc />
		/// <summary>
		/// Удален
		/// </summary>
		[DefaultValue(false)]
		public bool Deleted { get; set; }
	}
}