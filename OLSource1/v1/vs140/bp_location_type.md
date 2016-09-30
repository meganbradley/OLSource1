---
title: "BP_LOCATION_TYPE"
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
  - "BP_LOCATION_TYPE"
helpviewer_keywords: 
  - "BP_LOCATION_TYPE structure"
ms.assetid: 0248430a-3b61-4809-87a9-e9b6bb7d1130
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_LOCATION_TYPE
Specifies the location type of the breakpoint for a breakpoint request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 BPLT_NONE  
 Specifies no breakpoint location.  
  
 BPLT_FILE_LINE  
 Specifies the location type of the breakpoint as a file line.  
  
 BPLT_FUNC_OFFSET  
 Specifies the location type of the breakpoint as a function offset.  
  
 BPLT_CONTEXT  
 Specifies the location type of the breakpoint as a context.  
  
 BPLT_STRING  
 Specifies the location type of the breakpoint as a string.  
  
 BPLT_ADDRESS  
 Specifies the location type of the breakpoint as an address.  
  
 BPLT_RESOLUTION  
 Specifies the location type of the breakpoint as a resolution.  
  
 BPLT_CODE_FILE_LINE  
 Specifies the location type of the breakpoint as a line of source code.  
  
 BPLT_CODE_FUNC_OFFSET  
 Specifies the location type of the breakpoint as a code function offset.  
  
 BPLT_CODE_CONTEXT  
 Specifies the location type of the breakpoint as a code context.  
  
 BPLT_CODE_STRING  
 Specifies the location type of the breakpoint as a code string.  
  
 BPLT_CODE_ADDRESS  
 Specifies the location type of the breakpoint as a code address.  
  
 BPLT_DATA_STRING  
 Specifies the location type of the breakpoint as a data string.  
  
 BPLT_TYPE_MASK  
 Specifies a bit mask, so that the breakpoint type can be extracted out of the value.  
  
 BPLT_LOCATION_TYPE_MASK  
 Specifies a bit mask, so that the breakpoint location type can be extracted out of the value.  
  
## Remarks  
 Passed as a parameter to the [GetLocationType](../vs140/idebugbreakpointrequest2--getlocationtype.md) method.  
  
 A breakpoint location type is composed of a breakpoint type and a location type. This means that a breakpoint location type is never just a breakpoint type (for example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) or a location type (for example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). Predefined constants for all breakpoint location types currently supported are included in this enumeration (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are members of the [BP_TYPE](../vs140/bp_type.md) enumeration.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetLocationType](../vs140/idebugbreakpointrequest2--getlocationtype.md)   
 [BP_TYPE](../vs140/bp_type.md)