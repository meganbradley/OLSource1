---
title: "Code Context"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], contexts"
ms.assetid: 65e4d37a-086b-426e-9394-a3534967fd59
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Code Context
In [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] debugging, a **code context**:  
  
-   Provides an abstraction of a position in code as known to the debug engine (DE). For most run-time architectures today, a code context can be thought of as an address in a program's instruction stream. For nontraditional languages, where code may not be represented by instructions, a code context may be represented by some other means.  
  
-   Describes the current position in the execution stream of the program being debugged.  
  
-   Exists only when a program has stopped at a breakpoint.  
  
-   Has an associated document context.  
  
-   Is implemented by an [IDebugCodeContext2](../VS_csharp/idebugcodecontext2.md) interface.  
  
## See Also  
 [Document Context](../VS_csharp/document-context.md)   
 [Debugger Contexts](../VS_csharp/debugger-contexts.md)