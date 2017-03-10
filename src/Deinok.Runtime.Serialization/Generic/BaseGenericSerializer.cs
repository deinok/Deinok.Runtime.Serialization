namespace Deinok.Runtime.Serialization.Generic {

	public abstract class BaseGenericSerializer<TOutput> : IGenericSerializer<TOutput>,IGenericDeserializer<TOutput> {


		public abstract TOutput Serialize<TInput>(TInput input);

		public abstract TInput Deserialize<TInput>(TOutput input);

	}

}
