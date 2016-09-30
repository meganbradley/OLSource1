---
title: "thread::joinable Method"
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
  - "thread/std::thread::joinable"
dev_langs: 
  - "C++"
ms.assetid: dcbf934b-9260-4cce-89d5-5d1cdb2768d6
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread::joinable Method
Specifies whether the associated thread is *joinable*.  
  
## Syntax  
  
```  
bool joinable() const _NOEXCEPT;  
```  
  
## Return Value  
 `true` if the associated thread is *joinable*; otherwise, `false`.  
  
## Remarks  
 A thread object is *joinable* if `get_id() != id()`.  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
## See Also  
 [thread Class](../vs140/thread-class.md)   
 [\<thread>](../vs140/-thread-.md)   
 [thread::get_id Method](../vs140/thread--get_id-method.md)   
 [thread::id Class](../vs140/thread--id-class.md)