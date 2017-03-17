using System;
using Xunit;

namespace Deinok.Runtime.Serialization.Bson.Tests{

	public class JsonStringSerializerTest{

		private readonly BsonBytesSerializer serializer = new BsonBytesSerializer();
		private readonly MockObject mockObject = new MockObject { Integer = 5, String = "anyString" };
		private readonly byte[] bsonBytes = Convert.FromBase64String("KAAAABBJbnRlZ2VyAAUAAAACU3RyaW5nAAoAAABhbnlTdHJpbmcAAA==");

		[Fact]
		public void SerializeTest(){
			Assert.Equal(this.bsonBytes, this.serializer.Serialize(this.mockObject));
		}


		[Fact]
		public void DeserializeTest(){
			Assert.Equal(this.mockObject, this.serializer.Deserialize<MockObject>(this.bsonBytes));
		}

		private class MockObject{
			public int Integer { get; set; }
			public string String { get; set; }

			public override bool Equals(object obj){
				if (obj == null || GetType() != obj.GetType()){
					return false;
				}

				var that = (MockObject)obj;

				if (this.Integer != that.Integer){
					return false;
				}
				if (this.String != that.String){
					return false;
				}
				return true;
			}

			public override int GetHashCode() {
				return base.GetHashCode();
			}
		}

	}

}
