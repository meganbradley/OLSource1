---
title: "IScheduler::Statistics Method"
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
  - "concrtrm/concurrency::IScheduler::Statistics"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Statistics method"
ms.assetid: 88071706-b8ef-4051-81d1-bca22681f74e
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IScheduler::Statistics Method
Provides information related to task arrival and completion rates, and change in queue length for a scheduler.  
  
## Syntax  
  
```  
virtual void Statistics(  
   _Out_ unsigned int * pTaskCompletionRate,  
   _Out_ unsigned int * pTaskArrivalRate,  
   _Out_ unsigned int * pNumberOfTasksEnqueued  
) =0;  
```  
  
#### Parameters  
 `pTaskCompletionRate`  
 The number of tasks that have been completed by the scheduler since the last call to this method.  
  
 `pTaskArrivalRate`  
 The number of tasks that have arrived in the scheduler since the last call to this method.  
  
 `pNumberOfTasksEnqueued`  
 The total number of tasks in all scheduler queues.  
  
## Remarks  
 This method is invoked by the Resource Manager in order to gather statistics for a scheduler. The statistics gathered here will be used to drive dynamic feedback algorithms to determine when it is appropriate to assign more resources to the scheduler and when to take resources away. The values provided by the scheduler can be optimistic and do not necessarily have to reflect the current count accurately.  
  
 You should implement this method if you want the Resource Manager to use feedback about such things as task arrival to determine how to balance resource between your scheduler and other schedulers registered with the Resource Manager. If you choose not to gather statistics, you can set the policy key `DynamicProgressFeedback` to the value `DynamicProgressFeedbackDisabled` in your scheduler's policy, and the Resource Manager will not invoke this method on your scheduler.  
  
 In the absence of statistical information, the Resource Manager will use hardware thread subscription levels to make resource allocation and migration decisions. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)   
 [IExecutionResource::CurrentSubscriptionLevel Method](../vs140/iexecutionresource--currentsubscriptionlevel-method.md)