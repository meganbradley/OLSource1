---
title: "IDebugBreakpointUnboundEvent2::GetReason"
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
  - "IDebugBreakpointUnboundEvent2::GetReason"
helpviewer_keywords: 
  - "IDebugBreakpointUnboundEvent2::GetReason"
ms.assetid: 0f8a4fec-d3eb-417d-8516-4f7b51904033
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointUnboundEvent2::GetReason
Gets the reason the breakpoint was unbound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a value from the [BP_UNBOUND_REASON](../vs140/bp_unbound_reason.md) enumeration specifying the reason the breakpoint was unbound.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Reasons include a breakpoint being rebound to a different location after an edit-and-continue operation, or a determination that a breakpoint was bound in error.  
  
## Example  
 The following example shows how to implement this method for a **CBreakpointUnboundDebugEventBase** object that exposes the [IDebugBreakpointUnboundEvent2](../vs140/idebugbreakpointunboundevent2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointUnboundEvent2](../vs140/idebugbreakpointunboundevent2.md)