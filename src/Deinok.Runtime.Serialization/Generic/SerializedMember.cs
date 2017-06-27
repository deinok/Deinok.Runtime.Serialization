namespace Deinok.Runtime.Serialization.Generic {

	public interface ISerializedMember<T> where T : ISerializedValue<T> {
		string Name { get; set; }
		ISerializedValue<T> Value { get; set; }
	}
	/*
	public abstract class SerializedMember<T> : ISerializedMember<ISerializedValue<T>> {
		public string Name { get; set; }
		public ISerializedValue<T> Value { get; set; }
	}

	public abstract class SerializedStringMember:SerializedMember<string> {
		public string Name { get; set; }
		public SerializedStringValue Value { get; set; }
	}
	*/
}
