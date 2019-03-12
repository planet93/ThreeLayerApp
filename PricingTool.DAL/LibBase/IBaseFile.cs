
namespace LibBase.Entity {
	/// <summary>
	/// Файл
	/// </summary>
	public interface IBaseFile : IBaseDescriptable {
		/// <summary>
		/// Имя файла
		/// </summary>
		string FileName { get; set; }
		/// <summary>
		/// Оригинальное имя файла
		/// </summary>
		string FileNameOriginal { get; set; }
		/// <summary>
		/// Размер файла
		/// </summary>
		long FileSize { get; set; }
		/// <summary>
		/// Расширение файла
		/// </summary>
		string FileExtension { get; set; }
	}
}