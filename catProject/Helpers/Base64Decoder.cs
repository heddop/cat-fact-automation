using System;
using System.Text;

namespace catProject.Helpers
{
	public class Base64Decoder
	{
		public string DecodeBase64String(string encodedString)
		{
			byte[] data = Convert.FromBase64String(encodedString);
			string decodedString = Encoding.UTF8.GetString(data);
			return decodedString;
		}
	}
}
