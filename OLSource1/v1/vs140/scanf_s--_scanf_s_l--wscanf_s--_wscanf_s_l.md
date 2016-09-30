---
title: "scanf_s, _scanf_s_l, wscanf_s, _wscanf_s_l"
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
  - "wscanf_s"
  - "_wscanf_s_l"
  - "scanf_s"
  - "_scanf_s_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wscanf_s"
  - "_tscanf_s_l"
  - "_wscanf_s_l"
  - "scanf_s"
  - "_tscanf_s"
  - "_scanf_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "reading data [C++], from input streams"
  - "buffers [C++], buffer overruns"
  - "_scanf_s_l function"
  - "_wscanf_s_l function"
  - "tscanf_s_l function"
  - "tscanf_s function"
  - "scanf_s function"
  - "data [C++], reading from input stream"
  - "wscanf_s function"
  - "_tscanf_s_l function"
  - "_tscanf_s function"
  - "scanf_s_l function"
  - "formatted data [C++], from input streams"
  - "wscanf_s_l function"
  - "buffers [C++], avoiding overruns"
ms.assetid: 42cafcf7-52d6-404a-80e4-b056a7faf2e5
caps.latest.revision: 35
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# scanf_s, _scanf_s_l, wscanf_s, _wscanf_s_l
Reads formatted data from the standard input stream. These versions of [scanf, _scanf_l, wscanf, _wscanf_l](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Format control string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns the number of fields successfully converted and assigned; the return value does not include fields that were read but not assigned. A return value of 0 indicates that no fields were assigned. The return value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for an error, or if the end-of-file character or the end-of-string character is encountered in the first attempt to read a character. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function reads data from the standard input stream <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and writes the data into the location that's given by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Each <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be a pointer to a variable of a type that corresponds to a type specifier in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If copying occurs between strings that overlap, the behavior is undefined.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> doesn't currently support input from a UNICODE stream.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter that's passed in instead of the current thread locale.  
  
 Unlike <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> require the buffer size to be specified for all input parameters of type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or string control sets that are enclosed in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The buffer size in characters is passed as an additional parameter immediately following the pointer to the buffer or variable. For example, if you are reading a string, the buffer size for that string is passed as follows:  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 The buffer size includes the terminating null. You can use a width specification field to ensure that the token that's read in will fit into the buffer. If no width specification field is used, and the token read in is too big to fit in the buffer, nothing is written to that buffer.  
  
> [!NOTE]
>  The size parameter is of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. Use a static cast to convert a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> value to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> for 64-bit build configurations.  
  
 The following example shows that the buffer size parameter describes the maximum number of characters, not bytes. In the call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, the character width that is indicated by the buffer type does not match the character width that is indicated by the format specifier.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> format specifier indicates the use of the character width that is "opposite" the default width that is supported by the function. The character width is single-byte, but the function supports double-byte characters. This example reads in a string of up to 9 single-byte-wide characters and puts them in a double-byte-wide character buffer. The characters are treated as single-byte values; the first two characters are stored in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, the second two are stored in <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and so on.  
  
 In the case of characters, a single character may be read as follows:  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 When multiple characters for non-null terminated strings are read, integers are used as the width specification and the buffer size.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 For more information, see [scanf Width Specification](../vs140/scanf-width-specification.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
  
 For more information, see [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This program produces the following output when given this input:  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
 **The number of fields input is 6**  
**The contents are: 71 98.599998 h z Byte characters**  
**The number of fields input is 6**  
**The contents are: 36 92.300003 y n Wide characters**   
## .NET Framework Equivalent  
  
-   [System::Console::Read](https://msdn.microsoft.com/en-us/library/system.console.read.aspx)  
  
-   [System::Console::ReadLine](https://msdn.microsoft.com/en-us/library/system.console.readline.aspx)  
  
-   See also <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> methods, such as [System::Double::Parse](https://msdn.microsoft.com/en-us/library/system.double.parse.aspx).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Locale](../vs140/locale.md)   
 [fscanf, _fscanf_l, fwscanf, _fwscanf_l](../vs140/fscanf--_fscanf_l--fwscanf--_fwscanf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [sscanf, _sscanf_l, swscanf, _swscanf_l](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)