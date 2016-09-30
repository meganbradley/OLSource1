---
title: "Context::Block Method"
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
  - "concrt/concurrency::Context::Block"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Block method"
ms.assetid: 9c7a473a-dbea-4d08-961d-114223c4e135
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::Block Method
Blocks the current context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
 If the calling context is running on a virtual processor, the virtual processor will find another runnable context to execute or can potentially create a new one.  
  
 After the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method has been called or will be called, you must pair it with a call to the [Unblock](../vs140/context--unblock-method.md) method from another execution context in order for it to run again. Be aware that there is a critical period between the point where your code publishes its context for another thread to be able to call the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method and the point where the actual method call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is made. During this period, you must not call any method which can in turn block and unblock for its own reasons (for example, acquiring a lock). Calls to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method do not track the reason for the blocking and unblocking. Only one object should have ownership of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pair.  
  
 This method can throw a variety of exceptions, including [scheduler_resource_allocation_error](../vs140/scheduler_resource_allocation_error-class.md).  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../vs140/context-class.md)   
 [Context::Unblock Method](../vs140/context--unblock-method.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)