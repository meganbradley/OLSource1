---
title: "IExecutionContext::SetProxy Method"
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
  - concrtrm/concurrency::IExecutionContext::SetProxy
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetProxy method
ms.assetid: cab47a51-6cba-4242-a8d0-64264956358b
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IExecutionContext::SetProxy Method
Associates a thread proxy with this execution context. The associated thread proxy invokes this method right before it starts executing the context's `Dispatch` method.  
  
## Syntax  
  
```  
virtual void SetProxy(  
   _Inout_ IThreadProxy * pThreadProxy  
) =0;  
```  
  
#### Parameters  
 `pThreadProxy`  
 An interface to the thread proxy that is about to enter the `Dispatch` method on this execution context.  
  
## Remarks  
 You are expected to save the parameter `pThreadProxy` and return it on a call to the `GetProxy` method. The Resource Manager guarantees that the thread proxy associated with the execution context will not change while the thread proxy is executing the `Dispatch` method.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)   
 [IExecutionContext::GetProxy Method](../vs140/iexecutioncontext--getproxy-method.md)