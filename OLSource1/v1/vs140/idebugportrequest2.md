---
title: "IDebugPortRequest2"
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
  - "IDebugPortRequest2"
helpviewer_keywords: 
  - "IDebugPortRequest2 interface"
ms.assetid: 556e610d-7c4b-44a8-965a-76a9d02b601a
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortRequest2
This interface describes a port. This description is used to add the port to a port supplier.  
  
## Syntax  
  
```  
IDebugPortRequest2 : IUnknown  
```  
  
## Notes for Implementers  
 Visual Studio typically implements this interface in the process of getting a debug port from a port supplier.  
  
## Notes for Callers  
 This interface is passed into [IDebugPortSupplier2::AddPort](../vs140/idebugportsupplier2--addport.md) to create a debug port. A call to [IDebugPort2::GetPortRequest](../vs140/idebugport2--getportrequest.md) returns this interface, representing the request used to create the port in the first place.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortRequest2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortName](../vs140/idebugportrequest2--getportname.md)|Gets the name of the port to create.|  
  
## Remarks  
 A debug engine typically does not interact with a port supplier and will have no use for this interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [AddPort](../vs140/idebugportsupplier2--addport.md)   
 [GetPortRequest](../vs140/idebugport2--getportrequest.md)