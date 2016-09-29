---
title: "Debugger Concepts"
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
  - "debugging [Debugging SDK]"
ms.assetid: 2d371d38-f1a0-4a9a-8ea3-100e8c0149b7
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Debugger Concepts
To build on the Visual Studio debug package, you need to be familiar with the architectural concepts used in designing the package.  
  
## In This Section  
 [Debug Session](../vs140/debug-session.md)  
 Explains the role of a session in the debugging architecture.  
  
 [Servers](../vs140/servers--visual-studio-sdk-.md)  
 Defines what a server is in terms of debugging architecture, in both abstract and physical terms.  
  
 [Port Suppliers](../vs140/port-suppliers.md)  
 Defines what a port supplier is in terms of debugging architecture.  
  
 [Ports](../vs140/ports.md)  
 Defines what a port is in terms of debugging architecture.  
  
 [Processes](../vs140/processes.md)  
 Defines what a process is in terms of debugging architecture.  
  
 [Program Nodes](../vs140/program-nodes.md)  
 Defines a program node in terms of debugging architecture, including how it can identify itself and the process it is running in.  
  
 [Programs](../vs140/programs.md)  
 Defines a program in terms of debugging architecture.  
  
 [Threads](../vs140/threads.md)  
 Defines the characteristics of threads in terms of debugging architecture.  
  
 [Stack Frames](../vs140/stack-frames.md)  
 Defines a stack frame in terms of debugging architecture. A stack frame is an abstraction of a stack that provides the execution context of a thread.  
  
 [Modules](../vs140/modules.md)  
 Defines a module, in terms of debugging architecture, as a physical container of code, such as an executable file or a DLL.  
  
 [Breakpoints](../vs140/breakpoints--visual-studio-sdk-.md)  
 Defines the three types of breakpoints—pending, bound, and error—in terms of debugging architecture.  
  
## Related Sections  
 [Debugger Contexts](../vs140/debugger-contexts.md)  
 Explains how the debug engine (DE) operates simultaneously within code, documentation, and expression evaluation contexts. Describes, for each of the three contexts, the location, position, or evaluation relevant to it.  
  
 [Debugger Components](../vs140/debugger-components.md)  
 Provides an overview of the Visual Studio Debugging components, which include the debug engine (DE), expression evaluator (EE), and symbol handler (SH).  
  
 [Debugging Tasks](../vs140/debugging-tasks.md)  
 Contains links to various debugging tasks, such as launching a program and evaluating expressions.