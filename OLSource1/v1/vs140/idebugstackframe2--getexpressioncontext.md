---
title: "IDebugStackFrame2::GetExpressionContext"
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
  - "IDebugStackFrame2::GetExpressionContext"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetExpressionContext"
ms.assetid: a2604e6a-502d-473b-868f-b11ac64c7a35
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame2::GetExpressionContext
Gets an evaluation context for expression evaluation within the current context of a stack frame and thread.  
  
## Syntax  
  
```cpp#  
HRESULT GetExpressionContext (   
   IDebugExpressionContext2** ppExprCxt  
);  
```  
  
```c#  
int GetExpressionContext (   
   out IDebugExpressionContext2 ppExprCxt  
);  
```  
  
#### Parameters  
 `ppExprCxt`  
 [out] Returns an [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md) object that represents a context for expression evaluation.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Generally, an expression evaluation context can be thought of as a scope for performing expression evaluation. Call the [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md) method to parse an expression and then call the resulting [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) or [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md) methods to evaluate the parsed expression.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)   
 [IDebugExpressionContext2](../vs140/idebugexpressioncontext2.md)   
 [IDebugExpressionContext2::ParseText](../vs140/idebugexpressioncontext2--parsetext.md)   
 [IDebugExpression2::EvaluateSync](../vs140/idebugexpression2--evaluatesync.md)   
 [IDebugExpression2::EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md)