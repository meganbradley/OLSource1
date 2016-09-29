---
title: "IEnumDebugFields"
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
  - "IEnumDebugFields"
helpviewer_keywords: 
  - "IEnumDebugFields interface"
ms.assetid: 403c2a51-3ba5-431f-a1dd-2f3b2046c00c
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugFields
This interface represents a collection of objects implementing the [IDebugField](../vs140/idebugfield.md) interface.  
  
## Syntax  
  
```  
IEnumDebugFields : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by the symbol provider to provide sets of objects that implement the [IDebugField](../vs140/idebugfield.md) interface. Note that this is not a standard COM enumeration due to the presence of the [IEnumDebugFields::GetCount](../vs140/ienumdebugfields--getcount.md) method.  
  
## Notes for Callers  
 This interface is returned by [IDebugSymbolProvider::GetMethodFieldsByName](../vs140/idebugsymbolprovider--getmethodfieldsbyname.md) and [IDebugSymbolProvider::GetNamespacesUsedAtAddress](../vs140/idebugsymbolprovider--getnamespacesusedataddress.md).  
  
## Methods in Vtable order  
 This interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IEnumDebugFields::Next](../vs140/ienumdebugfields--next.md)|Retrieves the next set of [IDebugField](../vs140/idebugfield.md) objects from the enumeration.|  
|[IEnumDebugFields::Skip](../vs140/ienumdebugfields--skip.md)|Skips a specified number of entries.|  
|[IEnumDebugFields::Reset](../vs140/ienumdebugfields--reset.md)|Resets the enumeration to the first entry.|  
|[IEnumDebugFields::Clone](../vs140/ienumdebugfields--clone.md)|Retrieves a copy of the current enumeration.|  
|[IEnumDebugFields::GetCount](../vs140/ienumdebugfields--getcount.md)|Retrieves the number of entries in the enumeration.|  
  
## Remarks  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugSymbolProvider::GetMethodFieldsByName](../vs140/idebugsymbolprovider--getmethodfieldsbyname.md)   
 [IDebugSymbolProvider::GetNamespacesUsedAtAddress](../vs140/idebugsymbolprovider--getnamespacesusedataddress.md)