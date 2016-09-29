---
title: "char_traits::_Move_s"
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
  - "std.char_traits._Move_s"
  - "_Move_s"
  - "string/std::char_traits::_Move_s"
  - "std::char_traits::_Move_s"
  - "char_traits::_Move_s"
  - "char_traits._Move_s"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_Move_s method"
ms.assetid: 6c0d3731-c4d3-453e-b710-c696774808e1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::_Move_s
Copies a specified number of characters in a sequence to another, possibly overlapping sequence.  
  
## Syntax  
  
```  
static char_type *_Move_s(  
    char_type *_Dest,  
    size_t _Dest_size,  
    const char_type *_From,  
    size_t _Count  
);  
```  
  
#### Parameters  
 `_Dest`  
 The element at the beginning of the string or character array targeted to receive the copied sequence of characters.  
  
 `_Dest_size`  
 The size of `_Dest`. If `char_type` is `char`, then this is in bytes. If `char_type` is `wchar_t`, then this is in words.  
  
 `_From`  
 The element at the beginning of the source string or character array to be copied.  
  
 `_Count`  
 The number of elements to be copied from the source string.  
  
## Return Value  
 The first element `_Dest` copied into the string or character array targeted to receive the copied sequence of characters.  
  
## Remarks  
 The source and destination may overlap.  
  
## Example  
  
```  
// char_traits__Move_s.cpp  
// compile with: /EHsc  
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
    result1 = char_traits<char>::_Move_s(sTo1,  
        char_traits<char>::length(sTo1), sFrom1, 4);  
    cout << "The result1 = _Move_s(sTo1, "  
         << "char_traits<char>::length(sTo1), sFrom1, 4) is: "  
         << result1 << endl << endl;  
  
    // When source and destination overlap  
    char_traits<char>::char_type sToFrom2[] = "abcd-1234-ABCD";  
    char_traits<char>::char_type* result2;  
    cout << "The source/destination string sToFrom2 is: "  
         << sToFrom2 << endl;  
    const char* findc = char_traits<char>::find(sToFrom2, 4, 'c');  
    result2 = char_traits<char>::_Move_s(sToFrom2,  
        char_traits<char>::length(sToFrom2), findc, 8);  
    cout << "The result2 = _Move_s(sToFrom2, "  
        << "char_traits<char>::length(sToFrom2), findc, 8) is: "  
         << result2 << endl;  
}  
```  
  
 **The source string sFrom1 is: abcd-1234-abcd**  
**The destination stringsTo1 is: ABCD-1234**  
**The result1 = _Move_s(sTo1, char_traits\<char>::length(sTo1), sFrom1, 4) is: abcd-1234**  
**The source/destination string sToFrom2 is: abcd-1234-ABCD**  
**The result2 = _Move_s(sToFrom2, char_traits\<char>::length(sToFrom2), findc, 8) is: cd-1234-4-ABCD**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)   
 [Safe Standard C++ Library](../vs140/safe-libraries--c---standard-library.md)