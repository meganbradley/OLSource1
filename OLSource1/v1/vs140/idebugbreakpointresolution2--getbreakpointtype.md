---
title: "IDebugBreakpointResolution2::GetBreakpointType"
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
  - "IDebugBreakpointResolution2::GetBreakpointType"
helpviewer_keywords: 
  - "IDebugBreakpointResolution2::GetBreakpointType"
ms.assetid: 2b707fb9-f703-4c78-91bf-7434f57790a0
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointResolution2::GetBreakpointType
Gets the type of the breakpoint represented by this resolution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a value from the [BP_TYPE](../vs140/bp_type.md) enumeration that specifies the type of this breakpoint.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise returns an error code. Returns E_FAIL if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field in the associated [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md) structure is not valid.  
  
## Remarks  
 The breakpoint may be a code or a data breakpoint, for example.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that exposes the [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md)   
 [BP_TYPE](../vs140/bp_type.md)   
 [BPRESI_FIELDS](../vs140/bpresi_fields.md)   
 [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md)   
 [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md)