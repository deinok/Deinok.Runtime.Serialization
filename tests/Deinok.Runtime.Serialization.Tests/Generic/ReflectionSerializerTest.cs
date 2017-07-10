using System;
using Deinok.Runtime.Serialization.Generic;
using Xunit;

namespace Deinok.Runtime.Serialization.Tests.Generic {

	public class ReflectionSerializerTest{

		private readonly Random random = new Random();
		private readonly ReflectionSerializer serializer = new ReflectionSerializer();

		[Fact]
		public void SerializeStringTest() {
			var result=serializer.Serialize(random.NextStringAscii(10));
		}

		[Fact]
		public void SerializeIntegerTest() {
			var result = serializer.Serialize(random.Next());
		}

	}

}
