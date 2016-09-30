---
title: "IDebugBreakpointBoundEvent2::GetPendingBreakpoint"
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
  - "IDebugBreakpointBoundEvent2::GetPendingBreakpoint"
helpviewer_keywords: 
  - "IDebugBreakpointBoundEvent2::GetPendingBreakpoint"
ms.assetid: 6da7ed86-b412-4964-b6a3-0687a66f63fe
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointBoundEvent2::GetPendingBreakpoint
Gets the pending breakpoint that is being bound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) object that represents the pending breakpoint being bound.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CBreakpointSetDebugEventBase** object that exposes the [IDebugBreakpointBoundEvent2](../vs140/idebugbreakpointboundevent2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointBoundEvent2](../vs140/idebugbreakpointboundevent2.md)   
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)