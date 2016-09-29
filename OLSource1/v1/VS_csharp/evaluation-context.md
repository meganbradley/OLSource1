---
title: "Evaluation Context"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, context"
ms.assetid: 008a20c7-1b27-4013-bf96-d6a3f510da02
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Evaluation Context
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When the debug engine (DE) calls the expression evaluator (EE), three arguments passed to [IDebugParsedExpression::EvaluateSync](../VS_csharp/idebugparsedexpression--evaluatesync.md) determine the context for finding and evaluating symbols, as shown in the following table.  
  
## Arguments  
  
|Argument|Description|  
|--------------|-----------------|  
|`pSymbolProvider`|An [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md) interface that specifies the symbol handler (SH) to be used to identify the symbol.|  
|`pAddress`|An [IDebugAddress](../VS_csharp/idebugaddress.md) interface that specifies the current point of execution. This can be used to find the method that contains the code being executed.|  
|`pBinder`|An [IDebugBinder](../VS_csharp/idebugbinder.md) interface that can be used to find the value and type of a symbol given its name.|  
  
 `IDebugParsedExpression::EvaluateSync` returns an [IDebugProperty2](../VS_csharp/idebugproperty2.md) interface representing the resulting value and its type.  
  
## See Also  
 [Key Expression Evaluator Interfaces](../VS_csharp/key-expression-evaluator-interfaces.md)   
 [Displaying Locals](../VS_csharp/displaying-locals.md)   
 [IDebugParsedExpression::EvaluateSync](../VS_csharp/idebugparsedexpression--evaluatesync.md)   
 [IDebugProperty2](../VS_csharp/idebugproperty2.md)   
 [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md)   
 [IDebugAddress](../VS_csharp/idebugaddress.md)   
 [IDebugBinder](../VS_csharp/idebugbinder.md)