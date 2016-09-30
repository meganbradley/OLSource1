---
title: "char_traits::to_char_type"
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
  - "std.char_traits.to_char_type"
  - "iosfwd/std::char_traits::to_char_type"
  - "std::char_traits::to_char_type"
  - "char_traits::to_char_type"
  - "to_char_type"
  - "char_traits.to_char_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_char_type typedef"
  - "to_char_type method"
ms.assetid: 2b9e8fd8-7da5-4eea-964a-f68b4284bda9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::to_char_type
Converts an `int_type` character to the corresponding `char_type` character and returns the result.  
  
## Syntax  
  
```  
  
      static char  
      _  
      type to  
      _  
      char  
      _  
      type(  
   const int_type& _Ch  
);  
```  
  
#### Parameters  
 `_Ch`  
 The `int_type` character to be represented as a `char_type`.  
  
## Return Value  
 The `char_type` character corresponding to the `int_type` character.  
  
 A value of `_Ch` that cannot be represented as such yields an unspecified result.  
  
## Remarks  
 The conversion operations [to_int_type](../vs140/char_traits--to_int_type.md) and `to_char_type` are inverse to each other, so that:  
  
 `to_int_type` ( `to_char_type` ( *x* ) ) == *x*  
  
 for any `int_type` *x* and  
  
 `to_char_type` ( `to_int_type` ( *x* ) ) == *x*  
  
 for any `char_type` *x*.  
  
## Example  
  
```  
// char_traits_to_char_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   char_traits<char>::char_type ch1 =  'a';  
   char_traits<char>::char_type ch2 =  'b';  
   char_traits<char>::char_type ch3 =  'a';  
  
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
  
   // Converting from int_type back to char_type  
   char_traits<char>::char_type rec_ch1;  
   rec_ch1 = char_traits<char>:: to_char_type ( int1);  
   char_traits<char>::char_type rec_ch2;  
   rec_ch2 = char_traits<char>:: to_char_type ( int2);  
  
   cout << "The recovered char_types and corresponding int_types are:"  
        << "\n    recovered ch1 = " << rec_ch1 << " from int1 = "   
        << int1 << "."  
        << "\n    recovered ch2 = " << rec_ch2 << " from int2 = "   
        << int2 << "." << endl << endl;  
  
   // Testing that the conversions are inverse operations  
   bool b1 = char_traits<char>::eq ( rec_ch1 , ch1 );  
   if ( b1 )  
      cout << "The recovered char_type of ch1"  
           << " is equal to the original ch1." << endl;  
   else  
      cout << "The recovered char_type of ch1"  
           << " is not equal to the original ch1." << endl;  
  
   // An equivalent and alternatively test procedure  
   if ( rec_ch2 == ch2 )  
      cout << "The recovered char_type of ch2"  
           << " is equal to the original ch2." << endl;  
   else  
      cout << "The recovered char_type of ch2"  
           << " is not equal to the original ch2." << endl;  
}  
```  
  
 **The char_types and corresponding int_types are:**  
 **ch1 = a corresponding to int1 = 97.**  
 **ch2 = b corresponding to int1 = 98.**  
 **ch3 = a corresponding to int1 = 97.**  
**The recovered char_types and corresponding int_types are:**  
 **recovered ch1 = a from int1 = 97.**  
 **recovered ch2 = b from int2 = 98.**  
**The recovered char_type of ch1 is equal to the original ch1.**  
**The recovered char_type of ch2 is equal to the original ch2.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)