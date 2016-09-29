---
title: "IDebugArrayObject"
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
  - "IDebugArrayObject"
helpviewer_keywords: 
  - "IDebugArrayObject method"
ms.assetid: a1c8e77e-dee1-4748-a516-6ab032a8f54f
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayObject
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents an array object.  
  
## Syntax  
  
```  
IDebugArrayObject : IDebugObject  
```  
  
## Notes for Implementers  
 The expression evaluator implements this interface to represent an array.  
  
## Notes for Callers  
 The [IDebugObject](../vs140/idebugobject.md) interface can obtain this interface by using [QueryInterface](../vs140/queryinterface.md) if the object represents an array.  
  
## Methods in Vtable Order  
 In addition to the methods on the `IDebugObject` interface, the following methods are implemented on the `IDebugArrayObject` interface.  
  
|Method|Description|  
|------------|-----------------|  
|[GetCount](../vs140/idebugarrayobject--getcount.md)|Gets the count of elements in the array.|  
|[GetElement](../vs140/idebugarrayobject--getelement.md)|Gets an element of the array.|  
|[GetElements](../vs140/idebugarrayobject--getelements.md)|Gets all elements of the array.|  
|[GetRank](../vs140/idebugarrayobject--getrank.md)|Gets the rank of the array.|  
|[GetDimensions](../vs140/idebugarrayobject--getdimensions.md)|Gets the dimensions of the array.|  
  
## Remarks  
 An expression evaluator uses this interface to represent arrays in a parse tree.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)