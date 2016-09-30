---
title: "BP_RESOLUTION_INFO"
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
  - "BP_RESOLUTION_INFO"
helpviewer_keywords: 
  - "BP_RESOLUTION_INFO structure"
ms.assetid: ba0c162a-61e8-4a0b-811f-4c1d8a5d82f0
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_RESOLUTION_INFO
Describes the bound breakpoint information for either a code breakpoint or a data breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A collection of flags from the [BPRESI_FIELDS](../vs140/bpresi_fields.md) enumerations that specifies which fields are filled out.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md) structure that specifies the location of the breakpoint in code or data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the application in which the breakpoint error occurred.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The [IDebugThread2](../vs140/idebugthread2.md) object that represents the thread in which the application that contains the breakpoint error is running.  
  
## Remarks  
 This structure is returned by [GetResolutionInfo](../vs140/idebugbreakpointresolution2--getresolutioninfo.md).  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [GetResolutionInfo](../vs140/idebugbreakpointresolution2--getresolutioninfo.md)   
 [BPRESI_FIELDS](../vs140/bpresi_fields.md)   
 [BP_RESOLUTION_LOCATION](../vs140/bp_resolution_location.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugThread2](../vs140/idebugthread2.md)