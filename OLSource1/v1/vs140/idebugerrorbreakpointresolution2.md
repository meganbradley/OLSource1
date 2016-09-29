---
title: "IDebugErrorBreakpointResolution2"
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
  - "IDebugErrorBreakpointResolution2"
helpviewer_keywords: 
  - "IDebugErrorBreakpointResolution2"
ms.assetid: b1234216-0ac8-461d-b2a7-54f60f8f3262
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugErrorBreakpointResolution2
This interface represents the resolution of a breakpoint error.  
  
## Syntax  
  
```  
IDebugErrorBreakpointResolution2 : IUnknown  
```  
  
## Notes for Implementers  
 A debug engine implements this interface as part of its support for breakpoints. This interface is used to report where a breakpoint failed to bind.  
  
## Notes for Callers  
 A call to [IDebugErrorBreakpoint2::GetBreakpointResolution](../vs140/idebugerrorbreakpoint2--getbreakpointresolution.md) returns this interface to provide information about where the breakpoint failed to bind. The [IDebugBreakpointErrorEvent2::GetErrorBreakpoint](../vs140/idebugbreakpointerrorevent2--geterrorbreakpoint.md) method obtains the [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugErrorBreakpointResolution2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetBreakpointType](../vs140/idebugerrorbreakpointresolution2--getbreakpointtype.md)|Gets the breakpoint type.|  
|[GetResolutionInfo](../vs140/idebugerrorbreakpointresolution2--getresolutioninfo.md)|Gets the breakpoint resolution information.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md)   
 [GetBreakpointResolution](../vs140/idebugerrorbreakpoint2--getbreakpointresolution.md)   
 [IDebugBreakpointErrorEvent2::GetErrorBreakpoint](../vs140/idebugbreakpointerrorevent2--geterrorbreakpoint.md)