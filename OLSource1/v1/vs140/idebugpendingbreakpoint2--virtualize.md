---
title: "IDebugPendingBreakpoint2::Virtualize"
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
  - "IDebugPendingBreakpoint2::Virtualize"
helpviewer_keywords: 
  - "Virtualize method"
  - "IDebugPendingBreakpoint2::Virtualize method"
ms.assetid: 58c8e9a5-4494-47c2-bddb-56f628da6a2d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::Virtualize
Toggles the virtualized state of this pending breakpoint. When a pending breakpoint is virtualized, the debug engine will attempt to bind it every time new code loads into the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Set to nonzero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to virtualize the pending breakpoint, or to zero (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) to turn off virtualization.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Remarks  
 A virtualized breakpoint is bound every time code is loaded.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that exposes the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)