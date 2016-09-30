---
title: "vscanf_s, vwscanf_s"
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
  - "vscanf_s"
  - "vwscanf_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_vtscanf_s"
  - "vscanf_s"
  - "vwscanf_s"
dev_langs: 
  - "C++"
ms.assetid: 23a1c383-5b01-4887-93ce-534a1e38ed93
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vscanf_s, vwscanf_s
Reads formatted data from the standard input stream. These versions of [vscanf, vwscanf](../vs140/vscanf--vwscanf.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Format control string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Variable argument list.  
  
## Return Value  
 Returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for an error, or if the end-of-file character or the end-of-string character is encountered in the first attempt to read a character. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function reads data from the standard input stream <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and writes the data into the locations that are given by the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument list. Each argument in the list must be a pointer to a variable of a type that corresponds to a type specifier in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. If copying occurs between strings that overlap, the behavior is undefined.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> doesn't support input from a UNICODE stream.  
  
 Unlike <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> require the buffer size to be specified for all input parameters of type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, or string control sets that are enclosed in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. The buffer size in characters is passed as an additional parameter immediately following the pointer to the buffer or variable. The buffer size in characters for a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> string is not the same as the size in bytes.  
  
 The buffer size includes the terminating null. You can use a width-specification field to ensure that the token that's read in will fit into the buffer. If no width specification field is used, and the token read in is too big to fit in the buffer, nothing is written to that buffer.  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 For more information, see [scanf Width Specification](../vs140/scanf-width-specification.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When this program is given the input in the example, it produces this output:  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 **The number of fields input is 6**  
**The contents are: 71 98.599998 h z Byte characters**  
**The number of fields input is 6**  
**The contents are: 36 92.300003 y n Wide characters**   
## .NET Framework Equivalent  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
-   [System::Console::ReadLine](https://msdn.microsoft.com/en-us/library/system.console.readline.aspx)  
  
-   See also <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Locale](../vs140/locale.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [scanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)   
 [vscanf, vwscanf](../vs140/vscanf--vwscanf.md)