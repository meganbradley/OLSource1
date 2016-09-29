//Example 1
// Convert LPCWSTR to LPCSTR.
void ExampleFunction1(LPCWSTR pszW)
{
   // Create an instance of CW2A, called pszA,
   // and initialize it with pszW.
   CW2A pszA(pszW);
   // pszA works like an LPCSTR, and can be used thus:
   ExampleFunctionA(pszA);  
   // Note: pszA will become invalid when it goes out of scope.
}

// Example 2
// Use a temporary instance of CW2A.
void ExampleFunction2(LPCWSTR pszW)
{
   // Create a temporary instance of CW2A,
   // and initialize it with pszW.
   ExampleFunctionA(CW2A(pszW));
   // Note: the temporary instance becomes invalid 
   // after the execution of the statement above.
}

// Example 3
// Incorrect use of conversion macros.
void ExampleFunction3(LPCWSTR pszW)
{
   // Create a temporary instance of CW2A,
   // save a pointer to it and then delete
   // the temportary instance.
   LPCSTR pszA = CW2A(pszW);
   // The pszA in the following line is an invalid pointer,
   // as the instance of CW2A has gone out of scope.
   ExampleFunctionA(pszA);
}