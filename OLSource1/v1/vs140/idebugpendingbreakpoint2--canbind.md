---
title: "IDebugPendingBreakpoint2::CanBind"
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
  - "IDebugPendingBreakpoint2::CanBind"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::CanBind method"
  - "CanBind method"
ms.assetid: 84a2b189-ccf1-467e-8fab-0c0da68f0b91
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::CanBind
Determines whether this pending breakpoint can bind to a code location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugErrorBreakpoints2](../vs140/ienumdebugerrorbreakpoints2.md) object that contains a list of [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md) objects if there could be errors.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the breakpoint cannot bind, in which case the errors are returned by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter. Otherwise, returns an error code. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Remarks  
 This method is called to determine what would happen if this pending breakpoint was bound. Call the [IDebugPendingBreakpoint2::Bind](../vs140/idebugpendingbreakpoint2--bind.md) method to actually bind the pending breakpoint.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that exposes the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [IEnumDebugErrorBreakpoints2](../vs140/ienumdebugerrorbreakpoints2.md)   
 [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md)   
 [IDebugPendingBreakpoint2::Bind](../vs140/idebugpendingbreakpoint2--bind.md)