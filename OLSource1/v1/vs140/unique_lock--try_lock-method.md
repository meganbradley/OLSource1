---
title: "unique_lock::try_lock Method"
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
  - "mutex/std::unique_lock::try_lock"
dev_langs: 
  - "C++"
ms.assetid: 5ab2cf55-089f-4e60-83b3-697e4e2d8c22
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::try_lock Method
Attempts to obtain ownership of the associated `mutex` without blocking.  
  
## Syntax  
  
```cpp  
bool try_lock() _NOEXCEPT;  
```  
  
## Return Value  
 `true` if the method successfully obtains ownership of the `mutex`; otherwise, `false`.  
  
## Remarks  
 If the stored `mutex` pointer is `null`, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of `operation_not_permitted`.  
  
 If the calling thread already owns the `mutex`, the method throws a `system_error` that has an error code of `resource_deadlock_would_occur`.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)