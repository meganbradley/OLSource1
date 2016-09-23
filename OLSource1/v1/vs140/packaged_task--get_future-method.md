---
title: "packaged_task::get_future Method"
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
  - future/std::packaged_task::get_future
dev_langs: 
  - C++
ms.assetid: c9e7fdfb-0008-45d0-acc0-701c197fbd7f
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# packaged_task::get_future Method
Returns an object of type `future<Ty>` that has the same *associated asynchronous state*.  
  
## Syntax  
  
```cpp  
future<Ty> get_future();  
```  
  
## Remarks  
 If the `packaged_task` object does not have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of `no_state`.  
  
 If this method has already been called for a `packaged_task` object that has the same associated asynchronous state, the method throws a `future_error` that has an error code of `future_already_retrieved`.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [packaged_task Class](../vs140/packaged_task-class.md)   
 [<future\>](../vs140/-future-.md)   
 [future Class](../vs140/future-class.md)