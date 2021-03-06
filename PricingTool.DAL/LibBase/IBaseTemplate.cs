﻿namespace LibBase.Entity {
	/// <summary>
	/// Шаблон
	/// </summary>
	public interface IBaseTemplate {
		/// <summary>
		/// Тело
		/// </summary>
		string Body { get; set; }
		/// <summary>
		/// Заголовок
		/// </summary>
		string Title { get; set; }
		/// <summary>
		/// Рендер шаблона
		/// </summary>
		string Render { get; set; }
	}
}