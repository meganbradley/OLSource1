void StringFunc(LPSTR lpsz)
{
   USES_CONVERSION;

   LPWSTR x = A2W(lpsz);
   // Do something with x
   wprintf_s(L"x is %s", x);
}