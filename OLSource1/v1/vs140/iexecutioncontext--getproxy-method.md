---
title: "IExecutionContext::GetProxy Method"
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
  - "concrtrm/concurrency::IExecutionContext::GetProxy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProxy method"
ms.assetid: a76a574d-4bb8-4a87-b741-b300c057f861
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionContext::GetProxy Method
Returns an interface to the thread proxy that is executing this context.  
  
## Syntax  
  
```  
virtual IThreadProxy * GetProxy() =0;  
```  
  
## Return Value  
 An `IThreadProxy` interface. If the execution context's thread proxy has not been initialized with a call to `SetProxy`, the function must return `NULL`.  
  
## Remarks  
 The Resource Manager will invoke the `SetProxy` method on an execution context, with an `IThreadProxy` interface as a parameter, prior to entering the `Dispatch` method on the on the context. You are expected to store this argument and return it on calls to `GetProxy()`.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)   
 [IExecutionContext::SetProxy Method](../vs140/iexecutioncontext--setproxy-method.md)