---
title: "IDebugEnumField"
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
  - "IDebugEnumField"
helpviewer_keywords: 
  - "IDebugEnumField interface"
ms.assetid: 42f685bf-0f39-47f4-98b0-6022efe2bf97
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEnumField
This interface represents an enumeration type.  
  
## Syntax  
  
```  
IDebugEnumField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface to represent an enumeration.  
  
## Notes for Callers  
 Use [QueryInterface](../VS_csharp/queryinterface.md) to obtain this interface from the [IDebugField](../VS_csharp/idebugfield.md) interface if [IDebugField::GetKind](../VS_csharp/idebugfield--getkind.md) returns `FIELD_TYPE_ENUM`.  
  
## Methods in VTable order  
 In addition to the methods on the `IDebugField` and `IDebugContainerField` interfaces, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugEnumField::GetUnderlyingSymbol](../VS_csharp/idebugenumfield--getunderlyingsymbol.md)|Returns an [IDebugField](../VS_csharp/idebugfield.md) describing the name for this enumeration type.|  
|[IDebugEnumField::GetStringFromValue](../VS_csharp/idebugenumfield--getstringfromvalue.md)|Returns the name of the enumeration constant associated with the given value.|  
|[IDebugEnumField::GetValueFromString](../VS_csharp/idebugenumfield--getvaluefromstring.md)|Returns the value associated with the given enumeration constant name|  
|[IDebugEnumField::GetValueFromStringCaseInsensitive](../VS_csharp/idebugenumfield--getvaluefromstringcaseinsensitive.md)|Returns the value associated with the given enumeration constant name but ignoring case.|  
  
## Remarks  
 It is the underlying symbol that is actually bound to a location with [IDebugBinder::Bind](../VS_csharp/idebugbinder--bind.md).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../VS_csharp/symbol-provider-interfaces.md)   
 [IDebugContainerField](../VS_csharp/idebugcontainerfield.md)   
 [IDebugField](../VS_csharp/idebugfield.md)   
 [IDebugBinder::Bind](../VS_csharp/idebugbinder--bind.md)