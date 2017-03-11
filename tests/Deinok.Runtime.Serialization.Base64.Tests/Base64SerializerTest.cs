using System;
using Xunit;

namespace Deinok.Runtime.Serialization.Base64.Tests{

    public class Base64SerializerTest{

		private readonly Base64Serializer serializer = new Base64Serializer();
		private readonly string base64String="KAAAABBJbnRlZ2VyAAUAAAACU3RyaW5nAAoAAABhbnlTdHJpbmcAAA==";
		private readonly byte[] bytes = Convert.FromBase64String("KAAAABBJbnRlZ2VyAAUAAAACU3RyaW5nAAoAAABhbnlTdHJpbmcAAA==");

		[Fact]
		public void SerializeTest() {
			Assert.Equal(this.base64String, this.serializer.Serialize(this.bytes));
		}

		[Fact]
		public async void SerializeAsyncTest() {
			Assert.Equal(this.base64String, await this.serializer.SerializeAsync(this.bytes));
		}


		[Fact]
		public void DeserializeTest() {
			Assert.Equal(this.bytes, this.serializer.Deserialize(this.base64String));
		}

		[Fact]
		public async void DeserializeAsyncTest() {
			Assert.Equal(this.bytes, await this.serializer.DeserializeAsync(this.base64String));
		}

	}

}
