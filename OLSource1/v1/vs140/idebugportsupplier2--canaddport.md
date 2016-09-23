---
title: "IDebugPortSupplier2::CanAddPort"
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
  - IDebugPortSupplier2::CanAddPort
helpviewer_keywords: 
  - IDebugPortSupplier2::CanAddPort
ms.assetid: 41f69e0a-e82c-473d-8b7a-0c40fc5730fc
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugPortSupplier2::CanAddPort
Verifies that a port supplier can add new ports.  
  
## Syntax  
  
```cpp#  
HRESULT CanAddPort(   
   void   
);  
```  
  
```c#  
int CanAddPort();  
```  
  
## Return Value  
 If the port can be added, returns `S_OK`; otherwise, returns `S_FALSE` to indicate no ports can be added to this port supplier.  
  
## Remarks  
 Call this method before calling the [IDebugPortSupplier2::AddPort](../vs140/idebugportsupplier2--addport.md) method since the latter method creates the port as well as adding it, which could be a time-consuming operation.  
  
## See Also  
 [IDebugPortSupplier2](../vs140/idebugportsupplier2.md)   
 [IDebugPortSupplier2::AddPort](../vs140/idebugportsupplier2--addport.md)