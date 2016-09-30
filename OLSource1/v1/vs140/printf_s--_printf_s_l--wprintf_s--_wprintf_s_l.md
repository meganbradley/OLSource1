---
title: "printf_s, _printf_s_l, wprintf_s, _wprintf_s_l"
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
  - "_printf_s_l"
  - "wprintf_s"
  - "_wprintf_s_l"
  - "printf_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wprintf_s"
  - "printf_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wprintf_s function"
  - "tprintf_s function"
  - "_tprintf_s function"
  - "printf_s_l function"
  - "printf_s function"
  - "_printf_s_l function"
  - "printf function, format specification fields"
  - "printf function, using"
  - "_tprintf_s_l function"
  - "wprintf_s_l function"
  - "formatted text [C++]"
  - "tprintf_s_l function"
  - "_wprintf_s_l function"
ms.assetid: 044ebb2e-5cc1-445d-bb4c-f084b405615b
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# printf_s, _printf_s_l, wprintf_s, _wprintf_s_l
Prints formatted output to the standard output stream. These versions of [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
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
 Returns the number of characters printed, or a negative value if an error occurs.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function formats and prints a series of characters and values to the standard output stream, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If arguments follow the *format* string, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> string must contain specifications that determine the output format for the arguments.  
  
 The main difference between <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> checks the format string for valid formatting characters, whereas <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> only checks if the format string is a null pointer. If either check fails, an invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and sets <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 For information on <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> behave identically except that <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> writes output to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> rather than to a destination of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see [fprintf_s, fwprintf_s](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md).  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> doesn't currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_unicode defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> argument consists of ordinary characters, escape sequences, and (if arguments follow <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>) format specifications. The ordinary characters and escape sequences are copied to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> in order of their appearance. For example, the line  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 produces the output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [Format specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md) always begin with a percent sign (<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>) and are read left to right. When <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> encounters the first format specification (if any), it converts the value of the first argument after <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and outputs it accordingly. The second format specification causes the second argument to be converted and output, and so on. If there are more arguments than there are format specifications, the extra arguments are ignored. The results are undefined if there are not enough arguments for all the format specifications.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is not a user-defined string.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
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
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)