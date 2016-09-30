---
title: "IExecutionContext::GetId Method"
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
  - "concrtrm/concurrency::IExecutionContext::GetId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetId method"
ms.assetid: c97c28fc-03dc-44c3-9a3e-a545284605bc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionContext::GetId Method
Returns a unique identifier for the execution context.  
  
## Syntax  
  
```  
virtual unsigned int GetId() const =0;  
```  
  
## Return Value  
 A unique integer identifier.  
  
## Remarks  
 You should use the method `GetExecutionContextId` to obtain a unique identifier for the object that implements the `IExecutionContext` interface, before you use the interface as a parameter to methods supplied by the Resource Manager. You are expected to return the same identifier when the `GetId` function is invoked.  
  
 An identifier obtained from a different source could result in undefined behavior.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)   
 [GetExecutionContextId Function](../vs140/getexecutioncontextid-function.md)