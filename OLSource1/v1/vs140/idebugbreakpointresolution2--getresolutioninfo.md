---
title: "IDebugBreakpointResolution2::GetResolutionInfo"
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
  - "IDebugBreakpointResolution2::GetResolutionInfo"
helpviewer_keywords: 
  - "IDebugBreakpointResolution2::GetResolutionInfo"
ms.assetid: 828cbdf6-b87d-4c45-be87-d87087b04a60
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointResolution2::GetResolutionInfo
Gets the breakpoint resolution information that describes this breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [BPRESI_FIELDS](../vs140/bpresi_fields.md) enumeration that determine which fields of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter are to be filled out.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] The [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md) structure to be filled in with information about this breakpoint.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise returns an error code.  
  
## Example  
 The following example implements this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that exposes the [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md)   
 [BPRESI_FIELDS](../vs140/bpresi_fields.md)   
 [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md)