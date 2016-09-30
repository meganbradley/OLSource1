---
title: "IDebugEvent2"
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
  - "IDebugEvent2"
helpviewer_keywords: 
  - "IDebugEvent2 interface"
ms.assetid: de3d714d-96fb-4e12-b66b-a75391472153
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEvent2
This interface is used to communicate both critical debug information, such as stopping at a breakpoint, and non-critical information, such as a debugging message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The debug engine (DE) and custom port supplier implement this interface on the same object as all other event interfaces.  
  
## Notes for Callers  
 Using the interface ID (IID) argument given to [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) or [IDebugPortEvents2::Event](../vs140/idebugportevents2--event.md), the session debug manager (SDM) calls [QueryInterface](../vs140/queryinterface.md) on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface to obtain the appropriate event interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[GetAttributes](../vs140/idebugevent2--getattributes.md)|Gets the attributes for this debug event.|  
  
## Remarks  
 The more specific event interfaces, such as [IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md), do not derive from the IDebugEvent2 interface but are instead implemented as a separate interface on the same object as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [Event](../vs140/idebugportevents2--event.md)   
 [Event](../vs140/idebugeventcallback2--event.md)