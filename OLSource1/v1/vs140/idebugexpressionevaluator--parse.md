---
title: "IDebugExpressionEvaluator::Parse"
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
  - "IDebugExpressionEvaluator::Parse"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator::Parse method"
ms.assetid: e6e31b3a-63a7-4293-bcda-267eb78dffb6
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator::Parse
This method converts an expression string to a parsed expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The expression string to be parsed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A collection of [PARSEFLAGS](../vs140/parseflags.md) constants that determine how the expression is to be parsed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Radix to be used to interpret any numerical information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the  error as human-readable text.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] Returns the character position of the start of the error in the expression string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the parsed expression in an [IDebugParsedExpression](../vs140/idebugparsedexpression.md) object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method produces a parsed expression, not an actual value. A parsed expression is ready to be evaluated, that is, converted to a value.  
  
## See Also  
 [IDebugExpressionEvaluator](../vs140/idebugexpressionevaluator.md)   
 [IDebugParsedExpression](../vs140/idebugparsedexpression.md)   
 [PARSEFLAGS](../vs140/parseflags.md)