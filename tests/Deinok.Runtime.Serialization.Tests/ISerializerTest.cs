using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class ISerializerTest {

        [Fact]
        public void SerializerSerializeTest() {
			ISerializer<string,string> serializer = new SerializerMock();
			Assert.Equal("", serializer.Serialize("anyThing"));
        }

		[Fact]
		public async void SerializerSerializeAsyncTest(){
			ISerializer<string, string> serializer = new SerializerMock();
			Assert.Equal("", await serializer.SerializeAsync("anyThing"));
		}

		private class SerializerMock : ISerializer<string, string>{

			public string Serialize(string input){
				return "";
			}

		}

    }

}
