---
title: "_fpieee_flt"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_fpieee_flt"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fpieee_flt"
  - "_fpieee_flt"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fpieee_flt function"
  - "exception handling, floating-point"
  - "floating-point exception handling"
  - "fpieee_flt function"
ms.assetid: 2bc4801e-0eed-4e73-b518-215da8cc9740
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fpieee_flt
Invokes a user-defined trap handler for IEEE floating-point exceptions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Exception code.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the Windows NT exception information structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the user's IEEE trap-handler routine.  
  
## Return Value  
 The return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the value returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. As such, the IEEE filter routine might be used in the except clause of a structured exception-handling (SEH) mechanism.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function invokes a user-defined trap handler for IEEE floating-point exceptions and provides it with all relevant information. This routine serves as an exception filter in the SEH mechanism, which invokes your own IEEE exception handler when necessary.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure, defined in Fpieee.h, contains information pertaining to an IEEE floating-point exception. This structure is passed to the user-defined trap handler by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
|_FPIEEE_RECORD field|Description|  
|----------------------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|These fields contain information about the floating-point environment at the time the exception occurred.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Indicates the type of operation that caused the trap. If the type is a comparison (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>), you can supply one of the special <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> values (as defined in Fpieee.h) in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field. The conversion type (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) indicates that the trap occurred during a floating-point conversion operation. You can look at the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> types to determine the type of conversion being attempted.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|These structures indicate the types and values of the proposed result and operands:\<br />\<br /> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> Flag indicating whether the responding value is valid.\<br />\<br /> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> Data type of the corresponding value. The format type might be returned even if the corresponding value is not valid.\<br />\<br /> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> Result or operand data value.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|_FPIEEE_EXCEPTION_FLAGS contains one bit field per type of floating point exception.\<br />\<br /> There is a correspondence between these fields and the arguments used to mask the exceptions supplied to [_controlfp](../vs140/_control87--_controlfp--__control87_2.md).\<br />\<br /> The exact meaning of each bit depends on context:\<br />\<br /> <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> Each set bit indicates the particular exception that was raised.\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> Each set bit indicates that the particular exception is currently unmasked.\<br />\<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> Each set bit indicates that the particular exception is currently pending. This includes exceptions that have not been raised because they were masked by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.|  
  
 Pending exceptions that are disabled are raised when you enable them. This can result in undefined behavior when using <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> as an exception filter. Always call [_clearfp](../vs140/_clear87--_clearfp.md) before enabling floating point exceptions.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<fpieee.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_control87, _controlfp, \__control87_2](../vs140/_control87--_controlfp--__control87_2.md)   
 [_controlfp_s](../vs140/_controlfp_s.md)