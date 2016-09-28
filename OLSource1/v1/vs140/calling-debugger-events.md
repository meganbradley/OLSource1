---
title: "Calling Debugger Events"
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
  - "debugging [Debugging SDK], events"
ms.assetid: b3440ac3-80af-40c6-bef4-cbf00fa67885
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Calling Debugger Events
Events in debugging sessions occur in a specific order.  
  
## Discussion  
 To understand the pattern of calls between the debug engine (DE) and the session debug manager (SDM), the following represents the calling order of the events that occur in a typical debugging session:  
  
1.  [Attaching and detaching to a program](../vs140/attaching-and-detaching-to-a-program.md)  
  
2.  [Launching the debugger](../vs140/launching-the-debugger.md)  
  
3.  [Terminating a program](../vs140/terminating-a-program.md)  
  
4.  [Creating a breakpoint](../vs140/creating-a-breakpoint.md)  
  
5.  [When a breakpoint binds or becoming unbound](../vs140/when-a-breakpoint-binds-or-becomes-unbound.md)  
  
6.  [Breakpoint errors](../vs140/breakpoint-errors.md)  
  
7.  [Hitting a breakpoint](../vs140/hitting-a-breakpoint.md)  
  
8.  [Deleting a breakpoint](../vs140/deleting-a-breakpoint.md)  
  
9. [Entering break mode](../vs140/entering-break-mode.md)  
  
10. [Stepping in break mode](../vs140/stepping-in-break-mode.md)  
  
11. [Expression evaluation in break mode](../vs140/expression-evaluation-in-break-mode.md)  
  
12. [Exception handling](../vs140/exception-handling--visual-studio-sdk-.md)  
  
## See Also  
 [Creating a Custom Debug Engine](../vs140/creating-a-custom-debug-engine.md)