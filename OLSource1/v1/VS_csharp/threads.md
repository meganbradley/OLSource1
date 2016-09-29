---
title: "Threads"
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
  - "debugging [Debugging SDK], threads"
  - "threading [Debugging SDK]"
ms.assetid: 2243d24a-c3d2-41d1-abbb-6db21a2db9ee
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Threads
In terms of the debugger architecture, a **thread**:  
  
-   Is the fundamental unit of computation. A thread sequentially executes its instructions within the context of a single call stack, moving from one code context to the next.  
  
-   Can identify itself and the program it is running in, and can be named, suspended, and resumed. A thread can also enumerate its associated stack frames and, under some conditions, can be moved to another stack frame. Given the context of a stack frame, a thread can return its associated logical thread, if any. A thread has properties, such as a suspend count, that can be displayed in the Threads window of the IDE.  
  
-   Is represented by an [IDebugThread2](../VS_csharp/idebugthread2.md) interface, typically created by a debug engine (DE) or virtual machine as a consequence of executing a program.  
  
## See Also  
 [Programs](../VS_csharp/programs.md)   
 [Stack Frames](../VS_csharp/stack-frames.md)   
 [Debug Engine](../VS_csharp/debug-engine.md)   
 [Debugger Concepts](../VS_csharp/debugger-concepts.md)   
 [Session Debug Manager](../VS_csharp/session-debug-manager.md)