---
title: "operator== Operator (&lt;thread&gt;)"
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
  - "thread/std::operator=="
dev_langs: 
  - "C++"
ms.assetid: 98650256-4de8-4c2e-b2ce-0089656dcfe1
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== Operator (&lt;thread&gt;)
Compares two `thread::id` objects for equality.  
  
## Syntax  
  
```cpp  
bool operator== (  
   thread::id Left,  
   thread::id Right) _NOEXCEPT  
```  
  
#### Parameters  
 `Left`  
 The left `thread::id` object.  
  
 `Right`  
 The right `thread::id` object.  
  
## Return Value  
 `true` if the two objects represent the same thread of execution or if neither object represents a thread of execution; otherwise, `false`.  
  
## Remarks  
 This function does not throw any exceptions.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<thread>](../vs140/-thread-.md)