namespace Deinok.Runtime.Serialization.Generic {

	public abstract class SerializedMember{

		public string Name { get; set; }
		public abstract SerializedType Type { get; }

	}

}
