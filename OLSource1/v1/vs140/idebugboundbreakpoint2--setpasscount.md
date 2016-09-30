---
title: "IDebugBoundBreakpoint2::SetPassCount"
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
  - "IDebugBoundBreakpoint2::SetPassCount"
helpviewer_keywords: 
  - "SetPassCount method"
  - "IDebugBoundBreakpoint2::SetPassCount method"
ms.assetid: b32c12f9-b34d-43bd-a1b9-61af6cf8e51b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2::SetPassCount
Sets or changes the pass count associated with this bound breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The [BP_PASSCOUNT](../vs140/bp_passcount.md) structure that specifies the pass count.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state of the bound breakpoint object is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (part of the [BP_STATE](../vs140/bp_state.md) enumeration).  
  
## Remarks  
 The pass count determines when the breakpoint is fired. The current pass or hit count can be obtained by calling the [IDebugBoundBreakpoint2::GetHitCount](../vs140/idebugboundbreakpoint2--gethitcount.md) method.  
  
 Any pass count that was previously associated with this breakpoint is lost.  
  
## See Also  
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)   
 [IDebugBoundBreakpoint2::GetHitCount](../vs140/idebugboundbreakpoint2--gethitcount.md)   
 [BP_PASSCOUNT](../vs140/bp_passcount.md)   
 [BP_STATE](../vs140/bp_state.md)