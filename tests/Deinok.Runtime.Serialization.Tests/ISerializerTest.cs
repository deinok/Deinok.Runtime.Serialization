using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class ISerializerTest{

        [Fact]
        public void SerializerTest() {
			SerializerMock serializer = new SerializerMock();
			Assert.Equal("", serializer.Serialize("anyThing"));
        }

		private class SerializerMock : ISerializer<string, string>{

			public string Serialize(string input){
				return "";
			}

		}

    }

}
