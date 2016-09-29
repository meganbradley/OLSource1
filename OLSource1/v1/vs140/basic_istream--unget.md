---
title: "basic_istream::unget"
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
  - "std::basic_istream::unget"
  - "std.basic_istream.unget"
  - "basic_istream::unget"
  - "basic_istream.unget"
  - "istream/std::basic_istream::unget"
  - "unget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unget method"
ms.assetid: c5735f04-0d25-404a-9b9b-0f0af81afd25
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::unget
Puts the most recently read character back into the stream.  
  
## Syntax  
  
```  
basic_istream<Elem, Tr>& unget( );  
```  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The [unformatted input function](../vs140/basic_istream-class.md) puts back the previous element in the stream, if possible, as if by calling `rdbuf` ->[sungetc](../vs140/basic_streambuf--sungetc.md). If [rdbuf](../vs140/basic_ios--rdbuf.md) is a null pointer, or if the call to `sungetc` returns **traits_type::**[eof](../vs140/basic_ios--eof.md), the function calls [setstate](../vs140/basic_ios--setstate.md)(**badbit**). In any case, it returns **\*this**.  
  
 For information on how `unget` might fail, see [basic_streambuf::sungetc](../vs140/basic_streambuf--sungetc.md).  
  
## Example  
  
```  
// basic_istream_unget.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main( )   
{  
   char c[10], c2;  
  
   cout << "Type 'abc': ";  
   c2 = cin.get( );  
   cin.unget( );  
   cin.getline( &c[0], 9 );  
   cout << c << endl;  
}  
```  
  
  **`abc` `abc`Type 'abc': abc**  
**abc**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)