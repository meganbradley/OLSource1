---
title: "unique_lock::operator bool Operator"
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
  - "mutex/std::unique_lock::operator bool"
dev_langs: 
  - "C++"
ms.assetid: 669d6d6a-b4ca-494c-8b27-9998d460171d
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::operator bool Operator
Specifies whether the calling thread has ownership of the associated mutex.  
  
## Syntax  
  
```cpp  
explicit operator bool() _NOEXCEPT  
```  
  
## Return Value  
 `true` if the thread owns the mutex; otherwise `false`.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [<mutex\>](../vs140/-mutex-.md)