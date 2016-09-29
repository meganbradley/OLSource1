---
title: "istrstream::str"
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
  - "std::istrstream::str"
  - "std.istrstream.str"
  - "Str"
  - "istrstream::str"
  - "istrstream.str"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "str method"
ms.assetid: ccc2b54a-bf46-4042-81c0-b5fc3c9b6045
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istrstream::str
Calls [freeze](../vs140/strstreambuf--freeze.md), and then returns a pointer to the beginning of the controlled sequence.  
  
## Syntax  
  
```  
  
char *str( );  
  
```  
  
## Return Value  
 A pointer to the beginning of the controlled sequence.  
  
## Remarks  
 The member function returns [rdbuf](../vs140/istrstream--rdbuf.md) -> [str](../vs140/strstreambuf--str.md).  
  
## Example  
 See [strstream::str](../vs140/strstreambuf--str.md) for a sample that uses **str**.  
  
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [istrstream Class](../vs140/istrstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)