using System;

namespace GTFS_Packager
{
	public class FareRule
	{
		public string contains_id{ get; set; }
		public string destination_id{ get; set; }
		public string fare_id{ get; set; }
		public string origin_id{ get; set; }
		public string route_id{ get; set; }
	}
}
