---
title: "IDebugBoundBreakpoint2::Delete"
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
  - "IDebugBoundBreakpoint2::Delete"
helpviewer_keywords: 
  - "Delete method"
  - "IDebugBoundBreakpoint2::Delete method"
ms.assetid: 7088dc66-f24a-446f-a52a-397d02457a41
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2::Delete
Deletes the breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state of the bound breakpoint object is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (part of the [BP_STATE](../vs140/bp_state.md) enumeration).  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that exposes the [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)   
 [BP_STATE](../vs140/bp_state.md)