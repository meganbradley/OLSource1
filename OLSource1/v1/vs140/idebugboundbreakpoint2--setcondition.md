---
title: "IDebugBoundBreakpoint2::SetCondition"
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
  - "IDebugBoundBreakpoint2::SetCondition"
helpviewer_keywords: 
  - "SetCondition method"
  - "IDebugBoundBreakpoint2::SetCondition method"
ms.assetid: 5d366876-efed-43d0-8ea1-dfdb009cbfac
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2::SetCondition
Sets or changes the condition associated with this bound breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [BP_CONDITION](../vs140/bp_condition.md) enumeration that describes the condition.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the state of the bound breakpoint object is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (part of the [BP_STATE](../vs140/bp_state.md) enumeration).  
  
## Remarks  
 Any condition that was previously associated with this breakpoint is lost.  
  
## See Also  
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)   
 [BP_CONDITION](../vs140/bp_condition.md)   
 [BP_STATE](../vs140/bp_state.md)