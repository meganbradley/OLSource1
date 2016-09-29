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
 A symbol provider implements this interface on the same object that implements the [IDebugContainerField](../vs140/idebugcontainerfield.md) interface. This interface is a specialization that represents a class type.  
  
## Notes for Callers  
 A number of interfaces have methods that can return this interface including [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md), [IDebugMethodField](../vs140/idebugmethodfield.md), and [IDebugCustomAttribute](../vs140/idebugcustomattribute.md). Also, you can use [QueryInterface](../vs140/queryinterface.md) to obtain this interface from the [IDebugContainerField](../vs140/idebugcontainerfield.md) interface if the [IDebugField::GetKind](../vs140/idebugfield--getkind.md) method returns the flag `FIELD_TYPE_CLASS`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../vs140/idebugfield.md) and [IDebugContainerField](../vs140/idebugcontainerfield.md) interfaces, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumBaseClasses](../vs140/idebugclassfield--enumbaseclasses.md)|Creates an enumerator for the base classes of this class.|  
|[DoesInterfaceExist](../vs140/idebugclassfield--doesinterfaceexist.md)|Determines if a specific interface is defined in the class.|  
|[EnumNestedClasses](../vs140/idebugclassfield--enumnestedclasses.md)|Creates an enumerator for the nested classes of this class.|  
|[GetEnclosingClass](../vs140/idebugclassfield--getenclosingclass.md)|Gets the class that encloses this class.|  
|[EnumInterfacesImplemented](../vs140/idebugclassfield--enuminterfacesimplemented.md)|Creates an enumerator for the interfaces implemented by this class.|  
|[EnumConstructors](../vs140/idebugclassfield--enumconstructors.md)|Creates an enumerator for the constructors of this class.|  
|[GetDefaultIndexer](../vs140/idebugclassfield--getdefaultindexer.md)|Gets the name of the default indexer.|  
|[EnumNestedEnums](../vs140/idebugclassfield--enumnestedenums.md)|Creates an enumerator for the nested enumerators of this class.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugContainerField](../vs140/idebugcontainerfield.md)