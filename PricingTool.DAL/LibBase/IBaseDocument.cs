namespace LibBase.Entity{
	public interface IBaseDocument {
		string NumberPrefix { get; set; }
		string NumberRoot { get; set; }
		string NumberSuffix { get; set; }
		string NumberPostfix { get; set; }
	}
}