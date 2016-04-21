using System;
namespace BridgeStructural {
	class MainApp {
		static void Main() {
			Abstraction ab = new RefinedAbstraction();
			//Set implementation and call
			ab.Implementor = new ConcreteImplementorA();
			ab.Operation();
			ab.Implementor = new ConcreteImplementorB();
			ab.Operation();
			//Wait for user input
			Console.ReadKey();
		}
	}
}