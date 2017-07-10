using System;
using Deinok.Runtime.Serialization.Generic;
using Xunit;

namespace Deinok.Runtime.Serialization.Tests.Generic {

	public class SerializedMemberTest{

		[Fact]
		public void SerializedStringMember(){
			var member = new SerializedStringMember{
				Name = "theStringName",
				Value = "theStringValue"
			};

			Assert.NotNull(member.Name);
			Assert.IsType<string>(member.Value);
			Assert.Equal(SerializedType.String, member.Type);
		}

		[Fact]
		public void SerializedIntegerMember(){
			var member = new SerializedIntegerMember{
				Name="theIntegerName",
				Value = 50
			};

			Assert.NotNull(member.Name);
			Assert.IsType<int>(member.Value);
			Assert.Equal(SerializedType.Integer, member.Type);
		}

		[Fact]
		public void SerializedFloatMember(){
			var member = new SerializedFloatMember{
				Name="theFloatName",
				Value = 50
			};

			Assert.NotNull(member.Name);
			Assert.IsType<float>(member.Value);
			Assert.Equal(SerializedType.Float, member.Type);
		}

		[Fact]
		public void SerializedBoolMember(){
			var member = new SerializedBoolMember{
				Name="theBoolName",
				Value = true
			};

			Assert.NotNull(member.Name);
			Assert.IsType<bool>(member.Value);
			Assert.Equal(SerializedType.Bool, member.Type);
		}

		[Fact]
		public void SerializedEnumMember(){
			var member = new SerializedEnumMember{
				Name="theEnumName",
				Value = TestEnum.Value1
			};

			Assert.NotNull(member.Name);
			Assert.IsAssignableFrom<Enum>(member.Value);
			Assert.Equal(SerializedType.Enum, member.Type);
		}

		[Fact]
		public void SerializedObjectMember(){
			var member = new SerializedObjectMember{
				Name="theObjectName",
				Value = new TestObject{
					A = "ValueA",
					B = 50,
					C = true
				}
			};

			Assert.NotNull(member.Name);
			Assert.IsAssignableFrom<Object>(member.Value);
			Assert.Equal(SerializedType.Object, member.Type);
		}

		[Fact]
		public void SerializedArrayMember(){
			var member = new SerializedArrayMember{
				Name="theArrayName",
				Value = new TestObject[] { new TestObject { A = "valueA", B = 50, C = true } }
			};

			Assert.NotNull(member.Name);
			Assert.IsAssignableFrom<Array>(member.Value);
			Assert.Equal(SerializedType.Array, member.Type);
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
