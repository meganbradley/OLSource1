---
title: "unique_lock::operator= Operator"
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
  - "mutex/std::unique_lock::operator="
dev_langs: 
  - "C++"
ms.assetid: 8d1e7044-19f4-4b87-8a4c-aa329b1e5371
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::operator= Operator
Copies the stored `mutex` pointer and associated ownership status from a specified object.  
  
## Syntax  
  
```cpp  
unique_lock& operator=(  
   unique_lock&& Other  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Other`  
 A `unique_lock` object.  
  
## Return Value  
 `*this`  
  
## Remarks  
 If the calling thread owns the previously associated `mutex`, before this method calls `unlock` on the `mutex`, it assigns the new values.  
  
 After the copy, this method sets `Other` to a default-constructed state.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)