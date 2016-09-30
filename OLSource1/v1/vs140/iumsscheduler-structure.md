---
title: "IUMSScheduler Structure"
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
  - "concrtrm/concurrency::IUMSScheduler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IUMSScheduler structure"
ms.assetid: 3a500225-4e02-4849-bb56-d744865f5870
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IUMSScheduler Structure
An interface to an abstraction of a work scheduler that wants the Concurrency Runtime's Resource Manager to hand it user-mode schedulable (UMS) threads. The Resource Manager uses this interface to communicate with UMS thread schedulers. The             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface inherits from the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IUMSScheduler::SetCompletionList Method](#iumsscheduler__setcompletionlist_method)|Assigns an                                         <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface to a UMS thread scheduler.|  
  
## Remarks  
 If you are implementing a custom scheduler that communicates with the Resource Manager, and you want UMS threads to be handed to your scheduler instead of ordinary Win32 threads, you should provide an implementation of the                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface. In addition, you should set the policy value for the scheduler policy key                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to be                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If the policy specifies UMS thread, the                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface that is passed as a parameter to the                 [IResourceManager::RegisterScheduler](../vs140/iresourcemanager-structure.md#iresourcemanager__registerscheduler_method) method must be an                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface.  
  
 The Resource Manager is able to hand you UMS threads only on operating systems that have the UMS feature. 64-bit operating systems with version Windows 7 and higher support UMS threads. If you create a scheduler policy with the                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> key set to the value                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the underlying platform does not support UMS, the value of the                 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> key on that policy will be changed to the value                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. You should always read back this policy value before expecting to receive UMS threads.  
  
 The                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface is one end of a two-way channel of communication between a scheduler and the Resource Manager. The other end is represented by the                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interfaces, which are implemented by the Resource Manager.  
  
## Inheritance Hierarchy  
 [IScheduler](../vs140/ischeduler-structure.md)  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="iumsscheduler__setcompletionlist_method">\</a>  IUMSScheduler::SetCompletionList Method  
 Assigns an                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface to a UMS thread scheduler.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The completion list interface for the scheduler. There is a single list per scheduler.  
  
### Remarks  
 The Resource Manager will invoke this method on a scheduler that specifies it wants UMS threads, after the scheduler has requested an initial allocation of resources. The scheduler can use the                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> interface to determine when UMS thread proxies have unblocked. It is only valid to access this interface from a thread proxy running on a virtual processor root assigned to the UMS scheduler.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations)   
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IUMSCompletionList Structure](../vs140/iumscompletionlist-structure.md)   
 [IResourceManager Structure](../vs140/iresourcemanager-structure.md)