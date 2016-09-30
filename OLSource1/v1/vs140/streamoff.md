---
title: "streamoff"
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
  - "ios_base.streamoff"
  - "ios_base::streamoff"
  - "std.ios_base.streamoff"
  - "streamoff"
  - "iosfwd/std::streamoff"
  - "std::streamoff"
  - "std.streamoff"
  - "xiosbase/std::ios_base::streamoff"
  - "std::ios_base::streamoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "streamoff typedef"
ms.assetid: 3f28a490-ed94-456d-a1a7-3f15348e8fce
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# streamoff
Supports internal operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a signed integer that describes an object that can store a byte offset involved in various stream positioning operations. Its representation has at least 32 value bits. It is not necessarily large enough to represent an arbitrary byte position within a stream. The value **streamoff(-1)** generally indicates an erroneous offset.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)