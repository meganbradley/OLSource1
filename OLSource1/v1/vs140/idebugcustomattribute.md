---
title: "IDebugCustomAttribute"
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
  - "IDebugCustomAttribute"
helpviewer_keywords: 
  - "IDebugCustomAttribute interface"
ms.assetid: c5ae41e9-00b9-4cca-871d-b8de9ef390d1
caps.latest.revision: 17
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttribute
This interface represents a custom attribute, and it can provide the name, parent, and class type of the attribute.  
  
## Syntax  
  
```  
IDebugCustomAttribute : IUnknown  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface in order to support custom attributes associated with a symbol. It is typically implemented on its own object.  
  
## Notes for Callers  
 A call to [IEnumDebugCustomAttributes::Next](../vs140/ienumdebugcustomattributes--next.md) returns this interface. A call to the [IDebugCustomAttributeQuery2::EnumCustomAttributes](../vs140/idebugcustomattributequery2--enumcustomattributes.md) method returns the [IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugCustomAttribute`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetParentField](../vs140/idebugcustomattribute--getparentfield.md)|Gets the field to which the current attribute is attached.|  
|[GetAttributeTypeField](../vs140/idebugcustomattribute--getattributetypefield.md)|Gets the custom attribute class type.|  
|[GetName](../vs140/idebugcustomattribute--getname.md)|Gets the name of the custom attribute.|  
|[GetAttributeBytes](../vs140/idebugcustomattribute--getattributebytes.md)|Gets the attribute information as a blob of bytes.|  
  
## Remarks  
 A custom attribute is a structure for C# that supplies custom metadata associated with a particular class or method.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugCustomAttributeQuery2](../vs140/idebugcustomattributequery2.md)   
 [IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md)