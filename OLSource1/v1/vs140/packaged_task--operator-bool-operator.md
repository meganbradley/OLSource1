---
title: "packaged_task::operator bool Operator"
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
  - "future/std::packaged_task::operator bool"
dev_langs: 
  - "C++"
ms.assetid: e6feeeb6-66cb-4efe-b334-8072daa8a27e
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# packaged_task::operator bool Operator
Specifies whether the object has an `associated asynchronous state`.  
  
## Syntax  
  
```cpp  
operator bool() const _NOEXCEPT;  
```  
  
## Return Value  
 `true` if the object has an associated asynchronous state; otherwise, `false`.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [packaged_task Class](../vs140/packaged_task-class.md)   
 [<future\>](../vs140/-future-.md)