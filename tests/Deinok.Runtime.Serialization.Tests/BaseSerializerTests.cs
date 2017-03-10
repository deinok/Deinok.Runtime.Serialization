using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class BaseSerializerTest {

		private readonly SerializerMock serializer = new SerializerMock();
		private readonly string serializedString = "any:thing";
		private readonly string deserializedString = "any-thing";

		[Fact]
		public void SerializeTest(){
			Assert.Equal(this.serializedString, this.serializer.Serialize(this.deserializedString));
		}

		[Fact]
		public async void SerializeAsyncTest(){
			Assert.Equal(this.serializedString, await this.serializer.SerializeAsync(this.deserializedString));
		}


		[Fact]
		public void DeserializeTest(){
			Assert.Equal(this.deserializedString, this.serializer.Deserialize(this.serializedString));
		}

		[Fact]
		public async void DeserializeAsyncTest(){
			Assert.Equal(this.deserializedString, await this.serializer.DeserializeAsync(this.serializedString));
		}

		private class SerializerMock : BaseSerializer<string, string>{

			public override string Serialize(string input){
				return input.Replace('-', ':');
			}

			public override string Deserialize(string input){
				return input.Replace(':', '-');
			}

		}

	}

}
