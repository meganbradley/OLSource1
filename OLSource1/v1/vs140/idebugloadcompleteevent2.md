---
title: "IDebugLoadCompleteEvent2"
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
  - "IDebugLoadCompleteEvent2"
helpviewer_keywords: 
  - "IDebugLoadCompleteEvent2"
ms.assetid: 37eb7360-28e9-4273-862a-4c17f22af690
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugLoadCompleteEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a program is loaded, but before any code is executed.  
  
## Syntax  
  
```  
IDebugLoadCompleteEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a program has been successfully loaded. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report that a program has been successfully loaded. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Remarks  
 This event is a stopping event and must have the `EVENT_STOPPING` flag set on the event attributes.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)