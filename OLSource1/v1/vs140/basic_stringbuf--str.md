---
title: "basic_stringbuf::str"
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
  - "std.basic_stringbuf.str"
  - "Str"
  - "str"
  - "basic_stringbuf.str"
  - "sstream/std::basic_stringbuf::str"
  - "basic_stringbuf::str"
  - "std::basic_stringbuf::str"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "str method"
ms.assetid: b62ccd8f-8d2c-44b5-9112-24aa72454ebf
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::str
Sets or gets the text in a string buffer without changing the write position.  
  
## Syntax  
  
```  
basic_string<Elem, Tr, Alloc> str( ) const;  
void str(  
    const basic_string<Elem, Tr, Alloc>& _Newstr  
);  
```  
  
#### Parameters  
 `_Newstr`  
 The new string.  
  
## Return Value  
 Returns an object of class [basic_string](../vs140/basic_string-class.md)<**Elem**, **Tr**, Alloc**>,** whose controlled sequence is a copy of the sequence controlled by **\*this**.  
  
## Remarks  
 The first member function returns an object of class basic_string<**Elem**, **Tr**, `Alloc`>, whose controlled sequence is a copy of the sequence controlled by **\*this**. The sequence copied depends on the stored stringbuf mode:  
  
-   If **mode & ios_base::out** is nonzero and an output buffer exists, the sequence is the entire output buffer ([epptr](../vs140/basic_streambuf--epptr.md) - [pbase](../vs140/basic_streambuf--pbase.md) elements beginning with `pbase`).  
  
-   If **mode & ios_base::in** is nonzero and an input buffer exists, the sequence is the entire input buffer ([egptr](../vs140/basic_streambuf--egptr.md) - [eback](../vs140/basic_streambuf--eback.md) elements beginning with `eback`).  
  
-   Otherwise, the copied sequence is empty.  
  
 The second member function deallocates any sequence currently controlled by **\*this**. It then allocates a copy of the sequence controlled by `_Newstr`. If **mode & ios_base::in** is nonzero, it sets the input buffer to start reading at the beginning of the sequence. If **mode & ios_base::out** is nonzero, it sets the output buffer to start writing at the beginning of the sequence.  
  
## Example  
  
```  
// basic_stringbuf_str.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <sstream>  
  
using namespace std;  
  
int main( )   
{  
   basic_string<char> i( "test" );  
   stringstream ss;  
  
   ss.rdbuf( )->str( i );  
   cout << ss.str( ) << endl;  
  
   ss << "z";  
   cout << ss.str( ) << endl;  
  
   ss.rdbuf( )->str( "be" );  
   cout << ss.str( ) << endl;  
}  
```  
  
 **test**  
**zest**  
**be**   
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)