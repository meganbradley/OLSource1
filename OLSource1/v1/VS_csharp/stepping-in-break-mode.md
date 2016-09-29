---
title: "Stepping in Break Mode"
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
  - "break mode, stepping"
  - "stepping, in break mode"
  - "debugging [Debugging SDK], stepping in break mode"
ms.assetid: b08dc8ee-6c63-4462-a097-6f525cfbb35a
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Stepping in Break Mode
The following describes the process that occurs when the debugger is in break mode and must step through code:  
  
## Stepping Process  
  
1.  Call [IDebugProgram2::Step](../VS_csharp/idebugprogram2--step.md) with [STEPKIND](../VS_csharp/stepkind.md) and [STEPUNIT](../VS_csharp/stepunit.md) arguments to execute a step.  
  
2.  When the step is finished, send an [IDebugStepCompleteEvent2](../VS_csharp/idebugstepcompleteevent2.md) as a stopping event.  
  
## See Also  
 [Calling Debugger Events](../VS_csharp/calling-debugger-events.md)