namespace LibBase.Entity{
	/// <summary>
	/// Реквизиты предприятия
	/// </summary>
	public interface ICompanyRequisites : IBaseNameable {
		/// <summary>
		/// ООФ
		/// </summary>
		string Type { get; set; }
		int Inn { get; set; }
		int Kpp { get; set; }
		int Ogrn { get; set; }
		int Rs { get; set; }
		int Ks { get; set; }
		string BankName { get; set; }
		string LegalAddress { get; set; }
		string FactAddress { get; set; }
		string CeoName { get; set; }
	}
}