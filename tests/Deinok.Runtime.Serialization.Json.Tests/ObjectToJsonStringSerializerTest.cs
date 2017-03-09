using Xunit;

namespace Deinok.Runtime.Serialization.Json.Tests{

	public class ObjectToJsonStringSerializerTest{

		private readonly MockObject mockObject = new MockObject { Integer = 5, String = "anyString" };
		private readonly string jsonString = "{\"Integer\":5,\"String\":\"anyString\"}";
		private readonly ObjectToJsonStringSerializer serializer = new ObjectToJsonStringSerializer();

		[Fact]
		public void SerializeTest(){
			Assert.Equal(this.jsonString, this.serializer.Serialize(this.mockObject));
		}

		[Fact]
		public async void SerializeAsyncTest(){
			Assert.Equal(this.jsonString, await this.serializer.SerializeAsync(this.mockObject));
		}


		[Fact]
		public void DeserializeTest(){
			Assert.Equal(this.mockObject,(MockObject) this.serializer.Deserialize(this.jsonString));
		}

		[Fact]
		public async void DeserializeAsyncTest(){
			Assert.Equal(this.mockObject,(MockObject) await this.serializer.DeserializeAsync(this.jsonString));
		}

		private class MockObject{
			public int Integer { get; set; }
			public string String { get; set; }
		}

	}

}

