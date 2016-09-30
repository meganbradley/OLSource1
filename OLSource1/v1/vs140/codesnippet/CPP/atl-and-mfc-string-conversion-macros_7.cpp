// Example 4
// Changing the size of the buffer.
void ExampleFunction4(LPCWSTR pszW)
{
   // Use a 16-character buffer.
   ExampleFunctionA(CW2AEX<16>(pszW));
}