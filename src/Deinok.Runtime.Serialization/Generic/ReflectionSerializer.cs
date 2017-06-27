using System;

namespace Deinok.Runtime.Serialization.Generic {

	public class ReflectionSerializer : IGenericSerializer<object> {

		public object Serialize<TComplex>(TComplex input){
			throw new NotImplementedException();
		}

		public TComplex Deserialize<TComplex>(object input){
			throw new NotImplementedException();
		}

	}

}
