---
title: "ios_base::seekdir"
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
  - "std::ios_base::seekdir"
  - "ios_base.seekdir"
  - "std.ios_base.seekdir"
  - "xiosbase/std::ios_base::seekdir"
  - "seekdir"
  - "ios_base::seekdir"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekdir typedef"
ms.assetid: a06022b3-f048-4139-b5fc-bb4f3ef804b6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::seekdir
Specifies starting point for offset operations.  
  
## Syntax  
  
```  
namespace std {  
   class ios_base {  
   public:  
      typedef implementation-defined-enumerated-type seekdir;  
      static const seekdir beg;  
      static const seekdir cur;  
      static const seekdir end;  
      ...  
   };  
}  
```  
  
## Remarks  
 The type is an enumerated type that describes an object that can store the seek mode used as an argument to the member functions of several iostream classes. The distinct flag values are:  
  
-   **beg**, to seek (alter the current read or write position) relative to the beginning of a sequence (array, stream, or file).  
  
-   **cur**, to seek relative to the current position within a sequence.  
  
-   **end**, to seek relative to the end of a sequence.  
  
## Example  
  
```  
// ios_base_seekdir.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main ( )   
{  
   using namespace std;  
   fstream file;  
   file.open( "rm.txt", ios_base::out | ios_base::trunc );  
  
   file << "testing";  
   file.seekp( 0, ios_base::beg );  
   file << "a";  
   file.seekp( 0, ios_base::end );  
   file << "a";  
}  
```  
  
## Contents of File  
  
```  
aestinga  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)