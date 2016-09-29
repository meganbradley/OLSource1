---
title: "IDebugPropertyCreateEvent2"
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
  - "IDebugPropertyCreateEvent2"
helpviewer_keywords: 
  - "IDebugPropertyCreateEvent2 interface"
ms.assetid: 33b3082b-a42e-488a-a1e4-dadf506f922c
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPropertyCreateEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when it creates a property that is associated with a specific document.  
  
## Syntax  
  
```  
IDebugPropertyCreateEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a property has been created. The [IDebugEvent2](../VS_csharp/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../VS_csharp/queryinterface.md) to access the `IDebugEvent2` interface. This interface is implemented if the DE has created a property associated with a script that has been loaded or created and if that script needs to appear in the IDE.  
  
## Notes for Callers  
 The DE creates and sends this event object to report a property has been created. The event is sent by using the [IDebugEventCallback2](../VS_csharp/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the method of the `IDebugPropertyCreateEvent2` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetDebugProperty](../VS_csharp/idebugpropertycreateevent2--getdebugproperty.md)|Gets the new property.|  
  
## Remarks  
 If a property has a specific document or script associated with it, the DE can send this event to the SDM in order to update the **Script Documents** window with the name of the document. The SDM will call [IDebugProperty2::GetExtendedInfo](../VS_csharp/idebugproperty2--getextendedinfo.md) with the argument `guidDocument` to retrieve a `VARIANT` containing an [IUnknown](../VS_csharp/iunknown.md) pointer. The SDM will call [QueryInterface](../VS_csharp/queryinterface.md) on this pointer to retrieve the [IDebugDocument2](../VS_csharp/idebugdocument2.md) interface that is used to update the **Script Documents** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugEvent2](../VS_csharp/idebugevent2.md)   
 [IDebugEventCallback2](../VS_csharp/idebugeventcallback2.md)   
 [IDebugProperty2](../VS_csharp/idebugproperty2.md)