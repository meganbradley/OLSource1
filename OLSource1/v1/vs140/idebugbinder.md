---
title: "IDebugBinder"
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
  - "IDebugBinder"
helpviewer_keywords: 
  - "IDebugBinder interface"
ms.assetid: d1f31e5b-c6e2-4e02-8959-b3e86041b29c
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface binds a symbol field, typically returned by the symbol provider, to a memory context or object that contains the symbol's current value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 This interface supports expression evaluation and must be implemented by the debug engine (DE).  
  
## Notes for Callers  
 This interface is used in the process of expression evaluation and is typically used in the implementation of [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) and [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md).  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[Bind](../vs140/idebugbinder--bind.md)|Gets the memory context or object that contains the symbol's current value.|  
|[ResolveRuntimeType](../vs140/idebugbinder--resolveruntimetype.md)|Determines the run-time type of an object.|  
|[GetMemoryContext](../vs140/idebugbinder--getmemorycontext.md)|Converts an object location or memory address to a memory context.|  
|[GetFunctionObject](../vs140/idebugbinder--getfunctionobject.md)|Gets an [IDebugFunctionObject](../vs140/idebugfunctionobject.md) object used to create function parameters.|  
|[IDebugBinder::ResolveDynamicType](../vs140/idebugbinder--resolvedynamictype.md)|Gets the exact type for a variable.|  
  
## Remarks  
 This interface returns objects that are used by the expression evaluator in parse trees. The expression evaluator parses an expression by using the symbol provider to convert the symbols in the expression to instances of [IDebugField](../vs140/idebugfield.md), which describe each symbol in terms of its type and location in the source code. The [IDebugBinder::Bind](../vs140/idebugbinder--bind.md) method converts <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects to [IDebugObject](../vs140/idebugobject.md) objects that connect or bind a symbol type to an actual value in memory. These <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects are then stored in a parse tree for later evaluation.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../vs140/expression-evaluation-interfaces.md)   
 [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md)   
 [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md)   
 [IDebugFunctionObject](../vs140/idebugfunctionobject.md)