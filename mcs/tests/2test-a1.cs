//
// Parameter and return value compilation tests for anonymous methods
//
delegate void D (int x);
delegate void E (out int x);

class X {
	static int Main ()
	{
		// This should create an AnonymousMethod with the implicit argument
		D d1 = delegate {};
		D d2 = delegate (int a) {};

		return 0;
	}
}
