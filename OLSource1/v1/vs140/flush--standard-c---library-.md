---
title: "flush (Standard C++ Library)"
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
  - "std::flush"
  - "ostream/std::flush"
  - "std.flush"
  - "Flush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "flush function"
ms.assetid: 57d3080a-7439-4075-9d04-10410b1bccd7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# flush (Standard C++ Library)
Flushes the buffer.  
  
## Syntax  
  
```  
  
   template class<  
   _Elem  
   ,   
   _Tr  
   >  
basic_ostream<_Elem, _Tr>&   
flush(basic_ostream<_Elem, _Tr>& _Ostr  
);  
```  
  
#### Parameters  
 `_Elem`  
 The element type.  
  
 `_Ostr`  
 An object of type `basic_ostream`.  
  
 `_Tr`  
 Character traits.  
  
## Return Value  
 An object of type `basic_ostream`.  
  
## Remarks  
 The manipulator calls `_Ostr`**.**[flush](../vs140/basic_ostream--flush.md). It returns `_Ostr`.  
  
## Example  
  
```  
// ostream_flush.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   cout << "testing" << flush;  
}  
```  
  
 **testing**   
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)