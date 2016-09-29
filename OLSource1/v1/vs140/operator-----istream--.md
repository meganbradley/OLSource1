---
title: "operator&gt;&gt; (&lt;istream&gt;)"
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
  - "std::operator>>"
  - "std::>>"
  - "std.>>"
  - "istream/std::operator>>"
  - ">>"
  - "std.operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>>"
  - "operator>>, streams"
  - ">> operator, stream"
  - "operator >>, streams"
ms.assetid: 22be9a65-8e9c-4be0-a9cf-e4c442ef33b6
caps.latest.revision: 26
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;&gt; (&lt;istream&gt;)
Extracts characters and strings from the stream.  
  
## Syntax  
  
```  
template<class Elem, class Tr>  
    basic_istream<Elem, Tr>& operator>>(  
        basic_istream<Elem, Tr>& _Istr,   
        Elem *_Str  
    );  
template<class Elem, class Tr>  
    basic_istream<Elem, Tr>& operator>>(  
        basic_istream<Elem, Tr>& _Istr,   
        Elem& _Ch  
    );  
template<class Tr>  
    basic_istream<char, Tr>& operator>>(  
        basic_istream<char, Tr>& _Istr,   
        signed char *_Str  
    );  
template<class Tr>  
    basic_istream<char, Tr>& operator>>(  
        basic_istream<char, Tr>& _Istr,   
        signed char& _Ch  
    );  
template<class Tr>  
    basic_istream<char, Tr>& operator>>(  
        basic_istream<char, Tr>& _Istr,   
        unsigned char *_Str  
    );  
template<class Tr>  
    basic_istream<char, Tr>& operator>>(  
        basic_istream<char, Tr>& _Istr,   
        unsigned char& _Ch  
    );  
template<class Elem, class Tr, class Type>  
    basic_istream<Elem, Tr>& operator>>(  
        basic_istream<char, Tr>&& _Istr,  
        Type& _Val  
    );  
```  
  
#### Parameters  
 `_Ch`  
 A character.  
  
 `_Istr`  
 A stream.  
  
 `_Str`  
 A string.  
  
 `_Val`  
 A type.  
  
## Return Value  
 The stream  
  
## Remarks  
 The `basic_istream` class also defines several extraction operators. For more information, see [basic_istream::operator>>](../vs140/basic_istream--operator--.md).  
  
 The template function:  
  
```  
template<class Elem, class Tr>  
   basic_istream<Elem, Tr>& operator>>(  
      basic_istream<Elem, Tr>& _Istr, Elem *_Str);  
```  
  
 extracts up to *N* - 1 elements and stores them in the array starting at _*Str*. If `_Istr`.[width](../vs140/ios_base--width.md) is greater than zero, *N* is `_Istr`.**width**; otherwise, it is the size of the largest array of **Elem** that can be declared. The function always stores the value **Elem()** after any extracted elements it stores. Extraction stops early on end of file, on a character with value **Elem**(0) (which is not extracted), or on any element (which is not extracted) that would be discarded by [ws](../vs140/ws.md). If the function extracts no elements, it calls `_Istr`.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, it calls `_Istr`.**width**(0) and returns `_Istr`.  
  
 **Security Note** The null-terminated string being extracted from the input stream must not exceed the size of the destination buffer `_Str`. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 The template function:  
  
```  
template<class Elem, class Tr>  
   basic_istream<Elem, Tr>& operator>>(  
      basic_istream<Elem, Tr>& _Istr, Elem& _Ch);  
```  
  
 extracts an element, if it is possible, and stores it in `_Ch`. Otherwise, it calls **is**.[setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, it returns `_Istr`.  
  
 The template function:  
  
```  
template<class Tr>  
   basic_istream<char, Tr>& operator>>(  
      basic_istream<char, Tr>& _Istr, signed char *_Str);  
```  
  
 returns `_Istr` >> (`char` **\***)`_Str`.  
  
 The template function:  
  
```  
template<class Tr>  
   basic_istream<char, Tr>& operator>>(  
      basic_istream<char, Tr>& _Istr, signed char& _Ch);  
```  
  
 returns `_Istr` >> (**char&**)`_Ch`.  
  
 The template function:  
  
```  
template<class Tr>  
   basic_istream<char, Tr>& operator>>(  
      basic_istream<char, Tr>& _Istr, unsigned char *_Str);  
```  
  
 returns `_Istr` >> (**char \***)`_Str`.  
  
 The template function:  
  
```  
template<class Tr>  
   basic_istream<char, Tr>& operator>>(  
      basic_istream<char, Tr>& _Istr, unsigned char& _Ch);  
```  
  
 returns `_Istr` >> (**char&**)`_Ch`.  
  
 The template function:  
  
```  
template<class Elem, class Tr, class Type>  
   basic_istream<Elem, Tr>& operator>>(  
      basic_istream<char, Tr>&& _Istr,  
      Type& _Val  
   );  
```  
  
 returns `_Istr` `>>` `_Val` (and converts an `rvalue reference` to `_Istr` to an `lvalue` in the process).  
  
## Example  
  
```  
// istream_op_extract.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main( )   
{  
   ws( cin );  
   char c[10];  
  
   cin.width( 9 );  
   cin >> c;  
   cout << c << endl;  
}  
```  
  
## Input  
  
```  
1234567890  
```  
  
## Output  
  
```  
12345678  
```  
  
## Requirements  
 **Header:** <istream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream::operator>>](../vs140/basic_istream--operator--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)