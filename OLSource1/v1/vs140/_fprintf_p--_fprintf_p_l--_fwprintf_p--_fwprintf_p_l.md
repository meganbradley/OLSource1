---
title: "_fprintf_p, _fprintf_p_l, _fwprintf_p, _fwprintf_p_l"
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
  - "_fwprintf_p"
  - "_fprintf_p_l"
  - "_fwprintf_p_l"
  - "_fprintf_p"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fprintf_p"
  - "_ftprintf_p"
  - "fwprintf_p"
  - "_fwprintf_p"
  - "fprintf_p"
  - "ftprintf_p"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fprintf_p_l function"
  - "fprintf_p function"
  - "_fprintf_p_l function"
  - "_fprintf_p function"
  - "_ftprintf_p_l function"
  - "streams, printing formatted data to"
  - "_fwprintf_p function"
  - "fwprintf_p function"
  - "_ftprintf_p function"
  - "_fwprintf_p_l function"
  - "ftprintf_p function"
  - "printing [C++], formatted data to streams"
  - "ftprintf_p_l function"
  - "fwprintf_p_l function"
ms.assetid: 46b082e1-45ba-4383-9ee4-97015aa50bc6
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fprintf_p, _fprintf_p_l, _fwprintf_p, _fwprintf_p_l
Prints formatted data to a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> return the number of characters written or return a negative value when an output error occurs.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> formats and prints a series of characters and values to the output <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Each function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. For <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument has the same syntax and use that it has in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. These functions support positional parameters, meaning that the order of the parameters used by the format string can be changed. For more information about positional parameters, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> doesn't currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is not a user-defined string.  
  
 Like the non-secure versions (see [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)), these functions validate their parameters and invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md), if either <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer or if there are any unknown or badly formed formatting specifiers. If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **this is a string**  
**10**  
**1.500000**   
## .NET Framework Equivalent  
 [System::IO::StreamWriter::Write](https://msdn.microsoft.com/en-us/library/system.io.streamwriter.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_cprintf, _cwprintf](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [fscanf, fwscanf](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)   
 [_cprintf_p, _cwprintf_p](../vs140/_cprintf_p--_cprintf_p_l--_cwprintf_p--_cwprintf_p_l.md)   
 [_cprintf_s, _cwprintf_s](../vs140/_cprintf_s--_cprintf_s_l--_cwprintf_s--_cwprintf_s_l.md)   
 [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)   
 [fscanf_s, fwscanf_s](../vs140/fscanf_s--_fscanf_s_l--fwscanf_s--_fwscanf_s_l.md)