---
title: "IDebugPendingBreakpoint2::SetPassCount"
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
  - "IDebugPendingBreakpoint2::SetPassCount"
helpviewer_keywords: 
  - "SetPassCount method"
  - "IDebugPendingBreakpoint2::SetPassCount method"
ms.assetid: 08ddd328-57eb-42e0-baa9-8424dcd1bf04
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::SetPassCount
Sets or changes the pass count associated with the pending breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A [BP_PASSCOUNT](../vs140/bp_passcount.md) structure that contains the pass count.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Remarks  
 Any pass count that was previously associated with the pending breakpoint is lost. All breakpoints bound from this pending breakpoint are called to set their pass count to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [BP_PASSCOUNT](../vs140/bp_passcount.md)