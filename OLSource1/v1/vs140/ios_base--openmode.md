---
title: "ios_base::openmode"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - openmode
  - std.ios_base.openmode
  - ios_base::openmode
  - ios_base.openmode
  - OpenMode
  - std::ios_base::openmode
  - xiosbase/std::ios_base::openmode
dev_langs: 
  - C++
helpviewer_keywords: 
  - openmode typedef
ms.assetid: d1093dac-925f-418b-9172-f96d243b9e3a
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ios_base::openmode
Describes how to interact with a stream.  
  
## Syntax  
  
```  
namespace std {  
   class ios_base {  
   public:  
      typedef implementation-defined-bitmask-type iostate;  
      static const iostate badbit;  
      static const iostate eofbit;  
      static const iostate failbit;  
      static const iostate goodbit;  
      ...  
   };  
}  
```  
  
## Remarks  
 The type is a `bitmask type` that describes an object that can store the opening mode for several iostreams objects. The distinct flag values (elements) are:  
  
-   **app**, to seek to the end of a stream before each insertion.  
  
-   **ate**, to seek to the end of a stream when its controlling object is first created.  
  
-   **binary**, to read a file as a binary stream, rather than as a text stream.  
  
-   **in**, to permit extraction from a stream.  
  
-   **out**, to permit insertion to a stream.  
  
-   **trunc**, to delete contents of an existing file when its controlling object is created.  
  
## Example  
  
```  
// ios_base_openmode.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main ( )   
{  
   using namespace std;  
   fstream file;  
   file.open( "rm.txt", ios_base::out | ios_base::trunc );  
  
   file << "testing";  
}  
```  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)