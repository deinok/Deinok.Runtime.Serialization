﻿using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization{

	/// <summary>
	/// Extension Methods for ISerializer
	/// </summary>
    public static class ISerializerExtension{

		/// <summary>
		/// Serializes the input async
		/// </summary>
		/// <typeparam name="TInput">The Input Type</typeparam>
		/// <typeparam name="TOutput">The Output Type</typeparam>
		/// <param name="serializer">The Serializer instance</param>
		/// <param name="input">The Input</param>
		/// <returns>The Output Task</returns>
		public static async Task<TOutput> SerializeAsync<TInput,TOutput>(this ISerializer<TInput,TOutput> serializer, TInput input){
			return await Task.Run<TOutput>(()=> serializer.Serialize(input));
		}
		
    }

}
