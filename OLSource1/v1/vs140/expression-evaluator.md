---
title: "Expression Evaluator"
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
  - "expressions [Debugging SDK]"
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation"
ms.assetid: f9381b2f-99aa-426c-aea0-d9c15f3c859b
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Expression Evaluator
Expression evaluators (EE) examine the syntax of a language to parse and evaluate variables and expressions at run time, allowing them to be viewed by the user when the IDE is in break mode.  
  
## Using Expression Evaluators  
 Expressions are created using the [ParseText](../vs140/idebugexpressioncontext2--parsetext.md) method, as follows:  
  
1.  The debug engine (DE) implements the [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md) interface.  
  
2.  The debug package gets an `IDebugExpressionContext2` object from an [IDebugStackFrame2](../vs140/idebugstackframe2.md) interface and then calls the `IDebugStackFrame2::ParseText` method on it to get an [IDebugExpression2](../vs140/idebugexpression2.md) object.  
  
3.  The debug package calls the [EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) method or the [EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md) method to get the value of the expression. `IDebugExpression2::EvaluateAsync` is called from the Command/Immediate window. All other UI components call `IDebugExpression2::EvaluateSync`.  
  
4.  The result of expression evaluation is an [IDebugProperty2](../vs140/idebugproperty2.md) object, which contains the name, type, and value of the result of the expression evaluation.  
  
 During expression evaluation, the EE requires information from the symbol provider component. The symbol provider supplies the symbolic information used for identifying and understanding the parsed expression.  
  
 When asynchronous expression evaluation is complete, an asynchronous event is sent by the DE through the session debug manager (SDM) to notify the IDE that expression evaluation is complete. When synchronous expression evaluation is complete, the result of the evaluation is returned from the call to the `IDebugExpression2::EvaluateSync` method.  
  
## Implementation Notes  
 The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debug engines expect to talk with the expression evaluator using Common Language Runtime (CLR) interfaces. As a result, an expression evaluator that works with the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debug engines must support the CLR (a complete list of all CLR debugging interfaces can be found in debugref.doc, which is part of the [!INCLUDE[winsdklong](../vs140/includes/winsdklong_md.md)]).  
  
## See Also  
 [Debugger Components](../vs140/debugger-components.md)