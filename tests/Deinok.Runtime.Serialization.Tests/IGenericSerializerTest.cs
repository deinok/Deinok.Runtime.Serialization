using Xunit;

namespace Deinok.Runtime.Serialization.Tests {

    public class IGenericSerializerTest{

        private readonly IGenericSerializer<string> serializer = new SerializerMock();
        private readonly string serialized = "1";
        private readonly int deserialized = 1;

        [Fact]
        public void SerializeTest() {
            Assert.Equal(
                this.serialized, 
                this.serializer.Serialize(this.deserialized)
            );
        }

        [Fact]
        public async void SerializeAsyncTest() {
            Assert.Equal(
                this.serialized,
                await this.serializer.SerializeAsync(this.deserialized).ConfigureAwait(false)
            );
        }

        [Fact]
        public void DeserializeTest() {
            Assert.Equal(
                this.deserialized, 
                this.serializer.Deserialize<int>(this.serialized)
            );
        }

        [Fact]
        public async void DeserializeAsyncTest() {
            Assert.Equal(
                this.deserialized,
                await this.serializer.DeserializeAsync<string,int>(this.serialized).ConfigureAwait(true)
            );
        }

        private class SerializerMock: IGenericSerializer<string> {

            public string Serialize<TInput>(TInput input) {
                return input.ToString();
            }

            public TOutput Deserialize<TOutput>(string input){
                return int.Parse(input) as dynamic;
            }

        }

    }

}
