---
title: "ostrstream::rdbuf"
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
  - "ostrstream.rdbuf"
  - "std::ostrstream::rdbuf"
  - "ostrstream::rdbuf"
  - "rdbuf"
  - "std.ostrstream.rdbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rdbuf method"
ms.assetid: 6bdfac99-4d3e-42ad-a91e-b35c5c7a9e99
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostrstream::rdbuf
Returns a pointer to the stream's associated strstreambuf object.  
  
## Syntax  
  
```  
  
strstreambuf *rdbuf( ) const  
  
```  
  
## Return Value  
 A pointer to the stream's associated strstreambuf object.  
  
## Remarks  
 The member function returns the address of the stored stream buffer of type **pointer** to [strstreambuf](../vs140/strstreambuf-class.md).  
  
## Example  
 See [strstreambuf::pcount](../vs140/strstreambuf--pcount.md) for a sample that uses `rdbuf`.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [ostrstream Class](../vs140/ostrstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)