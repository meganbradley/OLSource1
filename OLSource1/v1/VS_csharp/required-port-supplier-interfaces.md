---
title: "Required Port Supplier Interfaces"
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
  - "port suppliers, required interfaces"
  - "debugging [Debugging SDK], port suppliers"
ms.assetid: 0c2cdd40-9f6f-425e-b305-858f7734161e
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Required Port Supplier Interfaces
A port supplier must implement the [IDebugPortSupplier2](../VS_csharp/idebugportsupplier2.md) interface.[IDebugPortSupplier2](../VS_csharp/idebugportsupplier2.md)  
  
 Because a port supplier supplies ports, it must also implement them. Therefore, it must implement the following interfaces:  
  
-   [IDebugPort2](../VS_csharp/idebugport2.md)  
  
     Describes the port and can enumerate all processes running on the port.  
  
-   [IDebugPortEx2](../VS_csharp/idebugportex2.md)  
  
     Provides for launching and terminating processes on the port.  
  
-   [IDebugPortNotify2](../VS_csharp/idebugportnotify2.md)  
  
     Provides a mechanism for programs running within this port's context to notify it of program node creation and destruction. For more information, see [Program Nodes](../VS_csharp/program-nodes.md).  
  
-   `IConnectionPointContainer`  
  
     Provides a connection point for [IDebugPortEvents2](../VS_csharp/idebugportevents2.md).  
  
## Port Supplier Operation  
 The [IDebugPortEvents2](../VS_csharp/idebugportevents2.md) sink receives notifications when process and programs are created and destroyed on a port. A port is required to send [IDebugProcessCreateEvent2](../VS_csharp/idebugprocesscreateevent2.md) when a process is created and [IDebugProcessDestroyEvent2](../VS_csharp/idebugprocessdestroyevent2.md) when a process is destroyed on the port. A port is also required to send [IDebugProgramCreateEvent2](../VS_csharp/idebugprogramcreateevent2.md) when a program is created and [IDebugProgramDestroyEvent2](../VS_csharp/idebugprogramdestroyevent2.md) when a program is destroyed in a process running on the port.  
  
 A port typically sends program create and destroy events in response to the [AddProgramNode](../VS_csharp/idebugportnotify2--addprogramnode.md) and [RemoveProgramNode](../VS_csharp/idebugportnotify2--removeprogramnode.md) methods, respectively.  
  
 Because a port can launch and terminate both physical processes and logical programs, these interfaces must also be implemented by the debug engine:  
  
-   [IDebugProcess2](../VS_csharp/idebugprocess2.md)  
  
     Describes the physical process. At least the following methods must be implemented:  
  
    -   [IDebugProcess2::EnumPrograms](../VS_csharp/idebugprocess2--enumprograms.md)  
  
    -   [IDebugProcess2::GetName](../VS_csharp/idebugprocess2--getname.md)  
  
    -   [IDebugProcess2::GetServer](../VS_csharp/idebugprocess2--getserver.md)  
  
    -   [IDebugProcess2::GetPhysicalProcessId](../VS_csharp/idebugprocess2--getphysicalprocessid.md)  
  
    -   [IDebugProcess2::GetProcessId](../VS_csharp/idebugprocess2--getprocessid.md)  
  
    -   [IDebugProcess2::GetAttachedSessionName](../VS_csharp/idebugprocess2--getattachedsessionname.md)  
  
-   [IDebugProcessEx2](../VS_csharp/idebugprocessex2.md)  
  
     Provides a way for the SDM to attach and detach itself from a process.  
  
-   [IDebugProgram2](../VS_csharp/idebugprogram2.md)  
  
     Describes the logical program. At least the following methods must be implemented:  
  
    -   [IDebugProgram2::GetName](../VS_csharp/idebugprogram2--getname.md)  
  
    -   [IDebugProgram2::GetProcess](../VS_csharp/idebugprogram2--getprocess.md)  
  
    -   [IDebugProgram2::GetProgramId](../VS_csharp/idebugprogram2--getprogramid.md)  
  
-   [IDebugProgramEx2](../VS_csharp/idebugprogramex2.md)  
  
     Provides a way for the SDM to attach to this program.  
  
## See Also  
 [Implementing a Port Supplier](../VS_csharp/implementing-a-port-supplier.md)