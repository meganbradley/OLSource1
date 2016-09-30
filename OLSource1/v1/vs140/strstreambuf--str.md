---
title: "strstreambuf::str"
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
  - "strstreambuf.str"
  - "std.strstreambuf.str"
  - "Str"
  - "strstreambuf::str"
  - "std::strstreambuf::str"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "str method"
ms.assetid: 8a05e1cd-0988-464b-b3b7-2ceab187f65e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::str
Calls [freeze](../vs140/strstreambuf--freeze.md), and then returns a pointer to the beginning of the controlled sequence.  
  
## Syntax  
  
```  
  
char *str( );  
  
```  
  
## Return Value  
 A pointer to the beginning of the controlled sequence.  
  
## Remarks  
 No terminating null element exists, unless you explicitly insert one.  
  
## Example  
 See [strstreambuf::freeze](../vs140/strstreambuf--freeze.md) for a sample that uses **str**.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)