---
title: "endl"
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
  - "std::endl"
  - "ostream/std::endl"
  - "std.endl"
  - "endl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "endl function"
  - "endl"
ms.assetid: 489ac9ac-d37e-4162-a9b7-c5700324bc93
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# endl
Terminates a line and flushes the buffer.  
  
## Syntax  
  
```  
  
   template class<  
   _Elem  
   ,   
   _Tr>  
basic_ostream<_Elem, _Tr>& endl(  
   basic_ostream<_Elem, _Tr>& _Ostr  
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
 The manipulator calls `_Ostr`**.**[put](../vs140/basic_ostream--put.md)(`_Ostr`**.** [widen](../vs140/basic_ios--widen.md)(**'\n'**)), and then calls `_Ostr`**.**[flush](../vs140/basic_ostream--flush.md). It returns `_Ostr`.  
  
## Example  
  
```  
// ostream_endl.cpp  
// compile with: /EHsc  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   cout << "testing" << endl;  
}  
```  
  
 **testing**   
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)