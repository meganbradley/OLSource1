---
title: "packaged_task::operator= Operator"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - future/std::packaged_task::operator=
dev_langs: 
  - C++
ms.assetid: bf0f6948-5c68-4921-87eb-cff9d5aa1c82
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# packaged_task::operator= Operator
Transfers the *associated asynchronous state* from a specified object.  
  
## Syntax  
  
```cpp  
packaged_task& operator=(packaged_task&& Right);  
```  
  
#### Parameters  
 `Right`  
 A `packaged_task` object.  
  
## Return Value  
 `*this`  
  
## Remarks  
 After the operation, `Right` no longer has an associated asynchronous state.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [packaged_task Class](../vs140/packaged_task-class.md)   
 [<future\>](../vs140/-future-.md)