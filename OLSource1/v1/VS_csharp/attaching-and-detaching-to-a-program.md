---
title: "Attaching and Detaching to a Program"
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
  - "debug engines, attaching to programs"
  - "debug engines, detaching from programs"
ms.assetid: 79dcbb9b-c7f8-40fc-8a00-f37fe1934f51
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Attaching and Detaching to a Program
Attaching the debugger requires sending the correct sequence of methods and events with the proper attributes.  
  
## Sequence of Methods and Events  
  
1.  The session debug manager (SDM) calls the [IDebugProgramNodeAttach2::OnAttach](../VS_csharp/idebugprogramnodeattach2--onattach.md) method.  
  
     Based on the debug engine (DE) process model, the `IDebugProgramNodeAttach2::OnAttach` method returns one of the following methods, which determines what happens next.  
  
     If `S_FALSE` is returned, the debug engine has successfully been attached to the program. Otherwise, the [Attach](../VS_csharp/idebugengine2--attach.md) method is called to complete the attach process.  
  
     If `S_OK` is returned, the DE is to be loaded in the same process as the SDM. The SDM performs the following tasks:  
  
    1.  Calls [GetEngineInfo](../VS_csharp/idebugprogramnode2--getengineinfo.md) to get the engine information of the DE.  
  
    2.  Co-creates the DE.  
  
    3.  Calls [Attach](../VS_csharp/idebugengine2--attach.md).  
  
2.  The DE sends an [IDebugEngineCreateEvent2](../VS_csharp/idebugenginecreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
3.  The DE sends an [IDebugProgramCreateEvent2](../VS_csharp/idebugprogramcreateevent2.md) to the SDM with an `EVENT_SYNC` attribute.  
  
4.  The DE sends an [IDebugLoadCompleteEvent2](../VS_csharp/idebugloadcompleteevent2.md) to the SDM with an `EVENT_SYNC_STOP` attribute.  
  
 Detaching from a program is a simple, two-step process, as follows:  
  
1.  The SDM calls [Detach](../VS_csharp/idebugprogram2--detach.md).  
  
2.  The DE sends an [IDebugProgramDestroyEvent2](../VS_csharp/idebugprogramdestroyevent2.md).  
  
## See Also  
 [Calling Debugger Events](../VS_csharp/calling-debugger-events.md)