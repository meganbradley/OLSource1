---
title: "&lt;iostream&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 30b71cbb-4a42-419f-b594-7dc2c1f065a4
caps.latest.revision: 14
robots: noindex,nofollow
---
# &lt;iostream&gt; functions
||||  
|-|-|-|  
|[cerr](#cerr)|[cin](#cin)|[clog](#clog)|  
|[cout](#cout)|[wcerr](#wcerr)|[wcin](#wcin)|  
|[wclog](#wclog)|[wcout](#wcout)|  
  
##  \<a name="cerr"></a>  cerr  
 The object `cerr` controls output to a stream buffer associated with the object `stderr`, declared in \<cstdio>.  
  
```  
extern ostream cerr;  
```  
  
### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
### Remarks  
 The object controls unbuffered insertions to the standard error output as a byte stream. Once the object is constructed, the expression `cerr.`[flags](../vs140/ios_base-class.md#ios_base__flags) `&` [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero, and `cerr.tie() == &cout`.  
  
### Example  
  
```  
// iostream_cerr.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
using namespace std;  
  
void TestWide( )   
{  
   int i = 0;  
   wcout << L"Enter a number: ";  
   wcin >> i;  
   wcerr << L"test for wcerr" << endl;  
   wclog << L"test for wclog" << endl;     
}  
  
int main( )   
{  
   int i = 0;  
   cout << "Enter a number: ";  
   cin >> i;  
   cerr << "test for cerr" << endl;  
   clog << "test for clog" << endl;  
   TestWide( );  
}  
```  
  
##  \<a name="cin"></a>  cin  
 Specifies the `cin` global stream.  
  
```  
extern istream cin;  
```  
  
### Return Value  
 An [istream](../vs140/-istream--typedefs.md#istream) object.  
  
### Remarks  
 The object controls extractions from the standard input as a byte stream. Once the object is constructed, the call `cin.`[tie](../vs140/basic_ios-class.md#basic_ios__tie) returns `&`[cout](../vs140/-iostream--functions.md#cout).  
  
### Example  
  In this example, `cin` sets the fail bit on the stream when it encounters non-numeric characters. The program clears the fail bit and strips the invalid character from the stream to proceed.  
  
```  
// iostream_cin.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main()  
{  
   int x;  
   cout << "enter choice:";  
   cin >> x;  
   while (x < 1 || x > 4)  
   {  
      cout << "Invalid choice, try again:";  
      cin >> x;  
      // not a numeric character, probably  
      // clear the failure and pull off the non-numeric character  
      if (cin.fail())  
      {  
         cin.clear();  
         char c;  
         cin >> c;  
      }  
   }  
}  
```  
  
   **`2`**     
##  \<a name="clog"></a>  clog  
 Specifies the `clog` global stream.  
  
```  
extern ostream clog;  
```  
  
### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
### Remarks  
 The object controls buffered insertions to the standard error output as a byte stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using `clog`.  
  
##  \<a name="cout"></a>  cout  
 Specifies the `cout` global stream.  
  
```  
extern ostream cout;  
```  
  
### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
### Remarks  
 The object controls insertions to the standard output as a byte stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using `cout`.  
  
##  \<a name="wcerr"></a>  wcerr  
 Specifies the `wcerr` global stream.  
  
```  
extern wostream wcerr;  
```  
  
### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
### Remarks  
 The object controls unbuffered insertions to the standard error output as a wide stream. Once the object is constructed, the expression `wcerr.`[flags](../vs140/ios_base-class.md#ios_base__flags) `&` [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using `wcerr`.  
  
##  \<a name="wcin"></a>  wcin  
 Specifies the `wcin` global stream.  
  
```  
extern wistream wcin;  
```  
  
### Return Value  
 A [wistream](../vs140/-istream--typedefs.md#wistream) object.  
  
### Remarks  
 The object controls extractions from the standard input as a wide stream. Once the object is constructed, the call `wcin.`[tie](../vs140/basic_ios-class.md#basic_ios__tie) returns `&`[wcout](../vs140/-iostream--functions.md#wcout).  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using `wcin`.  
  
##  \<a name="wclog"></a>  wclog  
 Specifies the `wclog` global stream.  
  
```  
extern wostream wclog;  
```  
  
### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
### Remarks  
 The object controls buffered insertions to the standard error output as a wide stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using `wclog`.  
  
##  \<a name="wcout"></a>  wcout  
 Specifies the `wcout` global stream.  
  
```  
extern wostream wcout;  
```  
  
### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
### Remarks  
 The object controls insertions to the standard output as a wide stream.  
  
### Example  
  See [cerr](../vs140/-iostream--functions.md#cerr) for an example of using `wcout`.  
  
 `CString` instances in a `wcout` statement must be cast to `const wchar_t*`, as shown in the following example.  
  
```  
  
      CString cs("meow");  
    wcout << (const wchar_t*) cs << endl;  
```  
  
 For more information, see [Basic CString Operations](../vs140/basic-cstring-operations.md).  
  
## See Also  
 [&lt;iostream&gt;](../vs140/-iostream-.md)