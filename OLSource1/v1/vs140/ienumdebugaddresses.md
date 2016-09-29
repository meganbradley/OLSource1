---
title: "IEnumDebugAddresses"
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
  - "IEnumDebugAddresses"
helpviewer_keywords: 
  - "IEnumDebugAddresses interface"
ms.assetid: 5f6f6751-e6d8-4c5a-8e81-414b6e5d8cc5
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugAddresses
This interface represents a collection of objects implementing the [IDebugAddress](../vs140/idebugaddress.md) interface.  
  
## Syntax  
  
```  
IEnumDebugAdresses : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by the symbol provider to provide sets of objects that implement the [IDebugAddress](../vs140/idebugaddress.md) interface. Note that this is not a standard COM enumeration due to the presence of the [IEnumDebugAddresses::GetCount](../vs140/ienumdebugaddresses--getcount.md) method.  
  
## Notes for Callers  
 This interface is returned by [IDebugSymbolProvider::GetAddressesFromContext](../vs140/idebugsymbolprovider--getaddressesfromcontext.md) and [IDebugSymbolProvider::GetAddressesFromPosition](../vs140/idebugsymbolprovider--getaddressesfromposition.md).  
  
## Methods in Vtable order  
 This interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugAddresses::Next](../vs140/ienumdebugaddresses--next.md)|Retrieves the next set of [IDebugAddress](../vs140/idebugaddress.md) objects from the enumeration.|  
|[IEnumDebugAddresses::Skip](../vs140/ienumdebugaddresses--skip.md)|Skips a specified number of entries.|  
|[IEnumDebugAddresses::Reset](../vs140/ienumdebugaddresses--reset.md)|Resets the enumeration to the first entry.|  
|[IEnumDebugAddresses::Clone](../vs140/ienumdebugaddresses--clone.md)|Retrieves a copy of the current enumeration.|  
|[IEnumDebugAddresses::GetCount](../vs140/ienumdebugaddresses--getcount.md)|Retrieves the number of entries in the enumeration.|  
  
## Remarks  
 This interface is typically used by the debug engine to help determine the appropriate address to give to the expression evaluator.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugAddress](../vs140/idebugaddress.md)   
 [IDebugSymbolProvider::GetAddressesFromContext](../vs140/idebugsymbolprovider--getaddressesfromcontext.md)   
 [IDebugSymbolProvider::GetAddressesFromPosition](../vs140/idebugsymbolprovider--getaddressesfromposition.md)