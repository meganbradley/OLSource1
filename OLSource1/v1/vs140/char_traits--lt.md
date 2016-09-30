---
title: "char_traits::lt"
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
  - "LT"
  - "char_traits.lt"
  - "std.char_traits.lt"
  - "iosfwd/std::char_traits::lt"
  - "char_traits::lt"
  - "std::char_traits::lt"
  - "lt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lt method"
ms.assetid: 8c1c7722-4894-48fc-818f-a882c76eb0f4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::lt
Tests whether one character is less than another.  
  
## Syntax  
  
```  
  
      static bool lt(  
   const char_type& _Ch1,   
   const char_type& _Ch2   
);  
```  
  
#### Parameters  
 `_Ch1`  
 The first of two characters to be tested for less than.  
  
 `_Ch2`  
 The second of two characters to be tested for less than.  
  
## Return Value  
 **true** if the first character is less than the second character; otherwise **false**.  
  
## Example  
  
```  
// char_traits_lt.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   char_traits<char>::char_type ch1 =  'x';  
   char_traits<char>::char_type ch2 =  'y';  
   char_traits<char>::char_type ch3 =  'z';  
  
   // Testing for less than  
   bool b1 = char_traits<char>::lt ( ch1 , ch2 );  
   if ( b1 )  
      cout << "The character ch1 is less than "  
           << "the character ch2." << endl;  
   else  
      cout << "The character ch1 is not less "  
           << "than the character ch2." << endl;  
  
   // An equivalent and alternatively test procedure  
   if ( ch3 <  ch2 )  
      cout << "The character ch3 is less than "  
           << "the character ch2." << endl;  
   else  
      cout << "The character ch3 is not less "  
           << "than the character ch2." << endl;  
}  
```  
  
 **The character ch1 is less than the character ch2.**  
**The character ch3 is not less than the character ch2.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)