---
title: "IDebugProcess2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugProcess2
helpviewer_keywords: 
  - IDebugProcess2 interface
ms.assetid: 99f6cd06-4076-45ee-b2ae-fa2ad627fd18
caps.latest.revision: 23
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProcess2
This interface represents a process running on a port. If the port is the local port, then `IDebugProcess2` usually represents a physical process on the local machine.  
  
## Syntax  
  
```  
IDebugProcess2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by a custom port supplier to manage programs as a group. This interface must be implemented by the port supplier.  
  
 A debug engine also implements this interface if it supports launching a program through [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md).  
  
## Notes for Callers  
 This interface is called primarily by the session debug manager (SDM) in order to interact with a group of programs identified in this process.  
  
 Call [IDebugProgram2::GetProcess](../vs140/idebugprogram2--getprocess.md) or [IDebugPort2::GetProcess](../vs140/idebugport2--getprocess.md) to get this interface. This interface is also returned by calling `IDebugEngineLaunch2::LaunchSuspended`.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProcess2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetInfo](../vs140/idebugprocess2--getinfo.md)|Gets a description of the process.|  
|[EnumPrograms](../vs140/idebugprocess2--enumprograms.md)|Enumerates the programs that are contained in this process.|  
|[GetName](../vs140/idebugprocess2--getname.md)|Gets the title, friendly name, or file name of the process.|  
|[GetServer](../vs140/idebugprocess2--getserver.md)|Gets the instance of a machine server this process is running on.|  
|[Terminate](../vs140/idebugprocess2--terminate.md)|Terminates the process.|  
|[Attach](../vs140/idebugprocess2--attach.md)|Attaches to the process.|  
|[CanDetach](../vs140/idebugprocess2--candetach.md)|Determines if the SDM can detach the process.|  
|[Detach](../vs140/idebugprocess2--detach.md)|Detaches the debugger from the process.|  
|[GetPhysicalProcessId](../vs140/idebugprocess2--getphysicalprocessid.md)|Gets the system process identifier.|  
|[GetProcessId](../vs140/idebugprocess2--getprocessid.md)|Gets a globally unique identifier for this process.|  
|[GetAttachedSessionName](../vs140/idebugprocess2--getattachedsessionname.md)<br /><br /> [DEPRECATED]|Gets the name of the session that is debugging the process.<br /><br /> [DEPRECATED. SHOULD ALWAYS RETURN `E_NOTIMPL`.]|  
|[EnumThreads](../vs140/idebugprocess2--enumthreads.md)|Enumerates the threads running in the process.|  
|[CauseBreak](../vs140/idebugprocess2--causebreak.md)|Requests that the next program running code in this process stop.|  
|[GetPort](../vs140/idebugprocess2--getport.md)|Gets the port that this process is running on.|  
  
## Remarks  
 An `IDebugProcess2` contains one or more [IDebugProgram2](../vs140/idebugprogram2.md) interfaces.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [GetProcess](../vs140/idebugport2--getprocess.md)   
 [LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md)   
 [GetProcess](../vs140/idebugprogram2--getprocess.md)   
 [Next](../vs140/ienumdebugprocesses2--next.md)   
 [Event](../vs140/idebugportevents2--event.md)   
 [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)   
 [Event](../vs140/idebugeventcallback2--event.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)