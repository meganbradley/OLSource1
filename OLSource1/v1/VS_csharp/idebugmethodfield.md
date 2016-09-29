---
title: "IDebugMethodField"
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
  - "IDebugMethodField"
helpviewer_keywords: 
  - "IDebugMethodField interface"
ms.assetid: a7dc9030-fc98-4cf1-b943-37a4003300b6
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField
This interface describes a method.  
  
## Syntax  
  
```  
IDebugMethodField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interface. This interface is a specialization that presents a method.  
  
## Notes for Callers  
 Use [QueryInterface](../VS_csharp/queryinterface.md) to obtain this interface from the [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interface if [IDebugField::GetKind](../VS_csharp/idebugfield--getkind.md) returns `FIELD_TYPE_METHOD`. In addition, the methods, [IDebugPropertyField::GetPropertyGetter](../VS_csharp/idebugpropertyfield--getpropertygetter.md), [IDebugPropertyField::GetPropertySetter](../VS_csharp/idebugpropertyfield--getpropertysetter.md), and [IDebugClassField::EnumConstructors](../VS_csharp/idebugclassfield--enumconstructors.md), all return the `IDebugMethodField` interface.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../VS_csharp/idebugfield.md) and [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interfaces, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumParameters](../VS_csharp/idebugmethodfield--enumparameters.md)|Creates an enumerator for the parameters of the method.|  
|[GetThis](../VS_csharp/idebugmethodfield--getthis.md)|Gets the "this" pointer of the object containing the method.|  
|[EnumAllLocals](../VS_csharp/idebugmethodfield--enumalllocals.md)|Creates an enumerator for all local variables of the method.|  
|[EnumLocals](../VS_csharp/idebugmethodfield--enumlocals.md)|Creates an enumerator for selected local variables of the method.|  
|[IsCustomAttributeDefined](../VS_csharp/idebugmethodfield--iscustomattributedefined.md)|Determines whether a specific custom attribute has been defined.|  
|[EnumStaticLocals](../VS_csharp/idebugmethodfield--enumstaticlocals.md)|Creates an enumerator for static local variables of the method.|  
|[GetGlobalContainer](../VS_csharp/idebugmethodfield--getglobalcontainer.md)|Gets the global container of the method.|  
|[EnumArguments](../VS_csharp/idebugmethodfield--enumarguments.md)|Creates an enumerator for the type of each argument required to call the method.|  
  
## Remarks  
 A method can contain parameters as well as local variables.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../VS_csharp/symbol-provider-interfaces.md)   
 [IDebugContainerField](../VS_csharp/idebugcontainerfield.md)   
 [IDebugField](../VS_csharp/idebugfield.md)