---
title: "streamsize"
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
  - "iosfwd/std::streamsize"
  - "streamsize"
  - "std.streamsize"
  - "std::streamsize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "streamsize typedef"
ms.assetid: a1e01923-885b-4139-8150-67b34b969729
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# streamsize
Denotes the size of the stream.  
  
## Syntax  
  
```  
#ifdef _WIN64  
    typedef __int64 streamsize;  
#else  
    typedef int streamsize;  
#endif  
```  
  
## Remarks  
 The type is a signed integer that describes an object that can store a count of the number of elements involved in various stream operations. Its representation has at least 16 bits. It is not necessarily large enough to represent an arbitrary byte position within a stream.  
  
## Example  
 After compiling and running the following program, look at the file test.txt to see the effect of setting `streamsize`.  
  
```  
// ios_streamsize.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
   char a[16] = "any such text";  
   ofstream x( "test.txt" );  
   streamsize y = 6;  
   x.write( a, y );  
}  
```  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)