---
title: "BP_LOCATION"
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
  - "BP_LOCATION"
helpviewer_keywords: 
  - "BP_LOCATION union"
ms.assetid: ed1e874c-f289-4c31-8b6c-04dde03ad0f5
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_LOCATION
Specifies the type of structure used to describe the location of the breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value from the [BP_LOCATION_TYPE](../vs140/bp_location_type.md) enumeration used to interpret the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> union or the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> members.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_CODE_FILE_LINE](../vs140/bp_location_code_file_line.md) structure if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_CODE_FUNC_OFFSET](../vs140/bp_location_code_func_offset.md) structure if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_CODE_CONTEXT](../vs140/bp_location_code_context.md) structure if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_CODE_STRING](../vs140/bp_location_code_string.md) structure if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_CODE_ADDRESS](../vs140/bp_location_code_address.md) structure if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_DATA_STRING](../vs140/bp_location_data_string.md) structure if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 [C++ only] Contains the [BP_LOCATION_RESOLUTION](../vs140/bp_location_resolution.md) structure if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [C# only] See Remarks on how to interpret.  
  
## Remarks  
 This structure is a member of the [BP_REQUEST_INFO](../vs140/bp_request_info.md) and [BP_REQUEST_INFO2](../vs140/bp_request_info2.md) structures.  
  
 [C# only] The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> members are interpreted according to the following table. Look down the left column for the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value then look across the other columns to determine what each <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> member represents and marshal the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> accordingly. See the example for a way to interpret a part of this structure in C#.  
  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|----------------------|--------------------|--------------------|--------------------|--------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder> (a context)|[IDebugDocumentPosition2](../vs140/idebugdocumentposition2.md)|-|-|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> (a context)|[IDebugFunctionPosition2](../vs140/idebugfunctionposition2.md)|-|-|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|[IDebugCodeContext2](../vs140/idebugcodecontext2.md)|-|-|-|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder> (a context)|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> (conditional expression)|-|-|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> (a context)|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> (module URL)|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder> (function name)|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> (address)|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|[IDebugThread2](../vs140/idebugthread2.md)|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> (a context)|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder> (data expression)|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder> (number of elements)|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|[IDebugBreakpointResolution2](../vs140/idebugbreakpointresolution2.md)|-|-|-|  
  
## Example  
 This example shows how to interpret the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> structure in C# for the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> type. This particular type shows how to interpret all four <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> members in all possible formats (object, string, and number).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_REQUEST_INFO](../vs140/bp_request_info.md)   
 [BP_LOCATION_CODE_FILE_LINE](../vs140/bp_location_code_file_line.md)   
 [BP_LOCATION_CODE_FUNC_OFFSET](../vs140/bp_location_code_func_offset.md)   
 [BP_LOCATION_CODE_CONTEXT](../vs140/bp_location_code_context.md)   
 [BP_LOCATION_CODE_STRING](../vs140/bp_location_code_string.md)   
 [BP_LOCATION_CODE_ADDRESS](../vs140/bp_location_code_address.md)   
 [BP_LOCATION_DATA_STRING](../vs140/bp_location_data_string.md)   
 [BP_LOCATION_RESOLUTION](../vs140/bp_location_resolution.md)