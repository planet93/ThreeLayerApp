
namespace LibBase.Entity.Common {
	public class ResponseMessage : BaseMessage {
		public int ResponseCode { get; set; }
		public string Description { get; set; }
		public object Object { get; set; }
		public string RedirectPath { get; set; }
	}
}
