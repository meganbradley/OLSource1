---
title: "basic_string::operator+="
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
  - "operator+="
  - "basic_string.operator+="
  - "std.basic_string.operator+="
  - "+="
  - "std::basic_string::operator+="
  - "xstring/std::basic_string::operator+="
  - "basic_string::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+= operator, appending strings"
  - "operator+="
  - "+= operator"
  - "operator +=, strings"
  - "operator+=, strings"
  - "operator +="
ms.assetid: bc44659d-b3a1-4f24-a4f7-2e8c50871834
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::operator+=
Appends characters to a string.  
  
## Syntax  
  
```  
basic_string<CharType, Traits, Allocator>& operator+=(  
   value_type _Ch  
);  
basic_string<CharType, Traits, Allocator>& operator+=(  
   const value_type* _Ptr  
);  
basic_string<CharType, Traits, Allocator>& operator+=(  
   const basic_string<CharType, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Ch`  
 The character to be appended.  
  
 `_Ptr`  
 The characters of the C-string to be appended.  
  
 `_Right`  
 The characters of the string to be appended.  
  
## Return Value  
 A reference to the string object that is being appended with the characters passed by the member function.  
  
## Remarks  
 Characters may be appended to a string using the `operator+=` or the member functions [append](../vs140/basic_string--append.md) or [push_back](../vs140/basic_string--push_back.md). The `operator+=` appends single-argument values while the multiple argument append member function allows a specific part of a string to be specified for adding.  
  
## Example  
  
```  
// basic_string_op_app.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The first member function  
   // appending a single character to a string  
   string str1a ( "Hello" );  
   cout << "The original string str1 is: " << str1a << endl;  
   str1a +=  '!' ;  
   cout << "The string str1 appended with an exclamation is: "   
        << str1a << endl << endl;  
  
   // The second member function  
   // appending a C-string to a string  
   string  str1b ( "Hello " );  
   const char *cstr1b = "Out There";  
   cout << "The C-string cstr1b is: " << cstr1b << endl;  
   str1b +=  cstr1b;  
   cout << "Appending the C-string cstr1b to string str1 gives: "   
        << str1b << "." << endl << endl;  
  
   // The third member function  
   // appending one string to another in two ways,  
   // comparing append and operator [ ]  
   string str1d ( "Hello " ), str2d ( "Wide " ), str3d ( "World" );  
   cout << "The string str2d is: " << str2d << endl;  
   str1d.append ( str2d );  
   cout << "The appended string str1d is: "   
        << str1d << "." << endl;  
   str1d += str3d;  
   cout << "The doubly appended strig str1 is: "   
        << str1d << "." << endl << endl;  
}  
```  
  
 **The original string str1 is: Hello**  
**The string str1 appended with an exclamation is: Hello!**  
**The C-string cstr1b is: Out There**  
**Appending the C-string cstr1b to string str1 gives: Hello Out There.**  
**The string str2d is: Wide**   
**The appended string str1d is: Hello Wide .**  
**The doubly appended strig str1 is: Hello Wide World.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)