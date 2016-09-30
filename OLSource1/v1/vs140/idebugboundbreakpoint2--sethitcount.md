---
title: "IDebugBoundBreakpoint2::SetHitCount"
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
  - "IDebugBoundBreakpoint2::SetHitCount"
helpviewer_keywords: 
  - "SetHitCount method"
  - "IDebugBoundBreakpoint2::SetHitCount method"
ms.assetid: 8145d875-26b1-4049-a2a2-e7d3d7f4735f
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2::SetHitCount
Sets the hit count for the bound breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The hit count to set.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state of the bound breakpoint object is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (part of the [BP_STATE](../vs140/bp_state.md) enumeration).  
  
## Remarks  
 The hit count is the number of times this breakpoint has fired during the current run of the session.  
  
 This method is typically called by the debug engine to update the current hit count on this breakpoint.  
  
## See Also  
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)   
 [BP_STATE](../vs140/bp_state.md)