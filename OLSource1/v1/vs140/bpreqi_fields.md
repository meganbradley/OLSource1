---
title: "BPREQI_FIELDS"
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
  - "BPREQI_FIELDS"
helpviewer_keywords: 
  - "BPREQI_FIELDS enumeration"
ms.assetid: 679e771e-4a79-484e-af37-f962ef4aa245
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BPREQI_FIELDS
Specifies the information to be retrieved about a breakpoint request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 BPREQI_BPLOCATION  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (breakpoint location) field of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) or [BP_REQUEST_INFO2](../vs140/bp_request_info2.md) structure.  
  
 BPREQI_LANGUAGE  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
 BPREQI_PROGRAM  
 Initialize/use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 BPREQI_PROGRAMNAME  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure.  
  
 BPREQI_THREAD  
 Initialize/use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure.  
  
 BPREQI_THREADNAME  
 Initialize/use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure.  
  
 BPREQI_PASSCOUNT  
 Initialize/use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> structure.  
  
 BPREQI_CONDITION  
 Initialize/use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (breakpoint condition) field of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure.  
  
 BPREQI_FLAGS  
 Initialize/use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> structure.  
  
 BPREQI_ALLOLDFIELDS  
 Initialize/use all fields for the of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> structure.  
  
 BPREQI_VENDOR  
 Initialize/use the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> structure.  
  
 BPREQI_CONSTRAINT  
 Initialize/use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure.  
  
 BPREQI_TRACEPOINT  
 Initialize/use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> structure.  
  
 BPREQI_ALLFIELDS  
 Specifies all fields for the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 Passed as an argument to the [GetRequestInfo](../vs140/idebugbreakpointrequest2--getrequestinfo.md) and [BP_REQUEST_INFO](../vs140/bp_request_info.md) methods to specify which fields of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) and [BP_REQUEST_INFO2](../vs140/bp_request_info2.md) structures are to be initialized.  
  
 These flags are also used to indicate which fields of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structures are used and valid when each structure is returned.  
  
 These values may be combined with a bitwise <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetRequestInfo](../vs140/idebugbreakpointrequest2--getrequestinfo.md)   
 [BP_REQUEST_INFO](../vs140/bp_request_info.md)   
 [BP_REQUEST_INFO2](../vs140/bp_request_info2.md)