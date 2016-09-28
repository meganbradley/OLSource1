---
title: "IDebugThreadDestroyEvent2"
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
  - "IDebugThreadDestroyEvent2"
helpviewer_keywords: 
  - "IDebugThreadDestroyEvent2"
ms.assetid: fca3f603-9432-457b-9ddd-8b0ec17da046
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThreadDestroyEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a thread has run to completion.  
  
## Syntax  
  
```  
IDebugThreadDestroyEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a thread has ended. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report that a thread has ended. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugThreadDestroyEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetExitCode](../vs140/idebugthreaddestroyevent2--getexitcode.md)|Gets the thread's exit code.|  
  
## Remarks  
 Visual Studio uses this event to update the **Threads** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)