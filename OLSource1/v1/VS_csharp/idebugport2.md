---
title: "IDebugPort2"
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
  - "IDebugPort2"
helpviewer_keywords: 
  - "IDebugPort2 interface"
ms.assetid: 8fd87f05-a950-4d14-b925-98be29d4facc
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPort2
This interface represents a debug port on a machine.  
  
## Syntax  
  
```  
IDebugPort2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to represent a debug port on a machine.  
  
 If the port supports sending port events, it must also implement the <xref:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer*> interface to support an <xref:System.Runtime.InteropServices.ComTypes.IConnectionPoint*> interface that in turn provides the [IDebugPortEvents2](../VS_csharp/idebugportevents2.md) interface.  
  
## Notes for Callers  
 Calls to [IDebugPortSupplier2::GetPort](../VS_csharp/idebugportsupplier2--getport.md) or [IDebugPortSupplier2::AddPort](../VS_csharp/idebugportsupplier2--addport.md) return this interface, representing the requested port.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPort2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortName](../VS_csharp/idebugport2--getportname.md)|Returns the port name.|  
|[GetPortId](../VS_csharp/idebugport2--getportid.md)|Returns the port identifier.|  
|[GetPortRequest](../VS_csharp/idebugport2--getportrequest.md)|Returns the request used to create a port (if available).|  
|[GetPortSupplier](../VS_csharp/idebugport2--getportsupplier.md)|Returns the port supplier for this port.|  
|[GetProcess](../VS_csharp/idebugport2--getprocess.md)|Returns an interface to the process given the process's identifier.|  
|[EnumProcesses](../VS_csharp/idebugport2--enumprocesses.md)|Enumerates all the processes running on a port.|  
  
## Remarks  
 The local port provides access to all the processes and programs running on the local machine. Other ports might represent a serial cable connection to a Windows CE-based device, or a network connection to a non-DCOM computer. The `IDebugPort2` interface is used to find the name and identifier of a port, enumerate all processes running on the port, and provide facilities for launching and terminating processes on the port.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugPortSupplier2](../VS_csharp/idebugportsupplier2.md)   
 [IDebugCoreServer2](../VS_csharp/idebugcoreserver2.md)