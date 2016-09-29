---
title: "IDebugPortSupplier2"
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
  - "IDebugPortSupplier2"
helpviewer_keywords: 
  - "IDebugPortSupplier2 interface"
ms.assetid: 37067324-2ea6-4a01-8829-a6e9c7a70068
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplier2
This interface supplies ports to the session debug manager (SDM).  
  
## Syntax  
  
```  
IDebugPortSupplier2 : IUnknown  
```  
  
## Notes for Implementers  
 A custom port supplier implements this interface to represent a port supplier.  
  
## Notes for Callers  
 A call to `CoCreateInstance` with a port supplier's `GUID` returns this interface (this is the typical way to obtain this interface). For example:  
  
```cpp#  
IDebugPortSupplier2 *GetPortSupplier(GUID *pPortSupplierGuid)  
{  
    IDebugPortSupplier2 *pPS = NULL;  
    if (pPortSupplierGuid != NULL) {  
        CComPtr<IDebugPortSupplier2> spPortSupplier;  
        spPortSupplier.CoCreateInstance(*pPortSupplierGuid);  
        if (spPortSupplier != NULL) {  
            pPS = spPortSupplier.Detach();  
        }  
    }  
    return (pPS);  
}  
```  
  
 A call to [IDebugCoreServer2::GetPortSupplier](../VS_csharp/idebugcoreserver2--getportsupplier.md) returns this interface, representing the current port supplier being used by [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
 [IDebugPort2::GetPortSupplier](../VS_csharp/idebugport2--getportsupplier.md) returns this interface, representing the port supplier that created the port.  
  
 [IEnumDebugPortSuppliers2](../VS_csharp/ienumdebugportsuppliers2.md) represents a list of `IDebugPortSupplier` interfaces (the `IEnumDebugPortSuppliers` interface is obtained from [IDebugCoreServer2::EnumPortSuppliers](../VS_csharp/idebugcoreserver2--enumportsuppliers.md), representing all of the port suppliers registered with [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]).  
  
 A debug engine typically does not interact with a port supplier.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugPortSupplier2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPortSupplierName](../VS_csharp/idebugportsupplier2--getportsuppliername.md)|Gets the port supplier name.|  
|[GetPortSupplierId](../VS_csharp/idebugportsupplier2--getportsupplierid.md)|Gets the port supplier identifier.|  
|[GetPort](../VS_csharp/idebugportsupplier2--getport.md)|Gets a port from a port supplier.|  
|[EnumPorts](../VS_csharp/idebugportsupplier2--enumports.md)|Enumerates the ports that already exist.|  
|[CanAddPort](../VS_csharp/idebugportsupplier2--canaddport.md)|Verifies that a port supplier supports adding new ports.|  
|[AddPort](../VS_csharp/idebugportsupplier2--addport.md)|Adds a port.|  
|[RemovePort](../VS_csharp/idebugportsupplier2--removeport.md)|Removes a port.|  
  
## Remarks  
 A port supplier can identify itself by name and ID, add and remove ports, and enumerate all ports that the port supplier provides.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../VS_csharp/core-interfaces.md)   
 [IDebugPort2::GetPortSupplier](../VS_csharp/idebugport2--getportsupplier.md)   
 [IDebugCoreServer2::GetPortSupplier](../VS_csharp/idebugcoreserver2--getportsupplier.md)   
 [IEnumDebugPortSuppliers2](../VS_csharp/ienumdebugportsuppliers2.md)