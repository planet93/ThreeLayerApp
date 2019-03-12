using System;

namespace LibBase.Entity.Common {
	public struct DateRangeStruct {
		public DateRangeStruct(DateTime start) : this() {
			Start = start;
		}
		private DateTime Start { get; }
		public DateTime End => Start.AddDays(6);
	}
}
