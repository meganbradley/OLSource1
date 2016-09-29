---
title: "IEnumDebugPortSuppliers2"
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
  - "IEnumDebugPortSuppliers2"
helpviewer_keywords: 
  - "IEnumDebugPortSuppliers2"
ms.assetid: cd0a73dc-dd25-46fd-8c4f-5b011501afeb
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugPortSuppliers2
This interface enumerates port suppliers.  
  
## Syntax  
  
```  
IEnumDebugPortSuppliers2 : IUnknown  
```  
  
## Notes for Implementers  
 Visual Studio implements this interface to represent a list of port suppliers.  
  
## Notes for Callers  
 Call [IDebugCoreServer2::EnumPortSuppliers](../vs140/idebugcoreserver2--enumportsuppliers.md) to obtain a list of port suppliers.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugPortSuppliers2`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../vs140/ienumdebugportsuppliers2--next.md)|Retrieves a specified number of port suppliers in an enumeration sequence.|  
|[Skip](../vs140/ienumdebugportsuppliers2--skip.md)|Skips a specified number of port suppliers in an enumeration sequence.|  
|[Reset](../vs140/ienumdebugportsuppliers2--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../vs140/ienumdebugportsuppliers2--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../vs140/ienumdebugportsuppliers2--getcount.md)|Gets the number of port suppliers in an enumerator.|  
  
## Remarks  
 A debug engine generally does not need to obtain this interface.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [EnumPortSuppliers](../vs140/idebugcoreserver2--enumportsuppliers.md)