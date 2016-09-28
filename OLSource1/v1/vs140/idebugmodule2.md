---
title: "IDebugModule2"
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
  - "IDebugModule2"
helpviewer_keywords: 
  - "IDebugModule2 interface"
ms.assetid: 24c2a126-f4ab-4891-8509-8ef99b994c08
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModule2
This interface represents a module—that is, an executable unit of a program—such as a DLL.  
  
## Syntax  
  
```  
IDebugModule2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to represent a module and to provide access to information about that module.  
  
## Notes for Callers  
 A call to [IDebugModuleLoadEvent2::GetModule](../vs140/idebugmoduleloadevent2--getmodule.md) returns this interface. The DE sends the [IDebugModuleLoadEvent2](../vs140/idebugmoduleloadevent2.md) interface to the session debug manager (SDM) using the [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) method.  
  
 This interface can also be returned in a [FRAMEINFO](../vs140/frameinfo.md) structure (which is returned by a call to [IDebugThread2::EnumFrameInfo](../vs140/idebugthread2--enumframeinfo.md)).  
  
 [IEnumDebugModules2::Next](../vs140/ienumdebugmodules2--next.md) also returns this interface ([IDebugProgram2::EnumModules](../vs140/idebugprogram2--enummodules.md) returns the [IEnumDebugModules2](../vs140/ienumdebugmodules2.md) interface).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugModule2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetInfo](../vs140/idebugmodule2--getinfo.md)|Gets the [MODULE_INFO](../vs140/module_info.md) that describes this module.|  
|[ReloadSymbols_Deprecated](../vs140/idebugmodule2--reloadsymbols_deprecated.md)|OBSOLETE. DO NOT USE. Reloads the symbols for this module.|  
  
## Remarks  
 Module information can be displayed in the **Modules** window of the IDE.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [MODULE_INFO](../vs140/module_info.md)   
 [IDebugModuleLoadEvent2::GetModule](../vs140/idebugmoduleloadevent2--getmodule.md)   
 [FRAMEINFO](../vs140/frameinfo.md)   
 [IEnumDebugModules2](../vs140/ienumdebugmodules2.md)