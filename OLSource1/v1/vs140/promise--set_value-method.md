---
title: "promise::set_value Method"
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
  - "future/std::promise::set_value"
dev_langs: 
  - "C++"
ms.assetid: 6d7edbbc-a42c-449a-a881-3b9427e87bb9
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# promise::set_value Method
Atomically stores a value as the result of this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and sets the *associated asynchronous state* to *ready*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to be stored as the result.  
  
## Remarks  
 If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object has no associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 If [set_exception](../vs140/promise--set_exception-method.md), [set_exception_at_thread_exit](../Topic/promise::set_exception_at_thread_exit%20Method_deleted.md), <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or [set_value_at_thread_exit](../Topic/promise::set_value_at_thread_exit%20Method_deleted.md) has already been called for a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that has the same associated asynchronous state, this method throws a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 As a result of this method, any threads that are blocked on the associated asynchronous state become unblocked.  
  
 The first method also throws any exception that is thrown when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is copied into the associated asynchronous state. In this situation, the associated asynchronous state is not set to ready.  
  
 The second method also throws any exception that is thrown when <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is moved into the associated asynchronous state. In this situation, the associated asynchronous state is not set to ready.  
  
 For the partial specialization <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the stored value is in effect a reference to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For the specialization <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, no stored value exists.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [promise Class](../vs140/promise-class.md)   
 [\<future>](../vs140/-future-.md)