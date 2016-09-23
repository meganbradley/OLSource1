---
title: "IDebugPort2::GetPortSupplier"
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
  - IDebugPort2::GetPortSupplier
helpviewer_keywords: 
  - IDebugPort2::GetPortSupplier
ms.assetid: 7a7b0615-df6b-4726-ab35-39dfa1ebed8f
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugPort2::GetPortSupplier
Gets the port supplier for this port.  
  
## Syntax  
  
```cpp#  
HRESULT GetPortSupplier(   
   IDebugPortSupplier2** ppSupplier  
);  
```  
  
```c#  
int GetPortSupplier(   
   out IDebugPortSupplier2 ppSupplier  
);  
```  
  
#### Parameters  
 `ppSupplier`  
 [out] Returns an [IDebugPortSupplier2](../vs140/idebugportsupplier2.md) object represents the port supplier for a port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPort2](../vs140/idebugport2.md)   
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)