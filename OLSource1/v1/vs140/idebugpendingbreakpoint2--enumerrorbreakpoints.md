---
title: "IDebugPendingBreakpoint2::EnumErrorBreakpoints"
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
  - "IDebugPendingBreakpoint2::EnumErrorBreakpoints"
helpviewer_keywords: 
  - "IDebugPendingBreakpoint2::EnumErrorBreakpoints method"
  - "EnumErrorBreakpoints method"
ms.assetid: 2f9a9720-c1ac-4430-8f28-200d85360452
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPendingBreakpoint2::EnumErrorBreakpoints
Gets a list of all error breakpoints that resulted from this pending breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of values from the [BP_ERROR_TYPE](../vs140/bp_error_type.md) enumeration that selects the type of errors to enumerate.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugErrorBreakpoints2](../vs140/ienumdebugerrorbreakpoints2.md) object that contains a list of [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md) objects.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the breakpoint has been deleted.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that exposes the [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [BP_ERROR_TYPE](../vs140/bp_error_type.md)   
 [IEnumDebugErrorBreakpoints2](../vs140/ienumdebugerrorbreakpoints2.md)   
 [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md)