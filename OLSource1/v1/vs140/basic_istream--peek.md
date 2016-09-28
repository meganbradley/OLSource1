---
title: "basic_istream::peek"
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
  - "std::basic_istream::peek"
  - "std.basic_istream.peek"
  - "basic_istream.peek"
  - "basic_istream::peek"
  - "peek"
  - "istream/std::basic_istream::peek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "peek method"
ms.assetid: 46bbcc99-bfc1-483c-a9fa-683ffdcc42b8
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::peek
Returns the next character to be read.  
  
## Syntax  
  
```  
  
int  
_  
type peek( );  
  
```  
  
## Return Value  
 The next character that will be read.  
  
## Remarks  
 The unformatted input function extracts an element, if possible, as if by returning `rdbuf` ->[sgetc](../vs140/basic_streambuf--sgetc.md). Otherwise, it returns **traits_type::**[eof](../vs140/char_traits--eof.md).  
  
## Example  
  
```  
// basic_istream_peek.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main( )   
{  
   char c[10], c2;  
   cout << "Type 'abcde': ";  
  
   c2 = cin.peek( );  
   cin.getline( &c[0], 9 );  
  
   cout << c2 << " " << c << endl;  
}  
```  
  
  **`abcde` `abcde`Type 'abcde': abcde**  
**a abcde**   
## Requirements  
 **Header:** <istream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)