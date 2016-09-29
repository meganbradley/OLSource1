---
title: "Expression Evaluator Architecture"
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
  - "architecture, expression evaluators"
  - "expression evaluators, architecture"
  - "debugging [Debugging SDK], expression evaluators"
ms.assetid: aad7c4c6-1dc1-4d32-b975-f1fdf76bdeda
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Expression Evaluator Architecture
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Integrating a proprietary language into the Visual Studio debug package means implementing the required expression evaluator (EE) interfaces and calling the common language run-time symbol provider (SP) and binder interfaces. The SP and binder objects, together with the current execution address, are the context in which expressions are evaluated. The information that these interfaces produce and consume represents the key concepts in the architecture of an EE.  
  
## Overview  
  
### Parsing the Expression  
 When you are debugging a program, expressions are evaluated for a number of reasons but always when the program being debugged has been stopped at a breakpoint (either a breakpoint placed by the user or one caused by an exception). It is at this moment when Visual Studio obtains a stack frame, as represented by the [IDebugStackFrame2](../VS_csharp/idebugstackframe2.md) interface, from the debug engine (DE). Visual Studio then calls [IDebugStackFrame2::GetExpressionContext](../VS_csharp/idebugstackframe2--getexpressioncontext.md) to obtain the [IDebugExpressionContext2](../VS_csharp/idebugexpressioncontext2.md) interface. This interface represents a context in which expressions can be evaluated; [IDebugExpressionContext2::ParseText](../VS_csharp/idebugexpressioncontext2--parsetext.md) is the entry point to the evaluation process. Up until this point, all interfaces are implemented by the DE.  
  
 When `IDebugExpressionContext2::ParseText` is called, the DE instantiates the EE associated with the language of the source file where the breakpoint occurred (the DE also instantiates the SH at this point). The EE is represented by the [IDebugExpressionEvaluator](../VS_csharp/idebugexpressionevaluator.md) interface. The DE then calls [IDebugExpressionEvaluator::Parse](../VS_csharp/idebugexpressionevaluator--parse.md) to convert the expression (in text form) to a parsed expression, ready for evaluation. This parsed expression is represented by the [IDebugParsedExpression](../VS_csharp/idebugparsedexpression.md) interface. Note that the expression is typically parsed and not evaluated at this point.  
  
 The DE creates an object that implements the [IDebugExpression2](../VS_csharp/idebugexpression2.md) interface, puts the `IDebugParsedExpression` object into the `IDebugExpression2` object, and returns the `IDebugExpression2` object from `IDebugExpressionContext2::ParseText`.  
  
### Evaluating the Expression  
 Visual Studio calls either [IDebugExpression2::EvaluateSync](../VS_csharp/idebugexpression2--evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../VS_csharp/idebugexpression2--evaluateasync.md) to evaluate the parsed expression. Both of these methods call [IDebugParsedExpression::EvaluateSync](../VS_csharp/idebugparsedexpression--evaluatesync.md) (`IDebugExpression2::EvaluateSync` calls the method immediately, while `IDebugExpression2::EvaluateAsync` calls the method through a background thread) to evaluate the parsed expression and return an [IDebugProperty2](../VS_csharp/idebugproperty2.md) interface that represents the value and type of the parsed expression. `IDebugParsedExpression::EvaluateSync` uses the supplied SH, address and binder to convert the parsed expression into an actual value, represented by the `IDebugProperty2` interface.  
  
### For Example  
 After a breakpoint is hit in a running program, the user chooses to view a variable in the **QuickWatch** dialog box. This dialog box shows the variable's name, its value, and its type. The user can usually change the value.  
  
 When the **QuickWatch** dialog box is shown, the name of the variable being examined is sent as text to [IDebugExpressionContext2::ParseText](../VS_csharp/idebugexpressioncontext2--parsetext.md). This returns an [IDebugExpression2](../VS_csharp/idebugexpression2.md) object representing the parsed expression, in this case, the variable. [IDebugExpression2::EvaluateSync](../VS_csharp/idebugexpression2--evaluatesync.md) is then called to produce an `IDebugProperty2` object that represents the variable's value and type, as well as its name. It is this information that is displayed.  
  
 If the user changes the variable's value, [IDebugProperty2::SetValueAsString](../VS_csharp/idebugproperty2--setvalueasstring.md) is called with the new value, which changes the value of the variable in memory so it will be used when the program resumes running.  
  
 See [Displaying Locals](../VS_csharp/displaying-locals.md) for more details on this process of displaying the values of variables. See [Changing the Value of a Local](../VS_csharp/changing-the-value-of-a-local.md) for more details on how a variable's value is changed.  
  
## In This Section  
 [Evaluation Context](../VS_csharp/evaluation-context.md)  
 Provides the arguments that are passed when the DE calls the EE.  
  
 [Key Expression Evaluator Interfaces](../VS_csharp/key-expression-evaluator-interfaces.md)  
 Describes the crucial interfaces needed when writing an EE, along with the evaluation context.  
  
## See Also  
 [Writing a Common Language Runtime Expression Evaluator](../VS_csharp/writing-a-common-language-runtime-expression-evaluator.md)   
 [Displaying Locals](../VS_csharp/displaying-locals.md)   
 [Changing the Value of a Local8407d3df-d38a-4328-82d1-98084bef43ec](../VS_csharp/changing-the-value-of-a-local.md)