---
title: "BP_REQUEST_INFO2"
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
  - "BP_REQUEST_INFO2"
helpviewer_keywords: 
  - "BP_REQUEST_INFO2 structure"
ms.assetid: 008c87f7-a76e-43d3-8904-11b225d6a9a5
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_REQUEST_INFO2
Contains the information required to implement a breakpoint, including vendor GUID, constraint and tracepoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A combination of flags from the [BPREQI_FIELDS](../vs140/bpreqi_fields.md) enumeration that specifies which fields are filled out.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The language GUID.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The [BP_LOCATION](../vs140/bp_location.md) structure that specifies the type of the breakpoint location.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the application in which the breakpoint occurs.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The name of the application in which the breakpoint occurs.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The [IDebugThread2](../vs140/idebugthread2.md) object that represents the thread in which the breakpoint occurs.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The name of the thread in which the breakpoint occurs.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The [BP_CONDITION](../vs140/bp_condition.md) structure that describes the conditions under which the breakpoint will fire.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The [BP_PASSCOUNT](../vs140/bp_passcount.md) structure that contains the pass count information of the breakpoint.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A combination of flags from the [BP_FLAGS](../vs140/bp_flags.md) enumeration that specifies the flags for the requested breakpoint.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 GUID of vendor. May be a null value.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Name of breakpoint constraint. May be a null value.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Name of trace point. May be a null value.  
  
## Remarks  
 This structure is returned by the [IDebugBreakpointRequest3::GetRequestInfo2](../vs140/idebugbreakpointrequest3--getrequestinfo2.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugBreakpointRequest3::GetRequestInfo2](../vs140/idebugbreakpointrequest3--getrequestinfo2.md)   
 [BPREQI_FIELDS](../vs140/bpreqi_fields.md)   
 [BP_LOCATION](../vs140/bp_location.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [BP_CONDITION](../vs140/bp_condition.md)   
 [BP_PASSCOUNT](../vs140/bp_passcount.md)   
 [BP_FLAGS](../vs140/bp_flags.md)