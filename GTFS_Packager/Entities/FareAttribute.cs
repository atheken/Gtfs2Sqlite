using System;
using ServiceStack.DataAnnotations;

namespace GTFSPackager.Entities
{
	public class FareAttribute
	{
		[AutoIncrement]
		public int Id { get; set; }

		public string currency_type{ get; set; }
		public string fare_id{ get; set; }
		public string payment_method{ get; set; }
		public string price{ get; set; }
		public string transfer_duration{ get; set; }
		public string transfers{ get; set; }
	}
}

