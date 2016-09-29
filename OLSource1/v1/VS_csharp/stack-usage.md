---
title: "Stack Usage"
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
ms.assetid: 383f0072-0438-489f-8829-cca89582408c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Stack Usage
All memory beyond the current address of RSP is considered volatile: The OS, or a debugger, may overwrite this memory during a user debug session, or an interrupt handler. Thus, RSP must always be set before attempting to read or write values to a stack frame.  
  
 This section discusses the allocation of stack space for local variables and the **alloca** intrinsic.  
  
-   [Stack Allocation](../VS_csharp/stack-allocation.md)  
  
-   [Dynamic Parameter Stack Area Construction](../VS_csharp/dynamic-parameter-stack-area-construction.md)  
  
-   [Function Types](../VS_csharp/function-types.md)  
  
-   [malloc Alignment](../VS_csharp/malloc-alignment.md)  
  
-   [alloca](../VS_csharp/alloca.md)  
  
## See Also  
 [x64 Software Conventions](../VS_csharp/x64-software-conventions.md)