---
title: "ostrstream::pcount"
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
  - std::ostrstream::pcount
  - ostrstream.pcount
  - ostrstream::pcount
  - std.ostrstream.pcount
  - pcount
dev_langs: 
  - C++
helpviewer_keywords: 
  - pcount method
ms.assetid: dfb0dc29-2aa6-46f9-853b-06368c34678b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ostrstream::pcount
Returns a count of the number of elements written to the controlled sequence.  
  
## Syntax  
  
```  
  
streamsize pcount( ) const;  
  
```  
  
## Return Value  
 The number of elements written to the controlled sequence.  
  
## Remarks  
 The member function returns [rdbuf](../vs140/ostrstream--rdbuf.md) -> [pcount](../vs140/strstreambuf--pcount.md).  
  
## Example  
 See [strstream::pcount](../vs140/strstreambuf--pcount.md) for a sample that uses `pcount`.  
  
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [ostrstream Class](../vs140/ostrstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)