---
title: "Context::YieldExecution Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: e92707b3-0e23-4e78-af3d-4eeb34bf5709
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context::YieldExecution Method
Yields execution so that another context can execute. If no other context is available to yield to, the scheduler can yield to another operating system thread.  
  
## Syntax  
  
```  
static void __cdecl YieldExecution();  
```  
  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
 This function is new in [!INCLUDE[vs_dev14](../VS_csharp/includes/vs_dev14_md.md)] and is identical to the [Yield](../VS_csharp/context--yield-method.md) function but does not conflict with the Yield macro in Windows.h.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Context Class](../VS_csharp/context-class.md)   
 [Context::Block Method](../VS_csharp/context--block-method.md)   
 [Context::Unblock Method](../VS_csharp/context--unblock-method.md)