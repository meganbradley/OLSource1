---
title: "char_traits::eof"
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
  - "std.char_traits.eof"
  - "char_traits.eof"
  - "std::char_traits::eof"
  - "EOF"
  - "iosfwd/std::char_traits::eof"
  - "char_traits::eof"
  - "eof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "eof method"
ms.assetid: 3eef7544-48e4-49c0-9501-d3c5a8e43a70
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::eof
Returns the end-of-file (EOF) character.  
  
## Syntax  
  
```  
static int_type eof();  
```  
  
## Return Value  
 The EOF character.  
  
## Remarks  
 A value that represents end of file (such as `EOF` or `WEOF`).  
  
 The C++ standard states that this value must not correspond to a valid `char_type` value. The Visual C++ compiler enforces this constraint for type `char`, but not for type `wchar_t`. The example below demonstrates this.  
  
## Example  
  
```  
// char_traits_eof.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
  
    char_traits<char>::char_type ch1 = 'x';  
    char_traits<char>::int_type int1;  
    int1 = char_traits<char>::to_int_type(ch1);  
    cout << "char_type ch1 is '" << ch1 << "' and corresponds to int_type "  
         << int1 << "." << endl << endl;  
  
    char_traits<char>::int_type int2 = char_traits<char>::eof();  
    cout << "The eof marker for char_traits<char> is: " << int2 << endl;  
  
    char_traits<wchar_t>::int_type int3 = char_traits<wchar_t>::eof();  
    cout << "The eof marker for char_traits<wchar_t> is: " << int3 << endl;  
}  
```  
  
 **char_type ch1 is 'x' and corresponds to int_type 120.**  
**The eof marker for char_traits<char\> is: -1**  
**The eof marker for char_traits<wchar_t> is: 65535**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)