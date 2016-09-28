---
title: "Expression Evaluation in Break Mode"
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
  - "break mode, expression evaluation"
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, break mode"
ms.assetid: 34fe5b58-15d5-4387-a266-72120f90a4b6
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Expression Evaluation in Break Mode
The following describes the process that occurs when the debugger is in break mode and must conduct expression evaluation.  
  
## Expression Evaluation Process  
 These are the basic steps involved in evaluating an expression:  
  
1.  The session debug manager (SDM) calls [IDebugStackFrame2::GetExpressionContext](../vs140/idebugstackframe2--getexpressioncontext.md) to obtain an expression context interface, [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md).  
  
2.  The SDM then calls [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md) with the string to be parsed.  
  
3.  If ParseText does not return S_OK, the reason for the error is returned.  
  
     -otherwise-  
  
     If ParseText does return S_OK, the SDM can then call either [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md) to obtain a final value from the parsed expression.  
  
    -   In the case of using `IDebugExpression2::EvaluateSync`, the given callback interface is used to communicate the ongoing process of the evaluation. The final value is returned in an [IDebugProperty2](../vs140/idebugproperty2.md) interface.  
  
    -   In the case of using `IDebugExpression2::EvaluateAsync`, the given callback interface is used to communicate the ongoing process of the evaluation. Once the evaluation is complete, EvaluateAsync sends an [IDebugExpressionEvaluationCompleteEvent2](../vs140/idebugexpressionevaluationcompleteevent2.md) interface through the callback. With this event interface, the final value can be obtained with [IDebugExpressionEvaluationCompleteEvent2::GetResult](../vs140/idebugexpressionevaluationcompleteevent2--getresult.md).  
  
## See Also  
 [Calling Debugger Events](../vs140/calling-debugger-events.md)