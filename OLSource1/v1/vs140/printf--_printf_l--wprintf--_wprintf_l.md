---
title: "printf, _printf_l, wprintf, _wprintf_l"
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
  - "_printf_l"
  - "wprintf"
  - "_wprintf_l"
  - "printf"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "printf"
  - "_tprintf"
  - "wprintf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "printf function"
  - "printf_l function"
  - "tprintf_l function"
  - "tprintf function"
  - "_printf_l function"
  - "wprintf function"
  - "writing to console"
  - "wprintf_l function"
  - "_tprintf_l function"
  - "_wprintf_l function"
  - "_tprintf function"
  - "printf function, format specification fields"
  - "printf function, using"
  - "formatted text [C++]"
ms.assetid: 77a854ae-5b48-4865-89f4-f2dc5cf80f52
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# printf, _printf_l, wprintf, _wprintf_l
Prints formatted output to the standard output stream. More secure versions of these functions are available; see [printf_s, _printf_s_l, wprintf_s, _wprintf_s_l](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Format control.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns the number of characters printed, or a negative value if an error occurs. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If **EOF** (0xFFFF) is encountered in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the function returns -1.  
  
 For information on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function formats and prints a series of characters and values to the standard output stream, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If arguments follow the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> string, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> string must contain specifications that determine the output format for the arguments. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and [fprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md) behave identically except that <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> writes output to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> rather than to a destination of type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> does not currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_unicode defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> argument consists of ordinary characters, escape sequences, and (if arguments follow <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>) format specifications. The ordinary characters and escape sequences are copied to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> in order of their appearance. For example, the line:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 produces the output:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [Format specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md) always begin with a percent sign (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>) and are read left to right. When <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> encounters the first format specification (if any), it converts the value of the first argument after <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and outputs it accordingly. The second format specification causes the second argument to be converted and output, and so on. If there are more arguments than there are format specifications, the extra arguments are ignored. The results are undefined if there are not enough arguments for all the format specifications.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is not a user-defined string.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
-   [System::Console::WriteLine](https://msdn.microsoft.com/en-us/library/system.console.writeline.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Locale](../vs140/locale.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_fprintf_p, _fwprintf_p](../vs140/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [_set_output_format](../vs140/_set_output_format.md)