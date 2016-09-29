---
title: "Creating a Breakpoint"
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
  - "breakpoints, creating"
  - "debugging [Debugging SDK], creating breakpoints"
ms.assetid: 6f9f87bb-192e-45e0-9a7a-ffe729e87f7d
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating a Breakpoint
The following describes the process of creating a breakpoint.  
  
## Methods in Breakpoint Creation  
 When the module that is needed to bind a breakpoint is loaded, the session debug manager (SDM) calls the following methods:  
  
1.  [IDebugPendingBreakpoint2::Enable](../VS_csharp/idebugpendingbreakpoint2--enable.md)  
  
2.  [IDebugPendingBreakpoint2::Virtualize](../VS_csharp/idebugpendingbreakpoint2--virtualize.md)  
  
3.  [IDebugPendingBreakpoint2::CanBind](../VS_csharp/idebugpendingbreakpoint2--canbind.md)  
  
    > [!NOTE]
    >  **CanBind** is called only when a user makes a breakpoint from the Breakpoints window.  
  
4.  [IDebugPendingBreakpoint2::Bind](../VS_csharp/idebugpendingbreakpoint2--bind.md)  
  
5.  [IDebugPendingBreakpoint2::EnumBoundBreakpoints](../VS_csharp/idebugpendingbreakpoint2--enumboundbreakpoints.md)  
  
## See Also  
 [Calling Debugger Events](../VS_csharp/calling-debugger-events.md)