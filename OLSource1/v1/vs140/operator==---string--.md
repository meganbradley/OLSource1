---
title: "operator== (&lt;string&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "string/std::operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, strings"
  - "operator ==, strings"
  - "== operator, with specific standard C++ objects"
ms.assetid: 4cc4279d-e324-4e05-8aa5-69489e054591
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;string&gt;)
Tests if the string object on the left side of the operator is equal to the string object on the right side.  
  
## Syntax  
  
```  
  
      template<class CharType, class Traits, class Allocator>  
   bool operator==(  
      const basic_string<CharType, Traits, Allocator>& _Left,  
      const basic_string<CharType, Traits, Allocator>& _Right  
   );  
template<class CharType, class Traits, class Allocator>  
   bool operator==(  
      const basic_string<CharType, Traits, Allocator>& _Left,  
      const CharType *_Right  
   );  
template<class CharType, class Traits, class Allocator>  
   bool operator==(  
      const CharType *_Left,  
      const basic_string<CharType, Traits, Allocator>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 A C-style string or an object of type `basic_string` to be compared.  
  
 `_Right`  
 A C-style string or an object of type `basic_string` to be compared.  
  
## Return Value  
 **true** if the string object on the left side of the operator is lexicographically equal to the string object on the right side; otherwise **false**.  
  
## Remarks  
 The comparison between string objects is based on a pairwise lexicographical comparison of their characters. Two strings are equal if they have the same number of characters and their respective character values are the same. Otherwise, they are unequal.  
  
## Example  
  
```  
// string_op_eq.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // Declaring an objects of type basic_string<char>  
   string s1 ( "pluck" );  
   string s2 ( "strum" );  
   cout << "The basic_string s1 = " << s1 << "." << endl;  
   cout << "The basic_string s2 = " << s2 << "." << endl;  
  
   // Declaring a C-style string  
   char *s3 = "pluck";  
   cout << "The C-style string s3 = " << s3 << "." << endl;  
  
   // First member function: comparison between left-side object  
   // of type basic_string & right-side object of type basic_string  
   if ( s1 == s2 )  
      cout << "The strings s1 & s2 are equal." << endl;  
   else  
      cout << "The strings s1 & s2 are not equal." << endl;  
  
   // Second member function: comparison between left-side object  
   // of type basic_string & right-side object of C-syle string type  
   if ( s1 == s3 )  
      cout << "The strings s1 & s3 are equal." << endl;  
   else  
      cout << "The strings s1 & s3 are not equal." << endl;  
  
   // Third member function: comparison between left-side object  
   // of C-syle string type & right-side object of type basic_string  
   if ( s3 == s2 )  
      cout << "The strings s3 & s2 are equal." << endl;  
   else  
      cout << "The strings s3 & s2 are not equal." << endl;  
}  
```  
  
 **The basic_string s1 = pluck.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = pluck.**  
**The strings s1 & s2 are not equal.**  
**The strings s1 & s3 are equal.**  
**The strings s3 & s2 are not equal.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [string::operator==](../vs140/string--operator==.md)