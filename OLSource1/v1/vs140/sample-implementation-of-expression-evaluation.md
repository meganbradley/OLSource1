---
title: "Sample Implementation of Expression Evaluation"
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
  - "expression evaluators"
  - "debugging [Debugging SDK], expression evaluators"
  - "expression evaluation, examples"
ms.assetid: 2a5f04b8-6c65-4232-bddd-9093653a22c4
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Sample Implementation of Expression Evaluation
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 For a **Watch** window expression, Visual Studio calls [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md) to produce an [IDebugExpression2](../vs140/idebugexpression2.md) object. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> instantiates an expression evaluator (EE) and calls [IDebugExpressionEvaluator::Parse](../vs140/idebugexpressionevaluator--parse.md) to obtain an [IDebugParsedExpression](../vs140/idebugparsedexpression.md) object.  
  
 This implementation of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> performs the following tasks:  
  
1.  [C++ only] Parses the expression to look for errors.  
  
2.  Instantiates a class (called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in this example) that implements the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface and stores in the class the expression to be parsed.  
  
3.  Returns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  In the examples that follow and in the MyCEE sample, the expression evaluator does not separate the parsing from the evaluation.  
  
## Managed Code  
 This is an implementation of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in managed code. Note that this version of the method defers the parsing to [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md) as the code for parsing also evaluates at the same time (see [Evaluating a Watch Expression](../vs140/evaluating-a-watch-expression.md)).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This is an implementation of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in unmanaged code. This method calls a helper function, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, to parse the expression and check for errors but this method ignores the resulting value. The formal evaluation is deferred to [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md) where the expression is parsed while it is evaluated (see [Evaluating a Watch Expression](../vs140/evaluating-a-watch-expression.md)).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Evaluating a Watch Window Expression](../vs140/evaluating-a-watch-window-expression.md)   
 [Evaluating a Watch Expression](../vs140/evaluating-a-watch-expression.md)