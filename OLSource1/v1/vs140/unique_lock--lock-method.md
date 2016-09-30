---
title: "unique_lock::lock Method"
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
  - "mutex/std::unique_lock::lock"
dev_langs: 
  - "C++"
ms.assetid: 71ded894-2ed9-4a66-9460-1331c9da334b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::lock Method
Blocks the calling thread until the thread obtains ownership of the associated `mutex`.  
  
## Syntax  
  
```cpp  
void lock();  
```  
  
## Remarks  
 If the stored `mutex` pointer is `null`, this method throws a [system_error](../vs140/system_error-class.md) that has an error code of `operation_not_permitted`.  
  
 If the calling thread already owns the associated `mutex`, this method throws a `system_error` that has an error code of `resource_deadlock_would_occur`.  
  
 Otherwise, this method calls `lock` on the associated `mutex` and sets the internal thread ownership flag to `true`.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)