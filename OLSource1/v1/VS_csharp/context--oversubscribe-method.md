---
title: "Context::Oversubscribe Method"
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
  - "concrt/concurrency::Context::Oversubscribe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Oversubscribe method"
ms.assetid: dcd6583e-2b1c-4dcf-a322-7af372e2dc4f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::Oversubscribe Method
Injects an additional virtual processor into a scheduler for the duration of a block of code when invoked on a context executing on one of the virtual processors in that scheduler.  
  
## Syntax  
  
```  
static void __cdecl Oversubscribe(  
   bool _BeginOversubscription  
);  
```  
  
#### Parameters  
 `_BeginOversubscription`  
 If `true`, an indication that an extra virtual processor should be added for the duration of the oversubscription. If `false`, an indication that the oversubscription should end and the previously added virtual processor should be removed.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../VS_csharp/context-class.md)   
 [Task Scheduler (Concurrency Runtime)](../VS_csharp/task-scheduler--concurrency-runtime-.md)