---
title: "Termination and Detaching"
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
  - "debug engines, detaching from programs"
ms.assetid: 268c1e51-6363-45d1-964c-1ab99bdfa4f9
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Termination and Detaching
The following describes normal termination.  
  
## Discussion  
 After the [IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md) or [IDebugEntryPointEvent2](../vs140/idebugentrypointevent2.md) interface continues, if there are no breakpoints, exceptions, run-time errors, or infinite loops in the application to be debugged, the program being debugged will run to completion. This is normal termination.  
  
 You must send an [IDebugProgramDestroyEvent2](../vs140/idebugprogramdestroyevent2.md) to implement normal termination. This requires implementing the [IDebugProgramDestroyEvent2::GetExitCode](../vs140/idebugprogramdestroyevent2--getexitcode.md) method.  
  
## See Also  
 [Creating a Custom Debug Engine](../vs140/creating-a-custom-debug-engine.md)