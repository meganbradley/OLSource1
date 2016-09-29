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
ms.author: "gregvanl"
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
 A call to [IEnumDebugCustomAttributes::Next](../VS_csharp/ienumdebugcustomattributes--next.md) returns this interface. A call to the [IDebugCustomAttributeQuery2::EnumCustomAttributes](../VS_csharp/idebugcustomattributequery2--enumcustomattributes.md) method returns the [IEnumDebugCustomAttributes](../VS_csharp/ienumdebugcustomattributes.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugCustomAttribute`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetParentField](../VS_csharp/idebugcustomattribute--getparentfield.md)|Gets the field to which the current attribute is attached.|  
|[GetAttributeTypeField](../VS_csharp/idebugcustomattribute--getattributetypefield.md)|Gets the custom attribute class type.|  
|[GetName](../VS_csharp/idebugcustomattribute--getname.md)|Gets the name of the custom attribute.|  
|[GetAttributeBytes](../VS_csharp/idebugcustomattribute--getattributebytes.md)|Gets the attribute information as a blob of bytes.|  
  
## Remarks  
 A custom attribute is a structure for C# that supplies custom metadata associated with a particular class or method.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../VS_csharp/symbol-provider-interfaces.md)   
 [IDebugField](../VS_csharp/idebugfield.md)   
 [IDebugCustomAttributeQuery2](../VS_csharp/idebugcustomattributequery2.md)   
 [IEnumDebugCustomAttributes](../VS_csharp/ienumdebugcustomattributes.md)