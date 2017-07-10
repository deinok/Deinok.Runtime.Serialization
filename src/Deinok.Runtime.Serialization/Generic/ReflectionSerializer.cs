using System;
using System.Reflection;

namespace Deinok.Runtime.Serialization.Generic {

	public class ReflectionSerializer : IGenericSerializer<SerializedMember<object>> {

		public SerializedMember<object> Serialize<TComplex>(TComplex input){
			Type type = typeof(TComplex);

			if (type == typeof(string)) {
				var value = type.GetRuntimeProperty("Chars").GetValue(input);
				var str= new SerializedStringMember() { Value =(string) value };
				return null;
			} else if (type == typeof(int)) {
				var value = type.GetRuntimeField("m_value").GetValue(input);
				var str = new SerializedIntegerMember() { Value = (int)value };
				return null;
			}
			throw new NotImplementedException();
		}

		public TComplex Deserialize<TComplex>(SerializedMember<object> input){
			throw new NotImplementedException();
		}

	}

}
