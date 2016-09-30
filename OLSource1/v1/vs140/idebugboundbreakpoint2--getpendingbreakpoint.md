---
title: "IDebugBoundBreakpoint2::GetPendingBreakpoint"
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
  - "IDebugBoundBreakpoint2::GetPendingBreakpoint"
helpviewer_keywords: 
  - "IDebugBoundBreakpoint2::GetPendingBreakpoint method"
  - "GetPendingBreakpoint method"
ms.assetid: 22f94f81-f8d9-46de-96e9-fae6f3c24903
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2::GetPendingBreakpoint
Gets the pending breakpoint from which the specified bound breakpoint was created.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) object that represents the pending breakpoint that was used to create this bound breakpoint.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 A pending breakpoint can be thought of as a collection of all the necessary information needed to bind a breakpoint to code that can be applied to one or many programs.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that exposes the [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)   
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)