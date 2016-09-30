---
title: "fprintf_s, _fprintf_s_l, fwprintf_s, _fwprintf_s_l"
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
  - "_fprintf_s_l"
  - "fwprintf_s"
  - "fprintf_s"
  - "_fwprintf_s_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ftprintf_s"
  - "fprintf_s"
  - "fwprintf_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ftprintf_s_l function"
  - "ftprintf_s function"
  - "_fprintf_s_l function"
  - "_ftprintf_s function"
  - "_ftprintf_s_l function"
  - "fwprintf_s_l function"
  - "fwprintf_s function"
  - "fprintf_s_l function"
  - "fprintf_s function"
  - "_fwprintf_s_l function"
  - "print formatted data to streams"
ms.assetid: 16067c3c-69ce-472a-8272-9aadf1f5beed
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fprintf_s, _fprintf_s_l, fwprintf_s, _fwprintf_s_l
Print formatted data to a stream. These are versions of [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
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
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns the number of bytes written. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns the number of wide characters written. Each of these functions returns a negative value instead when an output error occurs.  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> formats and prints a series of characters and values to the output <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>*.* Each function <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*.* For <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument has the same syntax and use that it has in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> doesn't currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is not a user-defined string.  
  
 Like the non-secure versions (see [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)), these functions validate their parameters and invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md), if either <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer. These functions differ from the non-secure versions  in that the format string itself is also validated. If there are any unknown or badly formed formatting specifiers, these functions generate the invalid parameter exception. In all cases, If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, error codes.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
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