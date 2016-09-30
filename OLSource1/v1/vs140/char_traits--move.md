---
title: "char_traits::move"
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
  - "Move"
  - "char_traits::move"
  - "iosfwd/std::char_traits::move"
  - "move"
  - "std.char_traits.move"
  - "std::char_traits::move"
  - "char_traits.move"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move method"
ms.assetid: b6db1aca-c38e-4ad3-a95f-a05f83e67afc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::move
Copies a specified number of characters in a sequence to another, possibly overlapping sequence.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [char_traits::_Move_s](../vs140/char_traits--_move_s.md) instead.  
  
## Syntax  
  
```  
  
      static char  
      _  
      type *move(  
   char_type* _To,   
   const char_type* _From,   
   size_t _Num   
);  
```  
  
#### Parameters  
 `_To`  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 `_From`  
 The element at the beginning of the source string or character array to be copied.  
  
 `_Num`  
 The number of elements to be copied from the source string.  
  
## Return Value  
 The first element `_To` copied into the string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination may overlap.  
  
## Example  
  
```  
// char_traits_move.cpp  
// compile with: /EHsc /W3  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   char_traits<char>::char_type sFrom1[] =  "abcd-1234-abcd";  
   char_traits<char>::char_type sTo1[] =  "ABCD-1234";  
   char_traits<char>::char_type* result1;  
   cout << "The source string sFrom1 is: " << sFrom1 << endl;  
   cout << "The destination stringsTo1 is: " << sTo1 << endl;  
   // Note: char_traits::move is potentially unsafe, consider  
   // using char_traits::_Move_s instead.  
   result1 = char_traits<char>::move ( sTo1 ,  sFrom1 , 4 );  // C4996  
   cout << "The result1 = move ( sTo1 , sFrom1 , 4 ) is: "  
        << result1 << endl << endl;  
  
   // When source and destination overlap  
   char_traits<char>::char_type sToFrom2[] = "abcd-1234-ABCD";  
   char_traits<char>::char_type* result2;  
   cout << "The source/destination string sToFrom2 is: "  
        << sToFrom2 << endl;  
   const char* findc = char_traits<char>::find ( sToFrom2 , 4 , 'c' );  
   // Note: char_traits::move is potentially unsafe, consider  
   // using char_traits::_Move_s instead.  
   result2 = char_traits<char>::move ( sToFrom2 , findc , 8 );  // C4996  
   cout << "The result2 = move ( sToFrom2 , findc , 8 ) is: "  
        << result2 << endl;  
}  
```  
  
 **The source string sFrom1 is: abcd-1234-abcd**  
**The destination stringsTo1 is: ABCD-1234**  
**The result1 = move ( sTo1 , sFrom1 , 4 ) is: abcd-1234**  
**The source/destination string sToFrom2 is: abcd-1234-ABCD**  
**The result2 = move ( sToFrom2 , findc , 8 ) is: cd-1234-4-ABCD**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)