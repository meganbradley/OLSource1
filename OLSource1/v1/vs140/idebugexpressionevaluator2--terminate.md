---
title: "IDebugExpressionEvaluator2::Terminate"
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
  - "Terminate"
  - "IDebugExpressionEvaluator2::Terminate"
ms.assetid: 38265100-4d80-4902-833a-07bb569f9ba8
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator2::Terminate
Stops and cleans up the expression evaluator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Tells the expression evaluator when it is being cleaned up.  
  
## Example  
 The following example shows how to implement this method for a **ExpressionEvaluatorPackage** object that exposes the [IDebugExpressionEvaluator2](../vs140/idebugexpressionevaluator2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugExpressionEvaluator2](../vs140/idebugexpressionevaluator2.md)