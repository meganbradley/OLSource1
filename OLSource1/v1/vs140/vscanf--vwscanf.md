---
title: "vscanf, vwscanf"
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
  - "vscanf"
  - "vwscanf"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vscanf"
  - "vwscanf"
  - "_vtscanf"
dev_langs: 
  - "C++"
ms.assetid: d1df595b-11bc-4682-9441-a92616301e3b
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vscanf, vwscanf
Reads formatted data from the standard input stream. More secure versions of these function are available; see [vscanf_s, vwscanf_s](../vs140/vscanf_s--vwscanf_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Format control string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Variable argument list.  
  
## Return Value  
 Returns the number of fields that are successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned.  
  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function reads data from the standard input stream <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and writes the data into the locations that are given by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument list. Each argument in the list must be a pointer to a variable of a type that corresponds to a type specifier in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If copying occurs between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  When you use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to read a string, always specify a width for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> format (for example, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>); otherwise, incorrectly formatted input can cause a buffer overrun. As an alternative, you can use [vscanf_s, vwscanf_s](../vs140/vscanf_s--vwscanf_s.md) or [fgets](../vs140/fgets--fgetws.md).  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> doesn't support input from a UNICODE stream.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>The number of fields input is 6**  
**The contents are: 71 98.599998 h z Byte characters**  
**The number of fields input is 6**  
**The contents are: 36 92.300003 y n Wide characters**   
## .NET Framework Equivalent  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
-   [System::Console::ReadLine](https://msdn.microsoft.com/en-us/library/system.console.readline.aspx)  
  
-   See also <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Locale](../vs140/locale.md)   
 [fscanf, _fscanf_l, fwscanf, _fwscanf_l](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [sscanf, _sscanf_l, swscanf, _swscanf_l](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [vscanf_s, vwscanf_s](../vs140/vscanf_s--vwscanf_s.md)