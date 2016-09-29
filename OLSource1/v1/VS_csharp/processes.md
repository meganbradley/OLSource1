---
title: "Processes"
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
  - "debugging [Debugging SDK], processes"
ms.assetid: a6a1efdc-b243-40c8-a778-6f69f6b018be
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Processes
In terms of the debugger architecture, a **process**:  
  
-   Is a container for a set of programs. It is closely analogous to a Windows process, which is a container for a set of threads.  
  
-   Can identify itself by name, identifier, or physical identifier.  
  
-   Can enumerate all running programs (and their threads).  
  
-   Can describe itself, the port it is running in, and the machine that contains it.  
  
-   Can create one or more programs, terminate any of the programs it creates, or cause a program to stop.  
  
-   Is represented by an [IDebugProcess2](../VS_csharp/idebugprocess2.md) interface, which is created when the process is launched. A process is launched by either the session debug manager (SDM) or [IDebugEngineLaunch2::LaunchSuspended](../VS_csharp/idebugenginelaunch2--launchsuspended.md).  
  
 The debug package can attach a debug engine (DE) to a process by calling [Attach](../VS_csharp/idebugprocess2--attach.md). This means that the DE attaches to all possible programs running in the process that it can handle. For example, if the common language runtime DE attaches to a process, it attaches only to programs that are running managed code.  
  
## See Also  
 [Programs](../VS_csharp/programs.md)   
 [Threads](../VS_csharp/threads.md)   
 [Debugger Concepts](../VS_csharp/debugger-concepts.md)   
 [Debug Package](../VS_csharp/debug-package.md)   
 [Debug Engine](../VS_csharp/debug-engine.md)   
 [IDebugProcess2](../VS_csharp/idebugprocess2.md)   
 [IDebugEngineLaunch2::LaunchSuspended](../VS_csharp/idebugenginelaunch2--launchsuspended.md)   
 [Attach](../VS_csharp/idebugprocess2--attach.md)