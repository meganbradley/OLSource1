---
title: "IDebugEngineCreateEvent2"
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
  - "IDebugEngineCreateEvent2"
helpviewer_keywords: 
  - "IDebugEngineCreateEvent2 interface"
ms.assetid: 37c0a841-1c8d-4802-a990-36b54bca3ef7
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineCreateEvent2
The debug engine (DE) sends this interface to the session debug manager (SDM) when an instance of the DE is created.  
  
## Syntax  
  
```  
IDebugEngineCreateEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface as part of its normal operations. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses the `QueryInterface` method to access the `IDebugEvent2` interface).  
  
## Notes for Callers  
 The DE creates and sends this event object when the DE has been instantiated. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugEngineCreateEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetEngine](../vs140/idebugenginecreateevent2--getengine.md)|Retrieves the object that represents the newly created debug engine (DE).|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)