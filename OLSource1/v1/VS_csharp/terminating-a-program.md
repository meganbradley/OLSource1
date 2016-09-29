---
title: "Terminating a Program"
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
  - "programs, termination events"
  - "debugging [Debugging SDK], terminating a program"
ms.assetid: eedda0a3-5e05-44fe-841d-a2f4866ac72d
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Terminating a Program
The following is a description of the termination of a single program with one thread.  
  
## Termination Process  
  
1.  The DE sends an [IDebugThreadDestroyEvent2](../VS_csharp/idebugthreaddestroyevent2.md) with a valid [IDebugThread2](../VS_csharp/idebugthread2.md).  
  
2.  The DE sends an [IDebugProgramDestroyEvent2](../VS_csharp/idebugprogramdestroyevent2.md) with a valid [IDebugProgram2](../VS_csharp/idebugprogram2.md).  
  
 The IDE goes into design mode. The debug engine or run-time environment calls [IDebugPortNotify2::RemoveProgramNode](../VS_csharp/idebugportnotify2--removeprogramnode.md) to remove the program from the port.  
  
## See Also  
 [Calling Debugger Events](../VS_csharp/calling-debugger-events.md)