---
title: "strstreambuf::overflow"
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
  - "std.strstreambuf.overflow"
  - "strstreambuf::overflow"
  - "overflow"
  - "strstreambuf.overflow"
  - "std::strstreambuf::overflow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "overflow method"
ms.assetid: 8d915bcc-c8b1-4787-958d-3604c9ea1b27
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::overflow
A protected virtual function that can be called when a new character is inserted into a full buffer.  
  
## Syntax  
  
```  
  
      virtual int overflow(  
   int _Meta = EOF  
);  
```  
  
#### Parameters  
 `_Meta`  
 The character to insert into the buffer, or `EOF`.  
  
## Return Value  
 If the function cannot succeed, it returns `EOF`. Otherwise, if _*Meta* == `EOF`, it returns some value other than `EOF`. Otherwise, it returns \_*Meta*.  
  
## Remarks  
 If _*Meta* != `EOF`, the protected virtual member function tries to insert the element (`char`)\_*Meta* into the output buffer. It can do so in various ways:  
  
-   If a write position is available, it can store the element into the write position and increment the next pointer for the output buffer.  
  
-   If the stored strstreambuf mode says the controlled sequence is modifiable, extendable, and not frozen, the function can make a write position available by allocating new for the output buffer. Extending the output buffer this way also extends any associated input buffer.  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)