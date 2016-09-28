---
title: "GetExecutionContextId Function"
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
  - "concrtrm/concurrency::GetExecutionContextId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExecutionContextId function"
ms.assetid: 4f16d068-c6d2-45b2-b4c4-6e4af4ea7caf
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetExecutionContextId Function
Returns a unique identifier that can be assigned to an execution context that implements the `IExecutionContext` interface.  
  
## Syntax  
  
```  
unsigned int __cdecl GetExecutionContextId();  
```  
  
## Return Value  
 A unique identifier for an execution context.  
  
## Remarks  
 Use this method to obtain an identifier for your execution context before you pass an `IExecutionContext` interface as a parameter to any of the methods offered by the Resource Manager.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)