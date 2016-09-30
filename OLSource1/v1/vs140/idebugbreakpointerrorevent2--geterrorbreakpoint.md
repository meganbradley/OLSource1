---
title: "IDebugBreakpointErrorEvent2::GetErrorBreakpoint"
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
  - "IDebugBreakpointErrorEvent2::GetErrorBreakpoint"
helpviewer_keywords: 
  - "IDebugBreakpointErrorEvent2::GetErrorBreakpoint"
ms.assetid: e5acfd19-ac17-47f3-a31a-b2aa8baca36d
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointErrorEvent2::GetErrorBreakpoint
Gets an [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md) object that describes the reason why a breakpoint was not bound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md) object that describes the warning or error.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface is obtained, call the [IDebugErrorBreakpoint2::GetBreakpointResolution](../vs140/idebugerrorbreakpoint2--getbreakpointresolution.md) method to get an [IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md) object. Then the [IDebugErrorBreakpointResolution2::GetResolutionInfo](../vs140/idebugerrorbreakpointresolution2--getresolutioninfo.md) method can be used to determine an invalid location, an invalid expression, or reasons why the pending breakpoint was not bound, such as code not loaded yet, and so on.  
  
## Example  
 The following example shows how to implement this method for a **CBreakpointSetDebugEventBase** object that exposes the [IDebugBreakpointErrorEvent2](../vs140/idebugbreakpointerrorevent2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointErrorEvent2](../vs140/idebugbreakpointerrorevent2.md)   
 [IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md)   
 [IDebugErrorBreakpoint2](../vs140/idebugerrorbreakpoint2.md)