---
title: "IDebugPendingBreakpoint2::Enable"
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
  - "IDebugPendingBreakpoint2::Enable"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::Enable method"
  - "Enable method"
ms.assetid: 09e32d05-464b-40a6-a41d-76f2759cf2cd
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::Enable
Toggles the enabled state of the pending breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Set to nonzero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to enable a pending breakpoint, or to zero (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) to disable.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Remarks  
 When a pending breakpoint is enabled or disabled, all breakpoints bound from it are set to the same state.  
  
 This method may be called as many times as necessary, even if the breakpoint is already enabled or disabled.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that exposes the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)