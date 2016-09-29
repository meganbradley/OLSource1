---
title: "IDebugClassField"
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
  - "IDebugClassField"
helpviewer_keywords: 
  - "IDebugClassField interface"
ms.assetid: 49358cbc-8973-4862-9dcc-79b1248e6712
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField
This interface represents a class as a type.  
  
## Syntax  
  
```  
IDebugClassField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interface. This interface is a specialization that represents a class type.  
  
## Notes for Callers  
 A number of interfaces have methods that can return this interface including [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md), [IDebugMethodField](../VS_csharp/idebugmethodfield.md), and [IDebugCustomAttribute](../VS_csharp/idebugcustomattribute.md). Also, you can use [QueryInterface](../VS_csharp/queryinterface.md) to obtain this interface from the [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interface if the [IDebugField::GetKind](../VS_csharp/idebugfield--getkind.md) method returns the flag `FIELD_TYPE_CLASS`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../VS_csharp/idebugfield.md) and [IDebugContainerField](../VS_csharp/idebugcontainerfield.md) interfaces, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumBaseClasses](../VS_csharp/idebugclassfield--enumbaseclasses.md)|Creates an enumerator for the base classes of this class.|  
|[DoesInterfaceExist](../VS_csharp/idebugclassfield--doesinterfaceexist.md)|Determines if a specific interface is defined in the class.|  
|[EnumNestedClasses](../VS_csharp/idebugclassfield--enumnestedclasses.md)|Creates an enumerator for the nested classes of this class.|  
|[GetEnclosingClass](../VS_csharp/idebugclassfield--getenclosingclass.md)|Gets the class that encloses this class.|  
|[EnumInterfacesImplemented](../VS_csharp/idebugclassfield--enuminterfacesimplemented.md)|Creates an enumerator for the interfaces implemented by this class.|  
|[EnumConstructors](../VS_csharp/idebugclassfield--enumconstructors.md)|Creates an enumerator for the constructors of this class.|  
|[GetDefaultIndexer](../VS_csharp/idebugclassfield--getdefaultindexer.md)|Gets the name of the default indexer.|  
|[EnumNestedEnums](../VS_csharp/idebugclassfield--enumnestedenums.md)|Creates an enumerator for the nested enumerators of this class.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../VS_csharp/symbol-provider-interfaces.md)   
 [IDebugContainerField](../VS_csharp/idebugcontainerfield.md)