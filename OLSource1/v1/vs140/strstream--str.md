---
title: "strstream::str"
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
  - "std::strstream::str"
  - "Str"
  - "strstream.str"
  - "std.strstream.str"
  - "strstream::str"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "str method"
ms.assetid: 47770be1-4b9f-419e-af03-7c1232f20d31
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstream::str
Calls [freeze](../vs140/strstreambuf--freeze.md), and then returns a pointer to the beginning of the controlled sequence.  
  
## Syntax  
  
```  
  
char *str( );  
  
```  
  
## Return Value  
 A pointer to the beginning of the controlled sequence.  
  
## Remarks  
 The member function returns [rdbuf](../vs140/strstream--rdbuf.md) -> [str](../vs140/strstreambuf--str.md).  
  
## Example  
 See [strstreambuf::str](../vs140/strstreambuf--str.md) for a sample that uses **str**.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstream Class](../vs140/strstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)