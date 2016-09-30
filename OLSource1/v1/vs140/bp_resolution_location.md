---
title: "BP_RESOLUTION_LOCATION"
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
  - "BP_RESOLUTION_LOCATION"
helpviewer_keywords: 
  - "BP_RESOLUTION_LOCATION structure"
ms.assetid: 21dc5246-69c1-43e3-855c-9cd4e596c0e6
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_RESOLUTION_LOCATION
Specifies the structure of the breakpoint resolution location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value from the [BP_TYPE](../vs140/bp_type.md) enumeration that specifies how to interpret the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> union or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> members.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_RESOLUTION_CODE](../vs140/bp_resolution_code.md) structure if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_RESOLUTION_DATA](../vs140/bp_resolution_data.md) structure if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [C++ only] A placeholder.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
## Remarks  
 This structure is a member of the [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md) and [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md) structures.  
  
 [C# only] The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> members are interpreted according to the following table. Look down the left column for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value then across to determine what each <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member represents and marshal the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> accordingly. See the Example for a way to interpret this structure in C#.  
  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|----------------------|--------------------|--------------------|--------------------|--------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|[IDebugCodeContext2](../vs140/idebugcodecontext2.md)|-|-|-|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (data expression)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> (function name)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (image name)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Example  
 This example shows how to interpret the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> structure in C#.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_TYPE](../vs140/bp_type.md)   
 [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md)   
 [BP_RESOLUTION_INFO](../vs140/bp_resolution_info.md)   
 [BP_RESOLUTION_CODE](../vs140/bp_resolution_code.md)   
 [BP_RESOLUTION_DATA](../vs140/bp_resolution_data.md)   
 [BP_RES_DATA_FLAGS](../vs140/bp_res_data_flags.md)