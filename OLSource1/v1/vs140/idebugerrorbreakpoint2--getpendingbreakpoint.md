---
title: "IDebugErrorBreakpoint2::GetPendingBreakpoint"
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
  - "IDebugErrorBreakpoint2::GetPendingBreakpoint"
helpviewer_keywords: 
  - "IDebugErrorBreakpoint2::GetPendingBreakpoint"
ms.assetid: 59d0defc-99fd-445c-bdac-8224d5dea3f9
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugErrorBreakpoint2::GetPendingBreakpoint
Gets the pending breakpoint that caused the error.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) object that represents the pending breakpoint that failed to be bound.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md)   
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)