namespace LibBase.Entity{
	public interface IBaseLegalDetail {
		string LegalName { get; set; }
		string LegalType { get; set; }
		string LegalAddress { get; set; }
		string PostalAddress { get; set; }
		int Inn { get; set; }
		int Kpp { get; set; }
		string BankName { get; set; }
		int BankKs { get; set; }
		int BankRs { get; set; }
	}
}