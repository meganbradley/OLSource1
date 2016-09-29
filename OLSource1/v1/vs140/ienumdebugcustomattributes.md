---
title: "IEnumDebugCustomAttributes"
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
  - "IEnumCustomAttributes"
helpviewer_keywords: 
  - "IEnumDebugCustomAttributes interface"
ms.assetid: 11aa768d-1852-44d6-9de3-17f9bafaded2
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugCustomAttributes
Enumerates custom attributes.  
  
## Syntax  
  
```  
IEnumCustomAttributes : IUnknown  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface to support custom attributes (through the [IDebugCustomAttribute](../vs140/idebugcustomattribute.md) interface).  
  
## Notes for Callers  
 [IDebugCustomAttributeQuery2::EnumCustomAttributes](../vs140/idebugcustomattributequery2--enumcustomattributes.md) returns this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IEnumDebugCustomAttributes`.  
  
|Method|Description|  
|------------|-----------------|  
|[Next](../vs140/ienumdebugcustomattributes--next.md)|Retrieves a specified number of custom attributes in an enumeration sequence.|  
|[Skip](../vs140/ienumdebugcustomattributes--skip.md)|Skips a specified number of custom attributes in an enumeration sequence.|  
|[Reset](../vs140/ienumdebugcustomattributes--reset.md)|Resets an enumeration sequence to the beginning.|  
|[Clone](../vs140/ienumdebugcustomattributes--clone.md)|Creates an enumerator that contains the same enumeration state as the current enumerator.|  
|[GetCount](../vs140/ienumdebugcustomattributes--getcount.md)|Gets the number of custom attributes in an enumerator.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugCustomAttributeQuery2::EnumCustomAttributes](../vs140/idebugcustomattributequery2--enumcustomattributes.md)   
 [IDebugCustomAttribute](../vs140/idebugcustomattribute.md)