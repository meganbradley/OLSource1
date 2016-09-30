---
title: "BP_REQUEST_INFO"
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
  - "BP_REQUEST_INFO"
helpviewer_keywords: 
  - "BP_REQUEST_INFO structure"
ms.assetid: 42a31412-5b6b-47fe-a762-0c2bc769e1cc
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_REQUEST_INFO
Contains the information required to implement a breakpoint.  
  
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
  
## Remarks  
 This structure is returned by the [GetRequestInfo](../vs140/idebugbreakpointrequest2--getrequestinfo.md) method.  
  
 If you need to obtain the debug engine vendor GUID, the breakpoint constraint or the tracepoint, see the [BP_REQUEST_INFO2](../vs140/bp_request_info2.md) structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [GetRequestInfo](../vs140/idebugbreakpointrequest2--getrequestinfo.md)   
 [BPREQI_FIELDS](../vs140/bpreqi_fields.md)   
 [BP_LOCATION](../vs140/bp_location.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [BP_CONDITION](../vs140/bp_condition.md)   
 [BP_PASSCOUNT](../vs140/bp_passcount.md)   
 [BP_FLAGS](../vs140/bp_flags.md)   
 [BP_REQUEST_INFO2](../vs140/bp_request_info2.md)