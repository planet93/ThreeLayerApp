

namespace LibBase.Entity {
	/// <summary>
	/// Учетные данные отправки
	/// </summary>
	public interface IBaseCredentialPrimitive {
		/// <summary>
		/// Логин
		/// </summary>
		string Login { get; set; }
		/// <summary>
		/// Пароль
		/// </summary>
		string Password { get; set; }
	}
}
