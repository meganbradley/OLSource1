---
title: "packaged_task::operator() Operator"
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
  - "future/std::packaged_task::operator()"
dev_langs: 
  - "C++"
ms.assetid: b880b3ed-836c-4191-9b5f-9a49529f91e3
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# packaged_task::operator() Operator
Calls the callable object that's stored in the *associated asynchronous state*, atomically stores the returned value, and sets the state to *ready*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object doesn't have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 If this method or [make_ready_at_thread_exit](../vs140/packaged_task--make_ready_at_thread_exit-method.md) has already been called for a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that has the same associated asynchronous state, the method throws a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 Otherwise, this operator calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, where *fn* is the callable object that's stored in the associated asynchronous state. Any returned value is stored atomically as the returned result of the associated asynchronous state, and the state is set to ready. As a result, any threads that are blocked on the associated asynchronous state become unblocked.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [packaged_task Class](../vs140/packaged_task-class.md)   
 [\<future>](../vs140/-future-.md)