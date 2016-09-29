---
title: "ISchedulerProxy::UnbindContext Method"
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
  - "concrtrm/concurrency::ISchedulerProxy::UnbindContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnbindContext method"
ms.assetid: c5ff052b-09e2-4be3-aaf8-1255b3488bcb
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISchedulerProxy::UnbindContext Method
Disassociates a thread proxy from the execution context specified by the `pContext` parameter and returns it to the thread proxy factory's free pool. This method may only be called on an execution context which was bound via the [ISchedulerProxy::BindContext](../vs140/ischedulerproxy--bindcontext-method.md) method and has not yet been started via being the `pContext` parameter of an [IThreadProxy::SwitchTo](../vs140/ithreadproxy--switchto-method.md) method call.  
  
## Syntax  
  
```  
virtual void UnbindContext(  
   _Inout_ IExecutionContext * pContext  
) =0;  
```  
  
#### Parameters  
 `pContext`  
 The execution context to disassociate from its thread proxy.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISchedulerProxy Structure](../vs140/ischedulerproxy-structure.md)