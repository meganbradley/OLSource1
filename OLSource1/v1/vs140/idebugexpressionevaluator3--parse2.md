---
title: "IDebugExpressionEvaluator3::Parse2"
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
  - "IDebugExpressionEvaluator3::Parse2"
ms.assetid: 78099628-d600-4f76-b7c8-ee07c864af1e
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator3::Parse2
Converts an expression string to a parsed expression given the symbol provider and the address of the evaluating frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The expression string to be parsed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A collection of [PARSEFLAGS](../vs140/parseflags.md) constants that determine how the expression is to be parsed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Radix to be used to interpret any numerical information.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Interface of the symbol provider.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Address of the evaluating frame.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns the error as human-readable text.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [out] Returns the character position of the start of the error in the expression string.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] Returns the parsed expression in an [IDebugParsedExpression](../vs140/idebugparsedexpression.md) object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method produces a parsed expression, not an actual value. A parsed expression is ready to be evaluated, that is, converted to a value.  
  
## Example  
 The following example shows how to implement this method for a **CEE** object that exposes the [IDebugExpressionEvaluator3](../vs140/idebugexpressionevaluator3.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugExpressionEvaluator3](../vs140/idebugexpressionevaluator3.md)