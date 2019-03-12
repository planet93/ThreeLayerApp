namespace LibBase.Entity {
	/// <summary>
	/// Фундаментальная сущность
	/// </summary>
	public interface IBaseGenericEntity<T> {
		/// <summary>
		/// Идентификатор
		/// </summary>
		T Id { get; set; }
	}
}