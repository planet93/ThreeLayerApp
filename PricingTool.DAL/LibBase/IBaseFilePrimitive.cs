namespace LibBase.Entity{
	/// <summary>
	/// Файл
	/// </summary>
	public interface IBaseFilePrimitive {

		/// <summary>
		/// Имя файла
		/// </summary>
		string FileName { get; set; }
		/// <summary>
		/// Размер загруженного файла
		/// </summary>
		long FileLength { get; set; }
	}
}