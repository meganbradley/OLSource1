---
title: "IDebugErrorBreakpointResolution2::GetResolutionInfo"
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
  - "IDebugErrorBreakpointResolution2::GetResolutionInfo"
helpviewer_keywords: 
  - "IDebugErrorBreakpointResolution2::GetResolutionInfo"
ms.assetid: d94c4f60-8796-4848-86ee-186bbaa613f5
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugErrorBreakpointResolution2::GetResolutionInfo
Gets the breakpoint error resolution information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [BPERESI_FIELDS](../vs140/bperesi_fields.md) enumeration that determine which fields of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are to be filled out.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] The [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md) structure that is filled in with the description of the breakpoint resolution.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example implements this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that exposes the [IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugErrorBreakpointResolution2](../vs140/idebugerrorbreakpointresolution2.md)   
 [BPERESI_FIELDS](../vs140/bperesi_fields.md)   
 [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md)