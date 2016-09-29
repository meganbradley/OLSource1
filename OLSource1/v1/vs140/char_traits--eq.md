---
title: "char_traits::eq"
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
  - "std.char_traits.eq"
  - "std::char_traits::eq"
  - "eq"
  - "char_traits::eq"
  - "iosfwd/std::char_traits::eq"
  - "char_traits.eq"
  - "EQ"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "eq method"
ms.assetid: b540f4f8-2361-4c93-b20c-133e48bc51dc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::eq
Tests whether two `char_type` characters are equal.  
  
## Syntax  
  
```  
  
      static bool eq(  
   const char_type& _Ch1,   
   const char_type& _Ch2   
);  
```  
  
#### Parameters  
 `_Ch1`  
 The first of two characters to be tested for equality.  
  
 `_Ch2`  
 The second of two characters to be tested for equality.  
  
## Return Value  
 **true** if the first character is equal to the second character; otherwise **false**.  
  
## Example  
  
```  
// char_traits_eq.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   char_traits<char>::char_type ch1 =  'x';  
   char_traits<char>::char_type ch2 =  'y';  
   char_traits<char>::char_type ch3 =  'x';  
  
   // Testing for equality  
   bool b1 = char_traits<char>::eq ( ch1 , ch2 );  
   if ( b1 )  
      cout << "The character ch1 is equal "  
           << "to the character ch2." << endl;  
   else  
      cout << "The character ch1 is not equal "  
           << "to the character ch2." << endl;  
  
   // An equivalent and alternatively test procedure  
   if ( ch1 == ch3 )  
      cout << "The character ch1 is equal "  
           << "to the character ch3." << endl;  
   else  
      cout << "The character ch1 is not equal "  
           << "to the character ch3." << endl;  
}  
```  
  
 **The character ch1 is not equal to the character ch2.**  
**The character ch1 is equal to the character ch3.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)