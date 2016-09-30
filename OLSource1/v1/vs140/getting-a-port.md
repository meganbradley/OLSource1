---
title: "Getting a Port"
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
  - "ports, getting"
  - "debugging [Debugging SDK], ports"
ms.assetid: 745c2337-cfff-4d02-b49c-3ca7c4945c5e
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Getting a Port
A port represents a connection to a machine on which processes are running. That machine could be the local machine or a remote machine (which could possibly be running a non-Windows-based operating system; see [Ports](../vs140/ports.md) for more information).  
  
 A port is represented by the [IDebugPort2](../vs140/idebugport2.md) interface. It is used to obtain information about processes running on the machine the port is connected to.  
  
 A debug engine needs access to a port in order to register program nodes with the port and to satisfy requests for process information. For example, if the debug engine implements the [IDebugProgramProvider2](../vs140/idebugprogramprovider2.md) interface, the implementation for the [IDebugProgramProvider2::GetProviderProcessData](../vs140/idebugprogramprovider2--getproviderprocessdata.md) method could ask the port for the necessary process information to be returned.  
  
 Visual Studio supplies the necessary port to the debug engine, and it obtains this port from a port supplier. If a program is attached to (either from within the debugger or because of an exception was thrown, which triggers the Just-in-Time [JIT] dialog box), the user is given the choice of transport (another name for a port supplier) to use. Otherwise, if the user launches the program from within the debugger, the project system specifies the port supplier to use. In either event, Visual Studio instantiates the port supplier, represented by an [IDebugPortSupplier2](../vs140/idebugportsupplier2.md) interface, and asks for a new port by calling [IDebugPortSupplier2::AddPort](../vs140/idebugportsupplier2--addport.md) with an [IDebugPortRequest2](../vs140/idebugportrequest2.md) interface. This port is then passed on to the debug engine in one form or another.  
  
## Example  
 This code fragment shows how to use the port supplied to [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md) to register a program node in [IDebugEngineLaunch2::ResumeProcess](../vs140/idebugenginelaunch2--resumeprocess.md). Parameters not directly related to this concept have been omitted for clarity.  
  
> [!NOTE]
>  This example uses the port to launch and resume the process and assumes that the [IDebugPortEx2](../vs140/idebugportex2.md) interface is implemented on the port. This is by no means the only way to perform these tasks, and it is possible that the port may not even be involved other than to have the program's [IDebugProgramNode2](../vs140/idebugprogramnode2.md) given to it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Registering the Program](../vs140/registering-the-program.md)   
 [Enabling a Program to Be Debugged](../vs140/enabling-a-program-to-be-debugged.md)   
 [Port Suppliers](../vs140/port-suppliers.md)   
 [Ports](../vs140/ports.md)