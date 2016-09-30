---
title: "BP_RESOLUTION_DATA"
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
  - "BP_RESOLUTION_DATA"
helpviewer_keywords: 
  - "BP_RESOLUTION_DATA structure"
ms.assetid: 9e0b9000-6a84-47b9-b07a-367a75764389
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_RESOLUTION_DATA
Describes the result of binding a data breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The data expression that has been bound.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the function the data breakpoint has bound in (if any).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of the module (MyModule.dll, for example) that the data breakpoint has bound in.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A value from the [BP_RES_DATA_FLAGS](../vs140/bp_res_data_flags.md) enumeration, describing how the data breakpoint is implemented.  
  
## Remarks  
 This structure is a member of the [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md) structure, which is in turn a member of the [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md) structure returned by the [GetResolutionInfo](../vs140/idebugbreakpointresolution2--getresolutioninfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md)   
 [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md)   
 [GetResolutionInfo](../vs140/idebugbreakpointresolution2--getresolutioninfo.md)