using System.Collections.Generic;

namespace LibBase.Entity.Common {
	public class ViewMessage : BaseMessage {
		/// <summary>
		/// Опциональный клиентский скрипт
		/// </summary>
		public string ExecutingJscript { get; set; }
		public string MessageType { get; set; }
		public bool DisableLayout { get; set; }

		public string BackUrl { get; set; } = "/";

		/// <summary>
		/// Кнопки
		/// </summary>
		public List<Button> Buttons { get; set; }
	}
}
