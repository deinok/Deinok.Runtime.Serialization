using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Deinok.Runtime.Serialization.Generic;
using Xunit;

namespace Deinok.Runtime.Serialization.Tests{

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

        [Fact(Skip = "NOT_IMPLEMENTED")]
        public async void SerializeAsyncTest() {
            throw new NotImplementedException();
        }

        [Fact]
        public void DeserializeTest() {
            Assert.Equal(
                this.deserialized, 
                this.serializer.Deserialize<int>(this.serialized)
            );
        }

        [Fact(Skip = "NOT_IMPLEMENTED")]
        public async void DeserializeAsyncTest() {
            throw new NotImplementedException();
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
