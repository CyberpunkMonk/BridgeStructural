using System;

namespace BridgeStructural {
	/// <summary>
	/// The 'Abstraction' class
	/// </summary>
	class Abstraction {
		protected Implementor implementor;
		//property
		public Implementor Implementor {
			set { implementor = value; }
		}
		public virtual void Operation() {
			implementor.Operation();
		}
	}
}