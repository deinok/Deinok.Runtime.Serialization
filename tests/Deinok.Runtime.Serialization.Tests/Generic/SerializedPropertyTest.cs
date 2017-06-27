using System;
using System.Collections.ObjectModel;
using Deinok.Runtime.Serialization.Generic;
using Xunit;

namespace Deinok.Runtime.Serialization.Tests.Generic {

	public class SerializedPropertyTest{

		[Fact]
		public void SerializedStringProperty(){
			SerializedStringProperty property = new SerializedStringProperty {
				Name="propertyName",
				Value="theStringValue"
			};

			Assert.IsType<string>(property.Value);
			Assert.Equal(SerializedType.String, property.Type);
		}

		[Fact]
		public void SerializedIntegerProperty(){
			SerializedIntegerProperty property = new SerializedIntegerProperty{
				Name = "propertyName",
				Value = 50
			};

			Assert.IsType<int>(property.Value);
			Assert.Equal(SerializedType.Integer, property.Type);
		}

		[Fact]
		public void SerializedFloatProperty(){
			SerializedFloatProperty property = new SerializedFloatProperty{
				Name = "propertyName",
				Value = 50
			};

			Assert.IsType<float>(property.Value);
			Assert.Equal(SerializedType.Float, property.Type);
		}

		[Fact]
		public void SerializedBoolProperty(){
			SerializedBoolProperty property = new SerializedBoolProperty{
				Name = "propertyName",
				Value = true
			};

			Assert.IsType<bool>(property.Value);
			Assert.Equal(SerializedType.Bool, property.Type);
		}

		[Fact]
		public void SerializedEnumProperty(){
			SerializedEnumProperty property = new SerializedEnumProperty{
				Name = "propertyName",
				Value = TestEnum.Value1
			};

			Assert.IsType<Enum>(property.Value);
			Assert.Equal(SerializedType.Enum, property.Type);
		}

		[Fact]
		public void SerializedObjectProperty(){
			SerializedObjectProperty property = new SerializedObjectProperty{
				Name = "propertyName",
				Value = new SerializedObject {
					SerializedStringProperties =new Collection<SerializedStringProperty>{ new SerializedStringProperty { Name = "A",  Value = "valueA" } },
					SerializedIntegerProperties = new Collection<SerializedIntegerProperty> { new SerializedIntegerProperty { Name = "B", Value = 50 } },
					SerializedBoolProperties = new Collection<SerializedBoolProperty> { new SerializedBoolProperty { Name = "C", Value = true } },
				}
			};

			Assert.IsType<SerializedObject>(property.Value);
			Assert.Equal(SerializedType.Object, property.Type);
		}

		[Fact]
		public void SerializedArrayProperty(){
			SerializedArrayProperty property = new SerializedArrayProperty{
				Name = "propertyName",
				Value = new TestObject[] { new TestObject { A = "valueA", B = 50, C = true } }
			};

			Assert.IsType<Array>(property.Value);
			Assert.Equal(SerializedType.Array, property.Type);
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
