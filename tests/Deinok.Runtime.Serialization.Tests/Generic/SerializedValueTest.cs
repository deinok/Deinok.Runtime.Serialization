using System;
using System.Collections.ObjectModel;
using Deinok.Runtime.Serialization.Generic;
using Xunit;

namespace Deinok.Runtime.Serialization.Tests.Generic {

	public class SerializedValueTest{

		[Fact]
		public void SerializedStringValue(){
			var value = new SerializedStringValue{
				Value="theStringValue"
			};

			Assert.IsType<string>(value.Value);
			Assert.Equal(SerializedType.String, value.Type);
		}

		[Fact]
		public void SerializedIntegerValue(){
			var value = new SerializedIntegerValue{
				Value = 50
			};

			Assert.IsType<int>(value.Value);
			Assert.Equal(SerializedType.Integer, value.Type);
		}

		[Fact]
		public void SerializedFloatValue(){
			var value = new SerializedFloatValue{
				Value = 50
			};

			Assert.IsType<float>(value.Value);
			Assert.Equal(SerializedType.Float, value.Type);
		}

		[Fact]
		public void SerializedBoolValue(){
			var value = new SerializedBoolValue{
				Value = true
			};

			Assert.IsType<bool>(value.Value);
			Assert.Equal(SerializedType.Bool, value.Type);
		}

		[Fact]
		public void SerializedEnumValue(){
			var value = new SerializedEnumValue{
				Value = TestEnum.Value1
			};

			Assert.IsAssignableFrom<Enum>(value.Value);
			Assert.Equal(SerializedType.Enum, value.Type);
		}

		[Fact]
		public void SerializedObjectValue(){
			var value = new SerializedObjectValue{
				Value = new TestObject{
					A = "ValueA",
					B = 50,
					C = true
				}
			};

			Assert.IsAssignableFrom<Object>(value.Value);
			Assert.Equal(SerializedType.Object, value.Type);
		}

		[Fact]
		public void SerializedArrayValue(){
			var value = new SerializedArrayValue{
				Value = new TestObject[] { new TestObject { A = "valueA", B = 50, C = true } }
			};

			Assert.IsAssignableFrom<Array>(value.Value);
			Assert.Equal(SerializedType.Array, value.Type);
		}

		private enum TestEnum {
			Value1,
			Value2,
			Value3
		}

		private class TestObject {
			public string A { get; set; }
			public int B { get; set; }
			public bool C { get; set; }
		}

	}

}
