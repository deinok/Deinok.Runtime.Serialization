using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class ISerializerTest {

		private ISerializer<string, string> serializer = new SerializerMock();

		[Fact]
        public void SerializeTest() {
			Assert.Equal("", this.serializer.Serialize("anyThing"));
        }

		[Fact]
		public async void SerializeAsyncTest(){
			Assert.Equal("", await this.serializer.SerializeAsync("anyThing"));
		}

		private class SerializerMock : ISerializer<string, string>{

			public string Serialize(string input){
				return "";
			}

		}

    }

}
