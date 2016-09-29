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
This interface represents a collection of objects implementing the [IDebugAddress](../VS_csharp/idebugaddress.md) interface.  
  
## Syntax  
  
```  
IEnumDebugAdresses : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by the symbol provider to provide sets of objects that implement the [IDebugAddress](../VS_csharp/idebugaddress.md) interface. Note that this is not a standard COM enumeration due to the presence of the [IEnumDebugAddresses::GetCount](../VS_csharp/ienumdebugaddresses--getcount.md) method.  
  
## Notes for Callers  
 This interface is returned by [IDebugSymbolProvider::GetAddressesFromContext](../VS_csharp/idebugsymbolprovider--getaddressesfromcontext.md) and [IDebugSymbolProvider::GetAddressesFromPosition](../VS_csharp/idebugsymbolprovider--getaddressesfromposition.md).  
  
## Methods in Vtable order  
 This interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugAddresses::Next](../VS_csharp/ienumdebugaddresses--next.md)|Retrieves the next set of [IDebugAddress](../VS_csharp/idebugaddress.md) objects from the enumeration.|  
|[IEnumDebugAddresses::Skip](../VS_csharp/ienumdebugaddresses--skip.md)|Skips a specified number of entries.|  
|[IEnumDebugAddresses::Reset](../VS_csharp/ienumdebugaddresses--reset.md)|Resets the enumeration to the first entry.|  
|[IEnumDebugAddresses::Clone](../VS_csharp/ienumdebugaddresses--clone.md)|Retrieves a copy of the current enumeration.|  
|[IEnumDebugAddresses::GetCount](../VS_csharp/ienumdebugaddresses--getcount.md)|Retrieves the number of entries in the enumeration.|  
  
## Remarks  
 This interface is typically used by the debug engine to help determine the appropriate address to give to the expression evaluator.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../VS_csharp/symbol-provider-interfaces.md)   
 [IDebugAddress](../VS_csharp/idebugaddress.md)   
 [IDebugSymbolProvider::GetAddressesFromContext](../VS_csharp/idebugsymbolprovider--getaddressesfromcontext.md)   
 [IDebugSymbolProvider::GetAddressesFromPosition](../VS_csharp/idebugsymbolprovider--getaddressesfromposition.md)