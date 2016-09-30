---
title: "IDebugExpression2::EvaluateAsync"
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
  - "IDebugExpression2::EvaluateAsync"
helpviewer_keywords: 
  - "IDebugExpression2::EvaluateAsync"
ms.assetid: 848fe6cb-0759-42f2-890b-d2b551c527d6
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpression2::EvaluateAsync
This method evaluates the expression asynchronously.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [EVALFLAGS](../vs140/evalflags.md) enumeration that control expression evaluation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] This parameter is always a null value.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise returns an error code. A typical error code is:  
  
|Error|Description|  
|-----------|-----------------|  
|E_EVALUATE_BUSY_WITH_EVALUATION|Another expression is currently being evaluated, and simultaneous expression evaluation is not supported.|  
  
## Remarks  
 This method should return immediately after it has started the expression evaluation. When the expression is successfully evaluated, an [IDebugExpressionEvaluationCompleteEvent2](../vs140/idebugexpressionevaluationcompleteevent2.md) must be sent to the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) event callback as supplied through [IDebugProgram2::Attach](../vs140/idebugprogram2--attach.md) or [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md).  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that implements the [IDebugExpression2](../vs140/idebugexpression2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugExpression2](../vs140/idebugexpression2.md)   
 [IDebugExpressionEvaluationCompleteEvent2](../vs140/idebugexpressionevaluationcompleteevent2.md)   
 [EVALFLAGS](../vs140/evalflags.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)