using System;

namespace BridgeStructural {
	class RefinedAbstraction:Abstraction{
		public override void Operation() {
			implementor.Operation();
		}
	}
}
