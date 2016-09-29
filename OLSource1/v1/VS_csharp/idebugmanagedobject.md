---
title: "IDebugManagedObject"
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
  - "IDebugManagedObject"
helpviewer_keywords: 
  - "IDebugManagedObject interface"
ms.assetid: 3ae09d34-112c-4285-80ee-9f7f8dc414d7
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugManagedObject
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface enables the expression evaluator (EE) to call properties or methods on value class instances (for example, `System.Decimal`) and to set their value without calling [Evaluate](../VS_csharp/idebugfunctionobject--evaluate.md) on the program being debugged.  
  
## Syntax  
  
```  
IDebugManagedObject : IDebugObject  
```  
  
## Notes for Implementers  
 An expression evaluator implements this interface to represent a managed code object such as a variable.  
  
## Notes for Callers  
 To obtain this interface, call [GetManagedDebugObject](../VS_csharp/idebugobject--getmanageddebugobject.md) on an [IDebugObject](../VS_csharp/idebugobject.md) that represents an instance of a value class.  
  
## Methods in Vtable Order  
 In addition to the methods inherited from [IDebugObject](../VS_csharp/idebugobject.md), the `IDebugManagedObject` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[GetManagedObject](../VS_csharp/idebugmanagedobject--getmanagedobject.md)|Returns an interface that represents the managed code object and from which any appropriate managed code interface can be obtained.|  
|[SetFromManagedObject](../VS_csharp/idebugmanagedobject--setfrommanagedobject.md)|Sets the value of this object to the value of a specified managed code object.|  
  
## Remarks  
 An expression evaluator uses this interface to store a managed code object in a parse tree.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../VS_csharp/expression-evaluation-interfaces.md)   
 [Evaluate](../VS_csharp/idebugfunctionobject--evaluate.md)