---
title: "IDebugExpressionEvaluationCompleteEvent2::GetExpression"
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
  - "IDebugExpressionEvaluationCompleteEvent2::GetExpression"
helpviewer_keywords: 
  - "IDebugExpressionEvaluationCompleteEvent2::GetExpression"
ms.assetid: faf6b2dd-2afd-4852-b21c-7e8d3130e141
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluationCompleteEvent2::GetExpression
Gets the original expression.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugExpression2](../vs140/idebugexpression2.md) object that represents the expression that was parsed.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method returns the object that was created in a call to the [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md) method.  
  
## See Also  
 [IDebugExpressionEvaluationCompleteEvent2](../vs140/idebugexpressionevaluationcompleteevent2.md)   
 [IDebugExpression2](../vs140/idebugexpression2.md)   
 [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md)