using System;

namespace Deinok.Runtime.Serialization.Base64{

	/// <summary>
	/// Serialize a byte[] to string
	/// </summary>
	public class Base64Serializer : BaseSerializer<byte[], string> {

		/// <summary>
		/// Serialize byte[] to string
		/// </summary>
		/// <param name="input">The byte[]</param>
		/// <returns>The Base64 string</returns>
		public override string Serialize(byte[] input) {
			return Convert.ToBase64String(input);
		}

		/// <summary>
		/// Deserialize a Base64 string
		/// </summary>
		/// <param name="input">The Base64 string</param>
		/// <returns>The byte[]</returns>
		public override byte[] Deserialize(string input) {
			return Convert.FromBase64String(input);
		}

	}

}
