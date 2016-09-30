---
title: "IDebugExpressionEvaluator2::SetCallback"
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
  - "IDebugExpressionEvaluator2::SetCallback"
  - "SetCallback"
ms.assetid: 31e3a99e-e784-44a3-8b19-cc5ef31ed546
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExpressionEvaluator2::SetCallback
Enables the expression evaluator (EE) to specify the callback interface that the debugger engine (DE) will use to read metric settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Interface to use for the settings callback.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method provides an interface to the session debug manager that an expression evaluator can use to read metric settings. It is useful in remote debugging to read metrics on the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] computer.  
  
## Example  
 The following examples shows how to implement this method for a **CEE** object that exposes the [IDebugSettingsCallback2](../vs140/idebugsettingscallback2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugExpressionEvaluator2](../vs140/idebugexpressionevaluator2.md)