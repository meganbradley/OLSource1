---
title: "IDebugBoundBreakpoint2::GetBreakpointResolution"
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
  - "IDebugBoundBreakpoint2::GetBreakpointResolution"
helpviewer_keywords: 
  - "GetBreakpointResolution method"
  - "IDebugBoundBreakpoint2::GetBreakpointResolution method"
ms.assetid: 4479ac61-18a9-4a30-b213-9921c5af9a26
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2::GetBreakpointResolution
Gets the breakpoint resolution that describes this breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md) interface that represents one of the following:  
  
-   The breakpoint resolution object that describes the location in code where a code breakpoint has been bound.  
  
-   The data location where a data breakpoint has bound.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the state of the bound breakpoint object is set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (part of the [BP_STATE](../vs140/bp_state.md) enumeration).  
  
## Remarks  
 Call the [IDebugBreakpointResolution2::GetBreakpointType](../vs140/idebugbreakpointresolution2--getbreakpointtype.md) method to determine if the breakpoint resolution is for code or data.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that exposes the [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)   
 [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md)   
 [IDebugBreakpointResolution2::GetBreakpointType](../vs140/idebugbreakpointresolution2--getbreakpointtype.md)