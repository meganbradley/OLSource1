---
title: "IDebugExpressionContext2::ParseText"
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
  - "IDebugExpressionContext2::ParseText"
helpviewer_keywords: 
  - "IDebugExpressionContext2::ParseText"
ms.assetid: f58575db-f926-4ac8-83ff-7b3b86ab61e2
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionContext2::ParseText
Parses an expression in text form for later evaluation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The expression to be parsed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [PARSEFLAGS](../vs140/parseflags.md) enumeration that controls parsing.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The radix to be used in parsing any numerical information in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugExpression2](../vs140/idebugexpression2.md) object that represents the parsed expression, which is ready for binding and evaluation.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns the error message if the expression contains an error.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Returns the character index of the error in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the expression contains an error.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 When this method is called, a debug engine (DE) should parse the expression and validate it for correctness. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters may be filled in if the expression is invalid.  
  
 Note that the expression is not evaluated, only parsed. A later call to the [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md) methods evaluates the parsed expression.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object that exposes the [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md) interface. This example considers the expression to be parsed as the name of an environment variable and retrieves the value from that variable.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md)   
 [PARSEFLAGS](../vs140/parseflags.md)   
 [IDebugExpression2](../vs140/idebugexpression2.md)   
 [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md)   
 [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md)