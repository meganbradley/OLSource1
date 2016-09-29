---
title: "IDebugModule3"
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
  - "IDebugModule3"
helpviewer_keywords: 
  - "IDebugModule3 interface"
ms.assetid: 44f8e96e-9c59-4ffc-9a08-9c908a0e4de7
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModule3
This interface represents a module that supports alternate locations of symbols and JustMyCode states.  
  
## Syntax  
  
```  
IDebugModule3 : IDebugModule2  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface to support alternate locations of symbols and to work with JustMyCode states (see the [Visual Studio Debugging Glossary](../VS_csharp/visual-studio-debugger-glossary.md) for a definition of "JustMyCode").  
  
## Notes for Callers  
 A call to [IDebugSymbolSearchEvent2::GetSymbolSearchInfo](../VS_csharp/idebugsymbolsearchevent2--getsymbolsearchinfo.md) returns this interface. The DE sends the [IDebugSymbolSearchEvent2](../VS_csharp/idebugsymbolsearchevent2.md) interface to the session debug manager (SDM) using the [IDebugEventCallback2::Event](../VS_csharp/idebugeventcallback2--event.md) method. Also, a call to [QueryInterface](../VS_csharp/queryinterface.md) on an [IDebugModule2](../VS_csharp/idebugmodule2.md) interface returns this interface.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugModule2](../VS_csharp/idebugmodule2.md) interface, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetSymbolInfo](../VS_csharp/idebugmodule3--getsymbolinfo.md)|Returns a list of paths searched for symbols and the results of searching each path.|  
|[LoadSymbols](../VS_csharp/idebugmodule3--loadsymbols.md)|Loads and initializes symbols for the current module.|  
|[IsUserCode](../VS_csharp/idebugmodule3--isusercode.md)|Returns flag specifying whether the module represents user code.|  
|[SetJustMyCodeState](../VS_csharp/idebugmodule3--setjustmycodestate.md)|Specifies whether the module should be considered user code or not.|  
  
## Remarks  
 Visual Studio is the typical consumer of this interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugModule2](../VS_csharp/idebugmodule2.md)   
 [IDebugSymbolSearchEvent2](../VS_csharp/idebugsymbolsearchevent2.md)   
 [IDebugSymbolSearchEvent2::GetSymbolSearchInfo](../VS_csharp/idebugsymbolsearchevent2--getsymbolsearchinfo.md)