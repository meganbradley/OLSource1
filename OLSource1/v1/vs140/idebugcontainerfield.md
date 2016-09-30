---
title: "IDebugContainerField"
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
  - "IDebugContainerField"
helpviewer_keywords: 
  - "IDebugContainerField interface"
ms.assetid: a8bbe061-c382-4fe9-a193-3f7d12216041
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugContainerField
This interface represents a symbol or type that is a container for other symbols or types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugField](../vs140/idebugfield.md) interface. This interface is also the base class for all interfaces that represent containers.  
  
## Notes for Callers  
 Many methods on many interfaces return this interface. Because this is a base class for all containers, more specialized interfaces can obtained from this interface by using [QueryInterface](../vs140/queryinterface.md). Such interfaces include [IDebugArrayField](../vs140/idebugarrayfield.md), [IDebugClassField](../vs140/idebugclassfield.md), [IDebugMethodField](../vs140/idebugmethodfield.md), and [IDebugPropertyField](../vs140/idebugpropertyfield.md).  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../vs140/idebugfield.md) interface, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumFields](../vs140/idebugcontainerfield--enumfields.md)|Creates an enumerator for the fields of the container.|  
  
## Remarks  
 Arrays (containers for variables), classes (containers for methods and variables) and methods (containers for parameters and local variables) are all examples of containers.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../vs140/symbol-provider-interfaces.md)   
 [IDebugField](../vs140/idebugfield.md)