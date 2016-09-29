---
title: "IDebugFunctionObject"
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
  - "IDebugFunctionObject"
helpviewer_keywords: 
  - "IDebugFunctionObject interface"
ms.assetid: 8d94e97c-a9d1-400c-8a98-a44b5385b33a
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents a function.  
  
## Syntax  
  
```  
IDebugFunctionObject : IDebugObject  
```  
  
## Notes for Implementers  
 An expression evaluator implements this interface to represent a function.  
  
## Notes for Callers  
 This interface is a specialization of the [IDebugObject](../vs140/idebugobject.md) interface and is obtained using [QueryInterface](../vs140/queryinterface.md) on the `IDebugObject` interface.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from [IDebugObject](../vs140/idebugobject.md), the `IDebugFunctionObject` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[CreatePrimitiveObject](../vs140/idebugfunctionobject--createprimitiveobject.md)|Creates a primitive data object.|  
|[CreateObject](../vs140/idebugfunctionobject--createobject.md)|Creates an object using a constructor.|  
|[CreateObjectNoConstructor](../vs140/idebugfunctionobject--createobjectnoconstructor.md)|Creates an object with no constructor.|  
|[CreateArrayObject](../vs140/idebugfunctionobject--createarrayobject.md)|Creates an array object.|  
|[CreateStringObject](../vs140/idebugfunctionobject--createstringobject.md)|Creates a string object.|  
|[Evaluate](../vs140/idebugfunctionobject--evaluate.md)|Calls the function and returns the resulting value as an object.|  
  
## Remarks  
 This interface enables the expression evaluator to represent functions in a parse tree. The `Create` methods in this interface are used to construct objects representing the input parameters to the method. The function can then be executed by calling the [Evaluate](../vs140/idebugfunctionobject--evaluate.md) method, which returns an object representing the return value of the function.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../vs140/expression-evaluation-interfaces.md)   
 [IDebugObject](../vs140/idebugobject.md)