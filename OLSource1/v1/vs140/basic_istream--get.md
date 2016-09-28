---
title: "basic_istream::get"
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
  - "get"
  - "std.basic_istream.get"
  - "basic_istream.get"
  - "istream/std::basic_istream::get"
  - "std::basic_istream::get"
  - "basic_istream::get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get method"
ms.assetid: 15bcbad1-1754-410e-b248-c18e2e097331
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::get
Reads one or more characters from the input stream.  
  
## Syntax  
  
```  
int_type get();  
basic_istream<Elem, Tr>& get(  
    Elem& _Ch  
);  
basic_istream<Elem, Tr>& get(  
    Elem *_Str,  
    streamsize _Count  
);  
basic_istream<Elem, Tr>& get(  
    Elem *_Str,  
    streamsize _Count,  
    Elem _Delim  
);  
basic_istream<Elem, Tr>& get(  
    basic_streambuf<Elem, Tr>& _Strbuf  
);  
basic_istream<Elem, Tr>& get(  
    basic_streambuf<Elem, Tr>& _Strbuf,  
    Elem _Delim  
);  
```  
  
#### Parameters  
 `_Count`  
 The number of characters to read from `strbuf`.  
  
 `_Delim`  
 The character that should terminate the read if it is encountered before `_Count`.  
  
 `_Str`  
 A string in which to write.  
  
 `_Ch`  
 A character to get.  
  
 `_Strbuf`  
 A buffer in which to write.  
  
## Return Value  
 The parameterless form of get returns the element read as an integer or end of file. The remaining forms return the stream (*`this`).  
  
## Remarks  
 The first of these unformatted input functions extracts an element, if possible, as if by returning `rdbuf`->`sbumpc`. Otherwise, it returns **traits_type::**[eof](../vs140/char_traits--eof.md). If the function extracts no element, it calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
 The second function extracts the [int_type](../vs140/basic_ios--int_type.md) element `meta` the same way. If `meta` compares equal to **traits_type::eof**, the function calls `setstate`(**failbit**). Otherwise, it stores **traits_type::**[to_char_type](../vs140/char_traits--to_char_type.md)(`meta`) in `_Ch`. The function returns **\*this**.  
  
 The third function returns **get**(_*Str*, `_Count`, `widen`('\\**n**')).  
  
 The fourth function extracts up to `_Count` - 1 elements and stores them in the array beginning at _*Str*. It always stores `char_type` after any extracted elements it stores. In order of testing, extraction stops:  
  
-   At end of file.  
  
-   After the function extracts an element that compares equal to `_Delim`, in which case the element is put back to the controlled sequence.  
  
-   After the function extracts `_Count` - 1 elements.  
  
 If the function extracts no elements, it calls `setstate`(**failbit**). In any case, it returns **\*this**.  
  
 The fifth function returns **get**(**strbuf**, `widen`('\\**n**')).  
  
 The sixth function extracts elements and inserts them in **strbuf**. Extraction stops on end-of-file or on an element that compares equal to _*Delim,* which is not extracted. It also stops, without extracting the element in question, if an insertion fails or throws an exception (which is caught but not rethrown). If the function extracts no elements, it calls `setstate`(**failbit**). In any case, the function returns **\*this**.  
  
## Example  
  
```  
// basic_istream_get.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main( )   
{  
   char c[10];  
  
   c[0] = cin.get( );  
   cin.get( c[1] );  
   cin.get( &c[2],3 );  
   cin.get( &c[4], 4, '7' );  
  
   cout << c << endl;  
}  
```  
  
  **`11`11**   
## Requirements  
 **Header:** <istream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)