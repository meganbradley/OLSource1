---
title: "BP_LOCATION_RESOLUTION"
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
  - "BP_LOCATION_RESOLUTION"
helpviewer_keywords: 
  - "BP_LOCATION_RESOLUTION structure"
ms.assetid: 86ea2c8a-54a3-48e8-83c7-18a515273129
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_LOCATION_RESOLUTION
Describes the resolution of a breakpoint at a specific location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 pResolution  
 The [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md) object that determines the type of the breakpoint and its resolution information.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../vs140/bp_location.md) structure as part of a union.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_LOCATION](../vs140/bp_location.md)   
 [IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md)