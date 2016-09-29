---
title: "char_traits::to_int_type"
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
  - "std.char_traits.to_int_type"
  - "to_int_type"
  - "char_traits.to_int_type"
  - "iosfwd/std::char_traits::to_int_type"
  - "std::char_traits::to_int_type"
  - "char_traits::to_int_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "to_int_type method"
  - "to_int_type typedef"
ms.assetid: 76a73bd5-5bcf-4f46-86a9-fb17688644b8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::to_int_type
Converts a `char_type` character to the corresponding `int_type` character and returns the result.  
  
## Syntax  
  
```  
  
      static int  
      _  
      type to  
      _  
      int  
      _  
      type(  
   const char_type& _Ch  
);  
```  
  
#### Parameters  
 `_Ch`  
 The `char_type` character to be represented as an `int_type`.  
  
## Return Value  
 The `int_type` character corresponding to the `char_type` character.  
  
## Remarks  
 The conversion operations `to_int_type` and [to_char_type](../vs140/char_traits--to_char_type.md) are inverse to each other, so that:  
  
 `to_int_type` ( `to_char_type` ( *x* ) ) == *x*  
  
 for any `int_type` *x*, and  
  
 `to_char_type` ( `to_int_type` ( *x* ) ) == *x*  
  
 for any `char_type` *x*.  
  
## Example  
  
```  
// char_traits_to_int_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   char_traits<char>::char_type ch1 = 'a';  
   char_traits<char>::char_type ch2 = 'b';  
   char_traits<char>::char_type ch3 = 'a';  
  
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