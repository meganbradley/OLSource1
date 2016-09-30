---
title: "Evaluating a Watch Expression"
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
  - "expression evaluation, watch expressions"
  - "watch expressions"
ms.assetid: 8317cd52-6fea-4e8f-a739-774dc06bd44b
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Evaluating a Watch Expression
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 When Visual Studio is ready to display the value of a watch expression, it calls [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) which in turn calls [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md). This produces an [IDebugProperty2](../vs140/idebugproperty2.md) object that contains the value and type of the expression.  
  
 In this implementation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the expression is parsed and evaluated at the same time. This implementation performs the following tasks:  
  
1.  Parses and evaluates the expression to produce a generic object that holds the value and its type. In C#, this is represented as an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> while in C++ this is represented as a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
2.  Instantiates a class (called <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in this example) that implements the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface and stores in the class the value to be returned.  
  
3.  Returns the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Managed Code  
 This is an implementation of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in managed code. The helper method <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parses the expression into a parse tree. The helper function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> converts the token to a value. The helper function <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> recursively traverses the parse tree, calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> for each node representing a value and applying any operations (addition or subtraction) in the expression.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Unmanaged Code  
 This is an implementation of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in unmanaged code. The helper function <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parses and evaluates the expression, returning a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> holding the resulting value. The helper function <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> bundles the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> into a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Evaluating a Watch Window Expression](../vs140/evaluating-a-watch-window-expression.md)   
 [Sample Implementation of Expression Evaluation](../vs140/sample-implementation-of-expression-evaluation.md)