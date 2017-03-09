using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class BaseSerializerTest {

		private SerializerMock serializer = new SerializerMock();

		[Fact]
		public void SerializeTest(){
			Assert.Equal("any-thing", this.serializer.Serialize("any:thing"));
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

		private class SerializerMock : BaseSerializer<string, string>{

			public override string Serialize(string input){
				return input.Replace(':', '-');
			}

			public override string Deserialize(string input){
				return input.Replace('-', ':');
			}

		}

	}

}
