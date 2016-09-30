---
title: "IDebugExpressionEvaluator2::GetService"
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
  - "IDebugExpressionEvaluator2::GetService"
  - "GetService"
ms.assetid: f8988a9e-9d18-42af-84a7-55f41e9adf63
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator2::GetService
Retrieves a service object given its unique identifier.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Unique identifier of the service to retrieve.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an object that represents the service.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This can be consumed by a third-party expression evaluator to obtain services from another expression evaluator. For example, this method could be used to obtain the interface for the visualizer service from the default expression evaluator. Third-party expression evaluators are unlikely to need to implement this interface.  
  
## See Also  
 [IDebugExpressionEvaluator2](../vs140/idebugexpressionevaluator2.md)