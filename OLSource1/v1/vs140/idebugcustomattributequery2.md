---
title: "IDebugCustomAttributeQuery2"
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
  - "IDebugCustomAttributeQuery2"
helpviewer_keywords: 
  - "IDebugCustomAttributeQuery interface"
  - "IDebugCustomAttributeQuery2 interface"
ms.assetid: 7cfa23e4-a05a-47a3-af6c-bd40c655014b
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttributeQuery2
Determines the existence of a custom attribute for this field and, if it exists, returns the attribute information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements [IDebugField](../vs140/idebugfield.md) in order to support custom attributes.  
  
## Notes for Callers  
 Use [QueryInterface](../vs140/queryinterface.md) to obtain this interface from the [IDebugField](../vs140/idebugfield.md) interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of the **IDebugCustomAttributeQuery** interface.  
  
|Method|Description|  
|------------|-----------------|  
|[IsCustomAttributeDefined](../vs140/idebugcustomattributequery2--iscustomattributedefined.md)|Determines whether a custom attribute exists by name.|  
|[GetCustomAttributeByName](../vs140/idebugcustomattributequery2--getcustomattributebyname.md)|Gets the attribute information for the given custom attribute.|  
  
 In addition to the **IDebugCustomAttributeQuery** methods, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumCustomAttributes](../vs140/idebugcustomattributequery2--enumcustomattributes.md)|Gets an enumerator for all custom attributes attached to this field.|  
  
## Remarks  
 The [IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md) method can return an enumerator for all custom attributes defined for this field.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IEnumDebugCustomAttributes](../vs140/ienumdebugcustomattributes.md)