---
title: "IDebugProgram3"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugProgram3 interface"
ms.assetid: 4301ba23-c00c-4ce5-8b1e-3f27da312034
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram3
This interface represents a program that is running in a process and extends [IDebugProgram2::Execute](../VS_csharp/idebugprogram2--execute.md) by providing thread information.  
  
## Syntax  
  
```  
IDebugProgram3 : IDebugProgram3  
```  
  
## Notes for Implementers  
 The debug engine (DE) and a custom port supplier implement this interface to represent a program in a process. The session debug manager (SDM) also implements this interface to provide information to [IDebugProgram2::Attach](../VS_csharp/idebugprogram2--attach.md).  
  
## Notes for Callers  
 The [IDebugProgramCreateEvent2](../VS_csharp/idebugprogramcreateevent2.md) event returns this interface for a new program. This interface is also used as a parameter for many methods on multiple interfaces.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgram3`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugProgram3::ExecuteOnThread](../VS_csharp/idebugprogram3--executeonthread.md)|Executes the program. The thread is returned to give the debugger information on which thread the user is viewing when executing.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Remarks  
 A program is a thread container running in a particular run-time architecture, while a process is made up of one or more programs.  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugProgram2](../VS_csharp/idebugprogram2.md)   
 [GetProgram](../VS_csharp/idebugthread2--getprogram.md)   
 [Next](../VS_csharp/ienumdebugprograms2--next.md)   
 [Event](../VS_csharp/idebugportevents2--event.md)   
 [Attach](../VS_csharp/idebugengine2--attach.md)   
 [DestroyProgram](../VS_csharp/idebugengine2--destroyprogram.md)   
 [Event](../VS_csharp/idebugeventcallback2--event.md)   
 [Attach_V7](../VS_csharp/idebugprogramnode2--attach_v7.md)