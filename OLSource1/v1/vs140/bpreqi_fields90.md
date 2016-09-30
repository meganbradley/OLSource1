---
title: "BPREQI_FIELDS90"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "BPREQI_FIELDS90 enumeration"
ms.assetid: bf6f7efc-39f2-46a2-906d-c3647bf89995
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BPREQI_FIELDS90
Enumerates the valid values that specify the information to be retrieved about a breakpoint request. This enumeration extends the [BPREQI_FIELDS](../vs140/bpreqi_fields.md) enumeration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 BPREQI90_BPLOCATION  
 Initialize or use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (breakpoint location) field of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) or [BP_REQUEST_INFO2](../vs140/bp_request_info2.md) structure.  
  
 BPREQI90_LANGUAGE  
 Initialize or use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_PROGRAM  
 Initialize or use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_PROGRAMNAME  
 Initialize or use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_THREAD  
 Initialize or use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_THREADNAME  
 Initialize or use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_PASSCOUNT  
 Initialize or use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_CONDITION  
 Initialize or use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (breakpoint condition) field of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_FLAGS  
 Initialize or use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_ALLOLDFIELDS  
 Initialize or use all fields for the of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_VENDOR  
 Initialize or use the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_CONSTRAINT  
 Initialize or use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_TRACEPOINT  
 Initialize or use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> structure.  
  
 BPREQI90_MACROTRACEPOINT  
 Initialize or use the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> field of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> structure. BPREQI_ALLFIELDS does not include this field.  
  
 BPREQI90_ALLFIELDS  
 Specifies all fields for the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structure.  
  
## Requirements  
 Header: Msdbg90.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)