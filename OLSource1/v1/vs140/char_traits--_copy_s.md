---
title: "char_traits::_Copy_s"
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
  - "std.char_traits._Copy_s"
  - "iosfwd/std::char_traits::_Copy_s"
  - "char_traits._Copy_s"
  - "std::char_traits::_Copy_s"
  - "char_traits::_Copy_s"
  - "_Copy_s"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Copy_s method"
ms.assetid: 10dedcb9-47b3-4f48-b641-ff1e1396e783
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::_Copy_s
Copies a specified number of characters from one string to another.  
  
## Syntax  
  
```  
static char_type *_Copy_s(  
    char_type *_Dest,  
    size_t _Dest_size,  
    const char_type *_From,  
    size_t _Count  
);  
```  
  
#### Parameters  
 `_Dest`  
 The string or character array targeted to receive the copied sequence of characters.  
  
 `_Dest_size`  
 The size of `_Dest`. If `char_type` is `char`, then this size is in bytes. If `char_type` is `wchar_t`, then this size is in words.  
  
 `_From`  
 The source string or character array to be copied.  
  
 `_Count`  
 The number of elements to be copied.  
  
## Return Value  
 The string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination character sequences must not overlap.  
  
## Example  
  
```  
// char_traits__Copy_s.cpp  
// compile with: /EHsc  
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
    result1 = char_traits<char>::_Copy_s(s1,  
        char_traits<char>::length(s1), s2, 4);  
    cout << "The result1 = _Copy_s(s1, "  
         << "char_traits<char>::length(s1), s2, 4) is: "  
         << result1 << endl;  
}  
```  
  
 **The source string is: abcd-1234-abcd**  
**The destination string is: ABCD-1234**  
**The result1 = _Copy_s(s1, char_traits\<char>::length(s1), s2, 4) is: ABCD-1234-abcd**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)   
 [Safe Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)