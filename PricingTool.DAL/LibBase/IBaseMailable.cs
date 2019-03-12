namespace LibBase.Entity{
	public interface IBaseMailable {
		string Subject { get; set; }
		string Body { get; set; }
	}
}