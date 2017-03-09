using Xunit;

namespace Deinok.Runtime.Serialization.Json.Tests{

	public class ObjectToJsonStringSerializerTest{

		private MockObject mockObject = new MockObject { Integer = 5, String = "anyString" };
		private ObjectToJsonStringSerializer serializer = new ObjectToJsonStringSerializer();

		[Fact]
		public void SerializeTest(){
			Assert.Equal("any-thing", this.serializer.Serialize(this.mockObject));
		}

		[Fact]
		public async void SerializeAsyncTest(){
			Assert.Equal("any-thing", await this.serializer.SerializeAsync("any:thing"));
		}


		[Fact]
		public void DeserializeTest(){
			Assert.Equal("any:thing", this.serializer.Deserialize("any-thing"));
		}

		[Fact]
		public async void DeserializeAsyncTest(){
			Assert.Equal("any:thing", await this.serializer.DeserializeAsync("any-thing"));
		}

		private class MockObject{
			public int Integer { get; set; }
			public string String { get; set; }
		}

	}

}

