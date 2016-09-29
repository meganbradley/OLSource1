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
  
```cpp#  
HRESULT GetExpression(   
   IDebugExpression2** ppExpr  
);  
```  
  
```c#  
int GetExpression(   
   out IDebugExpression2 ppExpr  
);  
```  
  
#### Parameters  
 `ppExpr`  
 [out] Returns an [IDebugExpression2](../VS_csharp/idebugexpression2.md) object that represents the expression that was parsed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method returns the object that was created in a call to the [IDebugExpressionContext2::ParseText](../VS_csharp/idebugexpressioncontext2--parsetext.md) method.  
  
## See Also  
 [IDebugExpressionEvaluationCompleteEvent2](../VS_csharp/idebugexpressionevaluationcompleteevent2.md)   
 [IDebugExpression2](../VS_csharp/idebugexpression2.md)   
 [IDebugExpressionContext2::ParseText](../VS_csharp/idebugexpressioncontext2--parsetext.md)