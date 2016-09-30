---
title: "critical_section::try_lock_for Method"
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
  - "concrt/concurrency::critical_section::try_lock_for"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "try_lock_for method"
ms.assetid: 831d7fe2-d560-467c-b784-20874f5dc02b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# critical_section::try_lock_for Method
Tries to acquire the lock without blocking for a specific number of milliseconds.  
  
## Syntax  
  
```  
bool try_lock_for(  
   unsigned int _Timeout  
);  
```  
  
#### Parameters  
 `_Timeout`  
 The number of milliseconds to wait before timing out.  
  
## Return Value  
 If the lock was acquired, the value `true`; otherwise, the value `false`.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [critical_section Class](../vs140/critical_section-class.md)   
 [critical_section::unlock Method](../vs140/critical_section--unlock-method.md)