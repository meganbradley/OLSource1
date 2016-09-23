---
title: "Hitting a Breakpoint"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - debugging [Debugging SDK], hitting breakpoints
  - breakpoints, hitting
ms.assetid: a77816e3-b15b-46a0-90cd-be7242e4d6c9
caps.latest.revision: 11
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Hitting a Breakpoint
The following describes the process when the debug engine (DE) hits a breakpoint while running or stepping:  
  
## Troubleshooting a Hit Breakpoint  
  
1.  The DE sends an [IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md) interface as an **EVENT_SYNC_STOP**.  
  
2.  The session debug manager (SDM) calls [IDebugBreakpointEvent2:::EnumBreakpoints](../vs140/idebugbreakpointevent2--enumbreakpoints.md) to get the breakpoint that was hit.  
  
## See Also  
 [Calling Debugger Events](../vs140/calling-debugger-events.md)