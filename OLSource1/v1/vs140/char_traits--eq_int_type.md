---
title: "char_traits::eq_int_type"
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
  - "char_traits.eq_int_type"
  - "iosfwd/std::char_traits::eq_int_type"
  - "eq_int_type"
  - "std::char_traits::eq_int_type"
  - "char_traits::eq_int_type"
  - "std.char_traits.eq_int_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "eq_int_type typedef"
  - "eq_int_type method"
ms.assetid: 5541a455-abb5-49de-b562-2ff8eaa86855
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::eq_int_type
Tests whether two characters represented as `int_type`s are equal or not.  
  
## Syntax  
  
```  
  
      static bool eq  
      _  
      int  
      _  
      type(  
   const int_type& _Ch1,  
   const int_type& _Ch2  
);  
```  
  
#### Parameters  
 `_Ch1`  
 The first of the two characters to be tested for equality as **int_type**s.  
  
 `_Ch2`  
 The second of the two characters to be tested for equality as `int_type`s.  
  
## Return Value  
 **true** if the first character is equal to the second character; otherwise **false**.  
  
## Example  
  
```  
// char_traits_eq_int_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   char_traits<char>::char_type ch1 =  'x';  
   char_traits<char>::char_type ch2 =  'y';  
   char_traits<char>::char_type ch3 =  'x';  
  
   // Converting from char_type to int_type  
   char_traits<char>::int_type int1, int2 , int3;  
   int1 =char_traits<char>:: to_int_type ( ch1 );  
   int2 =char_traits<char>:: to_int_type ( ch2 );  
   int3 =char_traits<char>:: to_int_type ( ch3 );  
  
   cout << "The char_types and corresponding int_types are:"  
        << "\n    ch1 = " << ch1 << " corresponding to int1 = "  
        << int1 << "."  
        << "\n    ch2 = " << ch2 << " corresponding to int1 = "  
        << int2 << "."  
        << "\n    ch3 = " << ch3 << " corresponding to int1 = "  
        << int3 << "." << endl << endl;  
  
   // Testing for equality of int_type representations  
   bool b1 = char_traits<char>::eq_int_type ( int1 , int2 );  
   if ( b1 )  
      cout << "The int_type representation of character ch1\n "  
           << "is equal to the int_type representation of ch2."  
           << endl;  
   else  
      cout << "The int_type representation of character ch1\n is "  
           << "not equal to the int_type representation of ch2."  
           << endl;  
  
   // An equivalent and alternatively test procedure  
   if ( int1 == int3 )  
      cout << "The int_type representation of character ch1\n "  
           << "is equal to the int_type representation of ch3."  
           << endl;  
   else  
      cout << "The int_type representation of character ch1\n is "  
           << "not equal to the int_type representation of ch3."  
           << endl;  
}  
```  
  
 **The char_types and corresponding int_types are:**  
 **ch1 = x corresponding to int1 = 120.**  
 **ch2 = y corresponding to int1 = 121.**  
 **ch3 = x corresponding to int1 = 120.**  
**The int_type representation of character ch1**  
 **is not equal to the int_type representation of ch2.**  
**The int_type representation of character ch1**  
 **is equal to the int_type representation of ch3.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)