using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class IDeserializerTest {

		private readonly IDeserializer<string, string> deserializer = new DeserializerMock();
		private readonly string serializedString = "any:thing";
		private readonly string deserializedString = "any-thing";

		[Fact]
		public void DeserializeTest(){
			Assert.Equal(this.deserializedString, this.deserializer.Deserialize(this.serializedString));
		}

		[Fact]
		public async void DeserializeAsyncTest(){
			Assert.Equal(this.deserializedString, await this.deserializer.DeserializeAsync(this.serializedString));
		}

		private class DeserializerMock : IDeserializer<string, string>{

			public string Deserialize(string input){
				return input.Replace(':','-');
			}

		}

	}

}
