using System.Collections.Generic;

namespace AFPParser.Triplets
{
	public class UP3iFinishingOperation : Triplet
	{
		private static string _desc = "";

		protected override string Description => _desc;
		protected override List<Offset> Offsets => new List<Offset>();

		public UP3iFinishingOperation(byte[] allData) : base(allData) { }
	}
}