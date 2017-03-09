using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization{

    public static class ISerializerExtension{

		public static async Task<TOutput> SerializeAsync<TInput,TOutput>(this ISerializer<TInput,TOutput> serializer, TInput input){
			return await Task.Run<TOutput>(()=> serializer.Serialize(input));
		}
		
    }

}
