---
title: "IDebugProgramNode2"
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
  - "IDebugProgramNode2"
helpviewer_keywords: 
  - "IDebugProgramNode2 interface"
ms.assetid: 80e511d8-9b40-4a85-aa5d-952fa5ee6ae7
caps.latest.revision: 24
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramNode2
This interface represents a program that can be debugged.  
  
## Syntax  
  
```  
IDebugProgramNode2 : IUnknown  
```  
  
## Notes for Implementers  
 A debug engine (DE) or a custom port supplier implements this interface to represent a program that can be debugged. This interface is typically implemented on the same object that implements the [IDebugProgram2](../VS_csharp/idebugprogram2.md) interface. This interface is registered with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] by calling [IDebugProgramPublisher2::PublishProgramNode](../VS_csharp/idebugprogrampublisher2--publishprogramnode.md).  
  
## Notes for Callers  
 Call [IDebugProgramProvider2::GetProviderProgramNode](../VS_csharp/idebugprogramprovider2--getproviderprogramnode.md) to return this interface. A custom port supplier receives this interface through a call to [IDebugPortNotify2::AddProgramNode](../VS_csharp/idebugportnotify2--addprogramnode.md). A DE receives this interface through a call to [IDebugEngine2::Attach](../VS_csharp/idebugengine2--attach.md).  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugProgramNode2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetProgramName](../VS_csharp/idebugprogramnode2--getprogramname.md)|Gets the name of a program.|  
|[GetHostName](../VS_csharp/idebugprogramnode2--gethostname.md)|Gets the name of the process hosting a program.|  
|[GetHostPid](../VS_csharp/idebugprogramnode2--gethostpid.md)|Gets the system process identifier for the process hosting a program.|  
|[GetHostMachineName_V7](../VS_csharp/idebugprogramnode2--gethostmachinename_v7.md)|DEPRECATED. DO NOT USE.|  
|[Attach_V7](../VS_csharp/idebugprogramnode2--attach_v7.md)|DEPRECATED. DO NOT USE. See the [IDebugProgramNodeAttach2](../VS_csharp/idebugprogramnodeattach2.md) interface for an alternative approach.|  
|[GetEngineInfo](../VS_csharp/idebugprogramnode2--getengineinfo.md)|Gets the name and identifier of the DE running this program.|  
|[DetachDebugger_V7](../VS_csharp/idebugprogramnode2--detachdebugger_v7.md)|DEPRECATED. DO NOT USE.|  
  
## Remarks  
 The session debug manager (SDM) typically calls [IDebugProgramProvider2::GetProviderProgramNode](../VS_csharp/idebugprogramprovider2--getproviderprogramnode.md) to obtain this interface.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugProgramNodeAttach2](../VS_csharp/idebugprogramnodeattach2.md)   
 [AddProgramNode](../VS_csharp/idebugportnotify2--addprogramnode.md)   
 [RemoveProgramNode](../VS_csharp/idebugportnotify2--removeprogramnode.md)   
 [IDebugEngine2::Attach](../VS_csharp/idebugengine2--attach.md)   
 [IDebugProgramProvider2::GetProviderProgramNode](../VS_csharp/idebugprogramprovider2--getproviderprogramnode.md)   
 [IDebugProgramPublisher2::PublishProgramNode](../VS_csharp/idebugprogrampublisher2--publishprogramnode.md)