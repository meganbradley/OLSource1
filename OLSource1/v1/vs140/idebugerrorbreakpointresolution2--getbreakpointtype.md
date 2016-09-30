---
title: "IDebugErrorBreakpointResolution2::GetBreakpointType"
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
  - "IDebugErrorBreakpointResolution2::GetBreakpointType"
helpviewer_keywords: 
  - "IDebugErrorBreakpointResolution2::GetBreakpointType"
ms.assetid: 0bdb1152-4752-4464-ae7c-6d666dc293b7
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugErrorBreakpointResolution2::GetBreakpointType
Gets the breakpoint type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a value from the [BP_TYPE](../vs140/bp_type.md) enumeration that describes the type of breakpoint.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method returns the type of the breakpoint that failed to bind, thus requiring an error breakpoint event.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that exposes the [IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md)   
 [BP_TYPE](../vs140/bp_type.md)