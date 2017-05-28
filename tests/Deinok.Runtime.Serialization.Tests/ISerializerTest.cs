using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

	public class ISerializerTest {

		private readonly ISerializer<int, string> serializer = new IntToStringSerializer();
		private readonly string serialized = "123456789";
		private readonly int deserialized = 123456789;

		[Fact]
        public void SerializeTest() {
			Assert.Equal(
                this.serialized, 
                this.serializer.Serialize(this.deserialized)
            );
        }

		[Fact]
		public async void SerializeAsyncTest(){
			Assert.Equal(
                this.serialized, 
                await this.serializer.SerializeAsync(this.deserialized).ConfigureAwait(false)
            );
		}

        [Fact]
        public void DeserializeTest() {
            Assert.Equal(
                this.deserialized, 
                this.serializer.Deserialize(this.serialized)
            );
        }

        [Fact]
        public async void DeserializeAsyncTest() {
            Assert.Equal(
                this.deserialized, 
                await this.serializer.DeserializeAsync(this.serialized).ConfigureAwait(false)
            );
        }

        private class IntToStringSerializer : ISerializer<int, string>{

			public string Serialize(int input){
				return input.ToString();
			}

            public int Deserialize(string input) {
                return int.Parse(input);
            }

        }

    }

}
