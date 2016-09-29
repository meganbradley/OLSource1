---
title: "interruption_point Function"
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
  - "ppl/concurrency::interruption_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "interruption_point function"
ms.assetid: 350f062c-3ff5-45bc-9718-fece1ede9cdb
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# interruption_point Function
Creates an interruption point for cancellation. If a cancellation is in progress in the context where this function is called, this will throw an internal exception that aborts the execution of the currently executing parallel work. If cancellation is not in progress, the function does nothing.  
  
## Syntax  
  
```  
inline void interruption_point();  
```  
  
## Remarks  
 You should not catch the internal cancellation exception thrown by the `interruption_point()` function. The exception will be caught and handled by the runtime, and catching it may cause your program to behave abnormally.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../VS_csharp/concurrency-namespace.md)