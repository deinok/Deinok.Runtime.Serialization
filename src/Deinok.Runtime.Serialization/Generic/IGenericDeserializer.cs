namespace Deinok.Runtime.Serialization.Generic{

	/// <summary>
	/// A Generic Deserializer
	/// </summary>
	/// <typeparam name="TInput">The Input Type</typeparam>
	public interface IGenericDeserializer<TInput>{

		/// <summary>
		/// Deserialize a TInput to a TOutput
		/// </summary>
		/// <typeparam name="TOutput">The Output Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		TOutput Deserialize<TOutput>(TInput input);

	}

}
