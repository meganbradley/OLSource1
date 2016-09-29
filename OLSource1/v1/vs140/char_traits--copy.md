---
title: "char_traits::copy"
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
  - "iosfwd/std::char_traits::copy"
  - "std::char_traits::copy"
  - "char_traits::copy"
  - "std.char_traits.copy"
  - "char_traits.copy"
  - "copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy method"
ms.assetid: 46d7ac95-9f60-4290-9e18-6c19a2117fab
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# char_traits::copy
Copies a specified number of characters from one string to another.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct. Consider using [char_traits::_Copy_s](../vs140/char_traits--_copy_s.md) instead.  
  
## Syntax  
  
```  
  
      static char  
      _  
      type *copy(  
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
 The number of elements to be copied.  
  
## Return Value  
 The first element copied into the string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination character sequences must not overlap.  
  
## Example  
  
```  
// char_traits_copy.cpp  
// compile with: /EHsc /W3  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   char_traits<char>::char_type s1[] = "abcd-1234-abcd";  
   char_traits<char>::char_type s2[] = "ABCD-1234";  
   char_traits<char>::char_type* result1;  
   cout << "The source string is: " << s1 << endl;  
   cout << "The destination string is: " << s2 << endl;  
   // Note: char_traits::copy is potentially unsafe, consider  
   // using char_traits::_Copy_s instead.  
   result1 = char_traits<char>::copy ( s1 , s2 , 4 );  // C4996  
   cout << "The result1 = copy ( s1 , s2 , 4 ) is: "  
        << result1 << endl;  
}  
```  
  
 **The source string is: abcd-1234-abcd**  
**The destination string is: ABCD-1234**  
**The result1 = copy ( s1 , s2 , 4 ) is: ABCD-1234-abcd**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)