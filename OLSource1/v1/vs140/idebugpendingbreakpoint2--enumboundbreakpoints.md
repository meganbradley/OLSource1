---
title: "IDebugPendingBreakpoint2::EnumBoundBreakpoints"
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
  - "IDebugPendingBreakpoint2::EnumBoundBreakpoints"
helpviewer_keywords: 
  - "EnumBoundBreakpoints method"
  - "IDebugPendingBreakpoint2::EnumBoundBreakpoints method"
ms.assetid: 179c7c54-8446-462d-b099-e0f9cf06dc52
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::EnumBoundBreakpoints
Enumerates all breakpoints bound from this pending breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md) object that enumerates the bound breakpoints.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that exposes the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md)