---
title: "operator&lt;= (in &lt;string&gt;)"
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
  - "std::<="
  - "std.operator<="
  - "operator<="
  - "std.<="
  - "std::operator<="
  - "string/std::operator<="
  - "<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<=, strings"
  - "operator <=, strings"
  - "<= operator, with specific objects"
  - "<= operator"
ms.assetid: 784d9f6b-133b-45d7-bf80-47a192501c54
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (in &lt;string&gt;)
Tests if the string object on the left side of the operator is less than or equal to the string object on the right side.  
  
## Syntax  
  
```  
  
      template<class CharType, class Traits, class Allocator>  
   bool operator<=(  
      const basic_string<CharType, Traits, Allocator>& _Left,  
      const basic_string<CharType, Traits, Allocator>& _Right  
   );  
template<class CharType, class Traits, class Allocator>  
   bool operator<=(  
      const basic_string<CharType, Traits, Allocator>& _Left,  
      const CharType *_Right  
   );  
template<class CharType, class Traits, class Allocator>  
   bool operator<=(  
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
 **true** if the string object on the left side of the operator is lexicographically less than or equal to the string object on the right side; otherwise **false**.  
  
## Remarks  
 A lexicographical comparison between strings compares them character by character until:  
  
-   It finds two corresponding characters unequal, and the result of their comparison is taken as the result of the comparison between the strings.  
  
-   It finds no inequalities, but one string has more characters than the other, and the shorter string is considered less than the longer string.  
  
-   It finds no inequalities and finds that the strings have the same number of characters, so the strings are equal.  
  
## Example  
  
```  
// string_op_le.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // Declaring an objects of type basic_string<char>  
   string s1 ( "strict" );  
   string s2 ( "strum" );  
   cout << "The basic_string s1 = " << s1 << "." << endl;  
   cout << "The basic_string s2 = " << s2 << "." << endl;  
  
   // Declaring a C-style string  
   char *s3 = "strict";  
   cout << "The C-style string s3 = " << s3 << "." << endl;  
  
   // First member function: comparison between left-side object  
   // of type basic_string & right-side object of type basic_string  
   if ( s1 <= s2 )  
      cout << "The string s1 is less than or equal to "  
           << "the string s2." << endl;  
   else  
      cout << "The string s1 is greater than "  
           << "the string s2." << endl;  
  
   // Second member function: comparison between left-side object  
   // of type basic_string & right-side object of C-syle string type  
   if ( s1 <= s3 )  
      cout << "The string s1 is less than or equal to "  
           << "the string s3." << endl;  
   else  
      cout << "The string s1 is greater than "  
           << "the string s3." << endl;  
  
   // Third member function: comparison between left-side object  
   // of C-syle string type  & right-side object of type basic_string  
   if ( s2 <= s3 )  
      cout << "The string s2 is less than or equal to "  
           << "the string s3." << endl;  
   else  
      cout << "The string s2 is greater than "  
           << "the string s3." << endl;  
}  
```  
  
 **The basic_string s1 = strict.**  
**The basic_string s2 = strum.**  
**The C-style string s3 = strict.**  
**The string s1 is less than or equal to the string s2.**  
**The string s1 is less than or equal to the string s3.**  
**The string s2 is greater than the string s3.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [string::operator<=](../vs140/string--operator-=.md)