---
title: "IDebugExpressionEvaluator3"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - IDebugExpressionEvaluator3 interface
ms.assetid: c27c2a14-300b-4535-be22-767c83602f69
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugExpressionEvaluator3
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Represents an expression evaluator (EE) with an enhanced parser tree.  
  
## Syntax  
  
```  
IDebugExpressionEvaluator3 : IDebugExpressionEvaluator2  
```  
  
## Notes for Callers  
 This version of the parser passes the symbol provider and address of the evaluating frame.  
  
## Methods  
 In addition to the methods on the [IDebugExpressionEvaluator2](../vs140/idebugexpressionevaluator2.md) interface, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugExpressionEvaluator3::Parse2](../vs140/idebugexpressionevaluator3--parse2.md)|Converts an expression string to a parsed expression given the symbol provider and the address of the evaluating frame.|  
  
## Requirements  
 Header: Ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll