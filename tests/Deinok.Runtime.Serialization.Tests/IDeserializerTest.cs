using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class IDeserializerTest {

		private IDeserializer<string, string> deserializer = new DeserializerMock();

		[Fact]
		public void DeserializeTest(){
			Assert.Equal("", this.deserializer.Deserialize("anyThing"));
		}

		[Fact]
		public async void DeserializeAsyncTest(){
			Assert.Equal("", await this.deserializer.DeserializeAsync("anyThing"));
		}

		private class DeserializerMock : IDeserializer<string, string>{

			public string Deserialize(string input){
				return "";
			}

		}

	}

}
