---
title: "IExecutionContext::Dispatch Method"
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
  - "concrtrm/concurrency::IExecutionContext::Dispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Dispatch method"
ms.assetid: f646e997-73ab-485c-919d-a57b483ef0b8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionContext::Dispatch Method
The method that is called when a thread proxy starts executing a particular execution context. This should be the main worker routine for your scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the state under which this execution context is being dispatched. For more information on dispatch state, see [DispatchState](../vs140/dispatchstate-structure.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)