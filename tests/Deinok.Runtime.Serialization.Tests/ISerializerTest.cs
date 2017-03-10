using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class ISerializerTest {

		private readonly ISerializer<string, string> serializer = new SerializerMock();
		private readonly string serializedString = "any:thing";
		private readonly string deserializedString = "any-thing";

		[Fact]
        public void SerializeTest() {
			Assert.Equal(this.serializedString, this.serializer.Serialize(this.deserializedString));
        }

		[Fact]
		public async void SerializeAsyncTest(){
			Assert.Equal(this.serializedString, await this.serializer.SerializeAsync(this.deserializedString));
		}

		private class SerializerMock : ISerializer<string, string>{

			public string Serialize(string input){
				return input.Replace('-', ':');
			}

		}

    }

}
