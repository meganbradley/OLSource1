---
title: "streampos"
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
  - "std.streampos"
  - "streampos"
  - "ios_base.streampos"
  - "std::streampos"
  - "xiosbase/std::ios_base::streampos"
  - "ios_base::streampos"
  - "std.ios_base.streampos"
  - "std::ios_base::streampos"
  - "iosfwd/std::streampos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "streampos typedef"
ms.assetid: af527446-1ee7-4613-82b6-3ff793c4802e
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# streampos
Holds the current position of the buffer pointer or file pointer.  
  
## Syntax  
  
```  
  
typedef fpos<mbstate  
_  
t> streampos;  
  
```  
  
## Remarks  
 The type is a synonym for [fpos](../vs140/fpos-class.md)<`mbstate_t`>.  
  
## Example  
  
```  
// ios_streampos.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
  
   ofstream x( "iostream.txt" );  
   x << "testing";  
   streampos y = x.tellp( );  
   cout << y << endl;  
}  
```  
  
 **7**   
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)