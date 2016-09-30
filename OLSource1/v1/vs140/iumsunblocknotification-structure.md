---
title: "IUMSUnblockNotification Structure"
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
  - "concrtrm/concurrency::IUMSUnblockNotification"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IUMSUnblockNotification structure"
ms.assetid: eaca9529-c1cc-472b-8ec6-722a1ff0fa2a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IUMSUnblockNotification Structure
Represents a notification from the Resource Manager that a thread proxy which blocked and triggered a return to the scheduler's designated scheduling context has unblocked and is ready to be scheduled. This interface is invalid once the thread proxy's associated execution context, returned from the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method, is rescheduled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IUMSUnblockNotification::GetContext Method](#iumsunblocknotification__getcontext_method)|Returns the                                         <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface for the execution context associated with the thread proxy which has unblocked. Once this method returns and the underlying execution context has been rescheduled via a call to the                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method, this interface is no longer valid.|  
|[IUMSUnblockNotification::GetNextUnblockNotification Method](#iumsunblocknotification__getnextunblocknotification_method)|Returns the next                                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface in the chain returned from the method                                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="iumsunblocknotification__getcontext_method">\</a>  IUMSUnblockNotification::GetContext Method  
 Returns the                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface for the execution context associated with the thread proxy which has unblocked. Once this method returns and the underlying execution context has been rescheduled via a call to the                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method, this interface is no longer valid.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 An                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface for the execution context to a thread proxy which has unblocked.  
  
##  \<a name="iumsunblocknotification__getnextunblocknotification_method">\</a>  IUMSUnblockNotification::GetNextUnblockNotification Method  
 Returns the next                 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface in the chain returned from the method                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 The next                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface in the chain returned from the method                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IUMSScheduler Structure](../vs140/iumsscheduler-structure.md)   
 [IUMSCompletionList Structure](../vs140/iumscompletionlist-structure.md)