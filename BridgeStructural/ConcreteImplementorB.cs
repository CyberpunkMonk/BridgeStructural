using System;

namespace BridgeStructural {
	/// <summary>
	/// The 'ConcreteImplementorB' class
	/// </summary>
	/// <seealso cref="BridgeStructural.Implementor" />
	class ConcreteImplementorB : Implementor {
		public override void Operation() {
			Console.WriteLine("ConcreteImplementorB Operation");
		}
	}
}