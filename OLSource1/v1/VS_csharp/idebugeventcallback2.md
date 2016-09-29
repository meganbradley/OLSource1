---
title: "IDebugEventCallback2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugEventCallback2"
helpviewer_keywords: 
  - "IDebugEventCallback2"
ms.assetid: 2c935ee0-2e22-4be0-a852-73736f33c8c9
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEventCallback2
This interface is used by the debug engine (DE) to send debug events to the session debug manager (SDM).  
  
## Syntax  
  
```  
IDebugEventCallback2 : IUnknown  
```  
  
## Notes for Implementers  
 [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] implements this interface to receive events from a debug engine.  
  
## Notes for Callers  
 A debug engine typically receives this interface when the SDM calls [IDebugProgram2::Attach](../VS_csharp/idebugprogram2--attach.md), [IDebugEngine2::Attach](../VS_csharp/idebugengine2--attach.md), or [IDebugEngineLaunch2::LaunchSuspended](../VS_csharp/idebugenginelaunch2--launchsuspended.md). A debug engine sends events to the SDM by calling [IDebugEventCallback2::Event](../VS_csharp/idebugeventcallback2--event.md).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugEventCallback2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Event](../VS_csharp/idebugeventcallback2--event.md)|Sends notification of debugging events to the SDM.|  
  
## Remarks  
 Although [IDebugExpression2::EvaluateSync](../VS_csharp/idebugexpression2--evaluatesync.md) and [IDebugExpression2::EvaluateAsync](../VS_csharp/idebugexpression2--evaluateasync.md) specify that they take an `IDebugEventCallback2` interface, this is not the case, and the interface pointer will always be a null value. Instead, the debug engine must use the `IDebugEventCallback2` interface received in the call to [IDebugProgram2::Attach](../VS_csharp/idebugprogram2--attach.md), [IDebugEngine2::Attach](../VS_csharp/idebugengine2--attach.md), or [IDebugEngineLaunch2::LaunchSuspended](../VS_csharp/idebugenginelaunch2--launchsuspended.md).  
  
 If a package implements [IDebugEventCallback](../VS_csharp/idebugeventcallback2.md) in managed code, it is strongly advised that <xref:System.Runtime.InteropServices.Marshal.ReleaseComObject*> be invoked on the various interfaces that are passed to [IDebugEventCallback2.Event](../VS_csharp/idebugeventcallback2--event.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [LaunchSuspended](../VS_csharp/idebugenginelaunch2--launchsuspended.md)   
 [Attach](../VS_csharp/idebugprogram2--attach.md)   
 [IDebugEngine2::Attach](../VS_csharp/idebugengine2--attach.md)