using Xunit;

namespace Deinok.Runtime.Serialization.Json.Tests{

	public class JsonStringSerializerTest{

		private readonly JsonStringSerializer serializer = new JsonStringSerializer();
		private readonly MockObject mockObject = new MockObject { Integer = 5, String = "anyString" };
		private readonly string jsonString = "{\"Integer\":5,\"String\":\"anyString\"}";

		[Fact]
		public void SerializeTest(){
			var a=new JsonStringSerializer().Serialize<int>(4);
			Assert.Equal(this.jsonString, this.serializer.Serialize(this.mockObject));
		}


		[Fact]
		public void DeserializeTest(){
			Assert.Equal(this.mockObject, this.serializer.Deserialize<MockObject>(this.jsonString));
		}

		private class MockObject{
			public int Integer { get; set; }
			public string String { get; set; }

			public override bool Equals(object obj) {
				if (obj == null || GetType() != obj.GetType()) {
					return false;
				}

				var that = (MockObject) obj;

				if (this.Integer != that.Integer) {
					return false;
				}
				if (this.String != that.String) {
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
