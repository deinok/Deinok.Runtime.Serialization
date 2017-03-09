using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class IDeserializerTest {

		[Fact]
		public void DeserializerDeserializeTest(){
			IDeserializer<string, string> deserializer = new DeserializerMock();
			Assert.Equal("", deserializer.Deserialize("anyThing"));
		}

		[Fact]
		public async void DeserializerDeserializeAsyncTest(){
			IDeserializer<string, string> deserializer = new DeserializerMock();
			Assert.Equal("", await deserializer.DeserializeAsync("anyThing"));
		}

		private class DeserializerMock : IDeserializer<string, string>{

			public string Deserialize(string input){
				return "";
			}

		}

	}

}
