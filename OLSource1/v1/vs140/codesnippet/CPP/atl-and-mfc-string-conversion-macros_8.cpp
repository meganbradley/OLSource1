// Example 5
// Specifying the code page.
void ExampleFunction5(LPCWSTR pszW)
{
   // Convert to the Macintosh code page
   ExampleFunctionA(CW2A(pszW, CP_MACCP));
}