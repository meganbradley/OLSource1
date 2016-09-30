---
title: "IDebugModuleLoadEvent2"
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
  - "IDebugModuleLoadEvent2"
helpviewer_keywords: 
  - "IDebugModuleLoadEvent2 interface"
ms.assetid: 7d26fb23-5d49-4ba7-b7c5-3aed4d7be81e
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModuleLoadEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when a module is loaded or unloaded.  
  
## Syntax  
  
```  
IDebugModuleLoadEvent2 : IUnknown  
```  
  
## Notes for Implementers  
 The DE implements this interface to report that a module has been loaded or unloaded. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the `IDebugEvent2` interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report a module has been loaded or unloaded. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it is attached to the program being debugged.  
  
## Methods in Vtable Order  
 The following table shows the method of `IDebugModuleLoadEvent2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetModule](../vs140/idebugmoduleloadevent2--getmodule.md)|Gets the module that is being loaded or unloaded.|  
  
## Remarks  
 Visual Studio uses this event to keep the **Modules** window up to date.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)