---
title: "IDebugPortEx2"
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
  - "IDebugPortEx2"
helpviewer_keywords: 
  - "IDebugPortEx2 interface"
ms.assetid: 144724d0-38ee-4c9b-87ca-8a504371182b
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortEx2
This interface lets the session debug manager (SDM) control the programs and processes running on a port.  
  
## Syntax  
  
```  
IDebugPortEx2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface on the same object that implements [IDebugPort2](../VS_csharp/idebugport2.md).  
  
## Notes for Callers  
 The SDM calls [QueryInterface](../VS_csharp/queryinterface.md) on the `IDebugPort2` interface to obtain this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortEx2`.  
  
|Method|Description|  
|------------|-----------------|  
|[LaunchSuspended](../VS_csharp/idebugportex2--launchsuspended.md)|Launches an executable file.|  
|[ResumeProcess](../VS_csharp/idebugportex2--resumeprocess.md)|Resumes execution of a process.|  
|[CanTerminateProcess](../VS_csharp/idebugportex2--canterminateprocess.md)|Determines whether a process can be terminated.|  
|[TerminateProcess](../VS_csharp/idebugportex2--terminateprocess.md)|Terminates a process.|  
|[GetPortProcessId](../VS_csharp/idebugportex2--getportprocessid.md)|Gets the process ID of the port itself.|  
|[GetProgram](../VS_csharp/idebugportex2--getprogram.md)|Gets a program associated with a program node.|  
  
## Remarks  
 This interface is normally private between the SDM and the custom port supplier.  
  
 If desired, a debug engine (DE) can look for this interface on the [IDebugPort2](../VS_csharp/idebugport2.md) interface passed to [IDebugEngineLaunch2::LaunchSuspended](../VS_csharp/idebugenginelaunch2--launchsuspended.md) and use [IDebugPortEx2::LaunchSuspended](../VS_csharp/idebugportex2--launchsuspended.md) to launch the program. This is not a requirement, however, and a DE can do whatever it needs to do to launch the request program.  
  
## Requirements  
 Header: portpriv.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugPort2](../VS_csharp/idebugport2.md)