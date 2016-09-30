---
title: "IDebugExpression2::EvaluateSync"
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
  - "IDebugExpression2::EvaluateSync"
helpviewer_keywords: 
  - "IDebugExpression2::EvaluateSync"
ms.assetid: 88964915-dce3-4005-b4f3-9f37415e41e4
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpression2::EvaluateSync
This method evaluates the expression synchronously.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [EVALFLAGS](../vs140/evalflags.md) enumeration that control expression evaluation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in]This parameter is always a null value.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugProperty2](../vs140/idebugproperty2.md) object that contains the result of the expression evaluation.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise returns an error code. Some typical error codes are:  
  
|Error|Description|  
|-----------|-----------------|  
|E_EVALUATE_BUSY_WITH_EVALUATION|Another expression is currently being evaluated, and simultaneous expression evaluation is not supported.|  
|E_EVALUATE_TIMEOUT|Evaluation timed out.|  
  
## Remarks  
 For synchronous evaluation, it is not necessary to send an event back to Visual Studio upon completion of the evaluation.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object that implements the [IDebugExpression2](../vs140/idebugexpression2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugExpression2](../vs140/idebugexpression2.md)   
 [EVALFLAGS](../vs140/evalflags.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)