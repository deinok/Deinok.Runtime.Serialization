namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Base Serializer for Everything
	/// </summary>
	/// <typeparam name="TInput">The Deserialized Type</typeparam>
	/// <typeparam name="TOutput">The Serialized Type</typeparam>
	public abstract class BaseSerializer<TInput, TOutput> : ISerializer<TInput, TOutput> {

		/// <summary>
		/// Serialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public abstract TOutput Serialize(TInput input);

		/// <summary>
		/// Deserialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		public abstract TInput Deserialize(TOutput input);

	}

}
