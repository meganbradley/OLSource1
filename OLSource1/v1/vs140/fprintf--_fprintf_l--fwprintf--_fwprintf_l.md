---
title: "fprintf, _fprintf_l, fwprintf, _fwprintf_l"
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
  - "fwprintf"
  - "fprintf"
  - "_fprintf_l"
  - "_fwprintf_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "fprintf"
  - "fwprintf"
  - "_ftprintf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fwprintf_l function"
  - "fprintf function"
  - "fprintf_l function"
  - "_fprintf_l function"
  - "_ftprintf function"
  - "fwprintf function"
  - "ftprintf_l function"
  - "ftprintf function"
  - "_ftprintf_l function"
  - "print formatted data to streams"
  - "fwprintf_l function"
ms.assetid: 34a87e1c-6e4d-4d48-a611-58314dd4dc4b
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fprintf, _fprintf_l, fwprintf, _fwprintf_l
Print formatted data to a stream. More secure versions of these functions are available; see [fprintf_s, _fprintf_s_l, fwprintf_s, _fwprintf_s_l](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns the number of bytes written. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns the number of wide characters written. Each of these functions returns a negative value instead when an output error occurs. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The format string is not checked for valid formatting characters as it is when using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
## Remarks  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> formats and prints a series of characters and values to the output <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>*.* Each function <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>*.* For <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument has the same syntax and use that it has in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> does not currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not a user-defined string.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
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
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)