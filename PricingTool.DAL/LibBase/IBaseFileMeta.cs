namespace LibBase.Entity{
	/// <summary>
	/// Метаданные файла
	/// </summary>
	public interface IBaseFileMeta {
		string FileName { get; set; }
		string FileExtension { get; set; }
		long FileLength { get; set; }
		string FileMime { get; set; }
	}
}