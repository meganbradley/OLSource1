---
title: "IDebugProgram3"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - IDebugProgram3 interface
ms.assetid: 4301ba23-c00c-4ce5-8b1e-3f27da312034
caps.latest.revision: 9
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProgram3
This interface represents a program that is running in a process and extends [IDebugProgram2::Execute](../vs140/idebugprogram2--execute.md) by providing thread information.  
  
## Syntax  
  
```  
IDebugProgram3 : IDebugProgram3  
```  
  
## Notes for Implementers  
 The debug engine (DE) and a custom port supplier implement this interface to represent a program in a process. The session debug manager (SDM) also implements this interface to provide information to [IDebugProgram2::Attach](../vs140/idebugprogram2--attach.md).  
  
## Notes for Callers  
 The [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md) event returns this interface for a new program. This interface is also used as a parameter for many methods on multiple interfaces.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgram3`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugProgram3::ExecuteOnThread](../vs140/idebugprogram3--executeonthread.md)|Executes the program. The thread is returned to give the debugger information on which thread the user is viewing when executing.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Remarks  
 A program is a thread container running in a particular run-time architecture, while a process is made up of one or more programs.  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [GetProgram](../vs140/idebugthread2--getprogram.md)   
 [Next](../vs140/ienumdebugprograms2--next.md)   
 [Event](../vs140/idebugportevents2--event.md)   
 [Attach](../vs140/idebugengine2--attach.md)   
 [DestroyProgram](../vs140/idebugengine2--destroyprogram.md)   
 [Event](../vs140/idebugeventcallback2--event.md)   
 [Attach_V7](../vs140/idebugprogramnode2--attach_v7.md)