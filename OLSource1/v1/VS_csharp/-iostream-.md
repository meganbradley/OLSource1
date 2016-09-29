---
title: "&lt;iostream&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.<iostream>"
  - "std::<iostream>"
  - "<iostream>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iostream header"
ms.assetid: de5d39e1-7e77-4b55-bcd1-7c77b41515c8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iostream&gt;
Declares objects that control reading from and writing to the standard streams. This is often the only header you need to include to perform input and output from a C++ program.  
  
## Syntax  
  
```  
#include <iostream>  
  
```  
  
## Remarks  
 The objects fall into two groups:  
  
-   [cin](#cin), [cout](#cout), [cerr](#cerr), and [clog](#clog) are byte oriented, performing conventional byte-at-a-time transfers.  
  
-   [wcin](#wcin), [wcout](#wcout), [wcerr](#wcerr), and [wclog](#wclog) are wide oriented, translating to and from the wide characters that the program manipulates internally.  
  
 Once you perform certain operations on a stream, such as the standard input, you cannot perform operations of a different orientation on the same stream. Therefore, a program cannot operate interchangeably on both [cin](#cin) and [wcin](#wcin), for example.  
  
 All the objects declared in this header share a peculiar property — you can assume they are constructed before any static objects you define, in a translation unit that includes <iostream\>. Equally, you can assume that these objects are not destroyed before the destructors for any such static objects you define. (The output streams are, however, flushed during program termination.) Therefore, you can safely read from or write to the standard streams before program startup and after program termination.  
  
 This guarantee is not universal, however. A static constructor may call a function in another translation unit. The called function cannot assume that the objects declared in this header have been constructed, given the uncertain order in which translation units participate in static construction. To use these objects in such a context, you must first construct an object of class [ios_base::Init](../VS_csharp/ios_base-class.md#ios_base__init).  
  
### Global Stream Objects  
  
|||  
|-|-|  
|[cerr](#cerr)|Specifies the `cerr` global stream.|  
|[cin](#cin)|Specifies the `cin` global stream.|  
|[clog](#clog)|Specifies the `clog` global stream.|  
|[cout](#cout)|Specifies the `cout` global stream.|  
|[wcerr](#wcerr)|Specifies the `wcerr` global stream.|  
|[wcin](#wcin)|Specifies the `wcin` global stream.|  
|[wclog](#wclog)|Specifies the `wclog` global stream.|  
|[wcout](#wcout)|Specifies the `wcout` global stream.|  
  
###  <a name="cerr"></a>  cerr  
 The object `cerr` controls output to a stream buffer associated with the object `stderr`, declared in <cstdio\>.  
  
```  
extern ostream cerr;  
```  
  
#### Return Value  
 An [ostream](../VS_csharp/-ostream--typedefs.md#ostream) object.  
  
#### Remarks  
 The object controls unbuffered insertions to the standard error output as a byte stream. Once the object is constructed, the expression `cerr.`[flags](../VS_csharp/ios_base-class.md#ios_base__flags) `&` [unitbuf](../VS_csharp/-ios--functions.md#unitbuf) is nonzero, and `cerr.tie() == &cout`.  
  
#### Example  
  
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
  
###  <a name="cin"></a>  cin  
 Specifies the `cin` global stream.  
  
```  
extern istream cin;  
```  
  
#### Return Value  
 An [istream](../VS_csharp/-istream--typedefs.md#istream) object.  
  
#### Remarks  
 The object controls extractions from the standard input as a byte stream. Once the object is constructed, the call `cin.`[tie](../VS_csharp/basic_ios-class.md#basic_ios__tie) returns `&`[cout](#cout).  
  
#### Example  
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
###  <a name="clog"></a>  clog  
 Specifies the `clog` global stream.  
  
```  
extern ostream clog;  
```  
  
#### Return Value  
 An [ostream](../VS_csharp/-ostream--typedefs.md#ostream) object.  
  
#### Remarks  
 The object controls buffered insertions to the standard error output as a byte stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using `clog`.  
  
###  <a name="cout"></a>  cout  
 Specifies the `cout` global stream.  
  
```  
extern ostream cout;  
```  
  
#### Return Value  
 An [ostream](../VS_csharp/-ostream--typedefs.md#ostream) object.  
  
#### Remarks  
 The object controls insertions to the standard output as a byte stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using `cout`.  
  
###  <a name="wcerr"></a>  wcerr  
 Specifies the `wcerr` global stream.  
  
```  
extern wostream wcerr;  
```  
  
#### Return Value  
 A [wostream](../VS_csharp/-ostream--typedefs.md#wostream) object.  
  
#### Remarks  
 The object controls unbuffered insertions to the standard error output as a wide stream. Once the object is constructed, the expression `wcerr.`[flags](../VS_csharp/ios_base-class.md#ios_base__flags) `&` [unitbuf](../VS_csharp/-ios--functions.md#unitbuf) is nonzero.  
  
#### Example  
  See [cerr](#cerr) for an example of using `wcerr`.  
  
###  <a name="wcin"></a>  wcin  
 Specifies the `wcin` global stream.  
  
```  
extern wistream wcin;  
```  
  
#### Return Value  
 A [wistream](../VS_csharp/-istream--typedefs.md#wistream) object.  
  
#### Remarks  
 The object controls extractions from the standard input as a wide stream. Once the object is constructed, the call `wcin.`[tie](../VS_csharp/basic_ios-class.md#basic_ios__tie) returns `&`[wcout](#wcout).  
  
#### Example  
  See [cerr](#cerr) for an example of using `wcin`.  
  
###  <a name="wclog"></a>  wclog  
 Specifies the `wclog` global stream.  
  
```  
extern wostream wclog;  
```  
  
#### Return Value  
 A [wostream](../VS_csharp/-ostream--typedefs.md#wostream) object.  
  
#### Remarks  
 The object controls buffered insertions to the standard error output as a wide stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using `wclog`.  
  
###  <a name="wcout"></a>  wcout  
 Specifies the `wcout` global stream.  
  
```  
extern wostream wcout;  
```  
  
#### Return Value  
 A [wostream](../VS_csharp/-ostream--typedefs.md#wostream) object.  
  
#### Remarks  
 The object controls insertions to the standard output as a wide stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using `wcout`.  
  
 `CString` instances in a `wcout` statement must be cast to `const wchar_t*`, as shown in the following example.  
  
```  
  
      CString cs("meow");  
    wcout << (const wchar_t*) cs << endl;  
```  
  
 For more information, see [Basic CString Operations](../VS_csharp/basic-cstring-operations.md).  
  
## See Also  
 [Header Files](../VS_csharp/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../VS_csharp/iostream-programming.md)   
 [iostreams Conventions](../VS_csharp/iostreams-conventions.md)