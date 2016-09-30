---
title: "IDebugSymbolSearchEvent2"
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
  - "IDebugSymbolSearchEvent2"
helpviewer_keywords: 
  - "IDebugSymbolSearchEvent2"
ms.assetid: 9b946d55-ff85-44eb-b40a-efbf8282eafd
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSymbolSearchEvent2
This interface is sent by the debug engine (DE) to indicate that the debugging symbols for a module being debugged have been loaded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The DE implements this interface to report that a module's symbols have been loaded. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report that a module's symbols have been loaded. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface exposes the following method.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugSymbolSearchEvent2::GetSymbolSearchInfo](../vs140/idebugsymbolsearchevent2--getsymbolsearchinfo.md)|Retrieves information about the results of a symbol search.|  
  
## Remarks  
 This event will be sent even if the symbols failed to load. Calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> allows the handler of this event to determine if the module actually has any symbols.  
  
 Visual Studio typically uses this event to update the status of loaded symbols in the **Modules** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)