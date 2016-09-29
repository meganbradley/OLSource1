---
title: "IDebugPortSupplier2::AddPort"
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
  - "IDebugPortSupplier2::AddPort"
helpviewer_keywords: 
  - "IDebugPortSupplier2::AddPort"
ms.assetid: df491161-6bf3-4fcc-b478-b9ec88ec995f
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortSupplier2::AddPort
Adds a port.  
  
## Syntax  
  
```cpp#  
HRESULT AddPort(   
   IDebugPortRequest2* pRequest,  
   IDebugPort2**       ppPort  
);  
```  
  
```c#  
int AddPort(   
   IDebugPortRequest2 pRequest,  
   out IDebugPort2    ppPort  
);  
```  
  
#### Parameters  
 `pRequest`  
 [in] An [IDebugPortRequest2](../vs140/idebugportrequest2.md) object that describes the port to be added.  
  
 `ppPort`  
 [out] Returns an [IDebugPort2](../vs140/idebugport2.md) object that represents the port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method actually creates the requested port as well as adding it to the port supplier's internal list of active ports. The [IDebugPortSupplier2::CanAddPort](../vs140/idebugportsupplier2--canaddport.md) method can be called first to avoid possible time-consuming delays.  
  
## See Also  
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)   
 [IDebugPortRequest2](../vs140/idebugportrequest2.md)   
 [IDebugPort2](../vs140/idebugport2.md)   
 [IDebugPortSupplier2::CanAddPort](../vs140/idebugportsupplier2--canaddport.md)