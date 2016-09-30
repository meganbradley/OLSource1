---
title: "BP_ERROR_RESOLUTION_INFO"
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
  - "BP_ERROR_RESOLUTION_INFO"
helpviewer_keywords: 
  - "BP_ERROR_RESOLUTION_INFO structure"
ms.assetid: a6b83242-5728-4716-80f3-840c96d59c6c
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_ERROR_RESOLUTION_INFO
Describes the resolution of an error breakpoint, including location, program, and thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A combination of values from the [BPERESI_FIELDS](../vs140/bperesi_fields.md) enumeration specifying which fields of this structure are filled out.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md) union, which specifies the breakpoint resolution location.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the application in which the breakpoint error occurred.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The [IDebugThread2](../vs140/idebugthread2.md) object that represents the thread on which the application that generated the breakpoint error is running.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A string containing any warning or error message resulting from this error resolution.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A value from the [BP_ERROR_TYPE](../vs140/bp_error_type.md) enumeration that specifies the breakpoint error type.  
  
## Remarks  
 This structure is returned from the [GetResolutionInfo](../vs140/idebugerrorbreakpointresolution2--getresolutioninfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [GetResolutionInfo](../vs140/idebugerrorbreakpointresolution2--getresolutioninfo.md)   
 [BPRESI_FIELDS](../vs140/bpresi_fields.md)   
 [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [BP_ERROR_TYPE](../vs140/bp_error_type.md)