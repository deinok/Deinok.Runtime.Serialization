namespace Deinok.Runtime.Serialization.Generic {

	/// <summary>
	/// Base Generic Serializer for Everything
	/// </summary>
	/// <typeparam name="TOutput">The Output Type of the Serialization</typeparam>
	public abstract class BaseGenericSerializer<TOutput> : IGenericSerializer<TOutput> {

		/// <summary>
		/// Serialize a TInput to a TOutput
		/// </summary>
		/// <typeparam name="TInput">The Input Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public abstract TOutput Serialize<TInput>(TInput input);

		/// <summary>
		/// Deserialize a TOutput to a TInput
		/// </summary>
		/// <typeparam name="TInput">The Input Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public abstract TInput Deserialize<TInput>(TOutput input);

	}

}
