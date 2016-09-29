---
title: "IDebugArrayField"
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
  - "IDebugArrayField"
helpviewer_keywords: 
  - "IDebugArrayField interface"
ms.assetid: 9667b0a5-4295-46cc-9388-b75c1350be15
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayField
This interface describes an array symbol or type.  
  
## Syntax  
  
```  
IDebugArrayField : IDebugContainerField  
```  
  
## Notes for Implementers  
 The symbol provider implements this interface on the same object that implements the [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interface. This interface is a specialization that represents array objects.  
  
## Notes for Callers  
 Use [QueryInterface](../VS_csharp/queryinterface.md) to obtain this interface from the [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interface if [IDebugField::GetKind](../VS_csharp/idebugfield--getkind.md) returns the flag `FIELD_TYPE_ARRAY`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../VS_csharp/idebugfield.md) and [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interfaces, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[GetNumberOfElements](../VS_csharp/idebugarrayfield--getnumberofelements.md)|Gets the number of elements in the array.|  
|[GetElementType](../VS_csharp/idebugarrayfield--getelementtype.md)|Gets the type of element in the array.|  
|[GetRank](../VS_csharp/idebugarrayfield--getrank.md)|Gets the rank of the array.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../VS_csharp/symbol-provider-interfaces.md)   
 [IDebugContainerField](../VS_csharp/idebugcontainerfield.md)   
 [IDebugField](../VS_csharp/idebugfield.md)