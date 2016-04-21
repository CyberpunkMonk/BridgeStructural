using System;

namespace BridgeStructural {
	/// <summary>
	/// The 'ConcreteImplementorA' class
	/// </summary>
	/// <seealso cref="BridgeStructural.Implementor" />
	class ConcreteImplementorA:Implementor {
		public override void Operation() {
			Console.WriteLine("ConcreteImplementorA Operation");
		}
	}
}
