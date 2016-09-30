---
title: "scanf, _scanf_l, wscanf, _wscanf_l"
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
  - "_wscanf_l"
  - "scanf"
  - "_scanf_l"
  - "wscanf"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tscanf"
  - "_scanf_l"
  - "wscanf"
  - "_wscanf_l"
  - "scanf"
  - "_tscanf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tscanf_l function"
  - "_tscanf_l function"
  - "reading data [C++], from input streams"
  - "_tscanf function"
  - "data [C++], reading from input stream"
  - "scanf_l function"
  - "scanf function"
  - "wscanf function"
  - "_scanf_l function"
  - "tscanf function"
  - "formatted data [C++], from input streams"
  - "wscanf_l function"
  - "_wscanf_l function"
ms.assetid: 73eac607-117f-4be4-9ff0-4afd9cf3c848
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scanf, _scanf_l, wscanf, _wscanf_l
Reads formatted data from the standard input stream. More secure versions of these function are available; see [scanf_s, _scanf_s_l, wscanf_s, _wscanf_s_l](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Format control string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function reads data from the standard input stream <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and writes the data into the location given by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Each <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be a pointer to a variable of a type that corresponds to a type specifier in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If copying takes place between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  When reading a string with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, always specify a width for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> format (for example, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>); otherwise, improperly formatted input can easily cause a buffer overrun. Alternately, consider using [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md) or [fgets](../vs140/fgets--fgetws.md).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> doesn't currently support input from a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specification Fields — scanf functions and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>The number of fields input is 6**  
**The contents are: 71 98.599998 h z Byte characters**  
**The number of fields input is 6**  
**The contents are: 36 92.300003 y n Wide characters**   
## .NET Framework Equivalent  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
-   [System::Console::ReadLine](https://msdn.microsoft.com/en-us/library/system.console.readline.aspx)  
  
-   See also <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Locale](../vs140/locale.md)   
 [fscanf, _fscanf_l, fwscanf, _fwscanf_l](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [sscanf, _sscanf_l, swscanf, _swscanf_l](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)