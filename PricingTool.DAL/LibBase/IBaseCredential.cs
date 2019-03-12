
namespace LibBase.Entity {
	/// <summary>
	/// Учетные данные отправки
	/// </summary>
	public interface IBaseCredential : IBaseCredentialPrimitive {
		/// <summary>
		/// Имя
		/// </summary>
		string FullName { get; set; }
		/// <summary>
		/// Server
		/// </summary>
		string Server { get; set; }
		/// <summary>
		/// Адрес электронной почты
		/// </summary>
		string Email { get; set; }
		/// <summary>
		/// Port
		/// </summary>
		int Port { get; set; }
	}
}
