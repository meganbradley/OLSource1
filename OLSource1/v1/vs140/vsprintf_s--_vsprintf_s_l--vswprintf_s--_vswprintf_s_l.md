---
title: "vsprintf_s, _vsprintf_s_l, vswprintf_s, _vswprintf_s_l"
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
  - "_vswprintf_s_l"
  - "vsprintf_s"
  - "vswprintf_s"
  - "_vsprintf_s_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vswprintf_s"
  - "vsprintf_s"
  - "_vstprintf_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_vstprintf_s_l function"
  - "vsprintf_s_l function"
  - "_vstprintf_s function"
  - "vswprintf_s function"
  - "vstprintf_s function"
  - "vstprintf_s_l function"
  - "vswprintf_s_l function"
  - "vsprintf_s function"
  - "_vsprintf_s_l function"
  - "formatted text [C++]"
  - "_vswprintf_s_l function"
ms.assetid: 60e90518-57f0-4f1b-b732-f62a69702833
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vsprintf_s, _vsprintf_s_l, vswprintf_s, _vswprintf_s_l
Write formatted output using a pointer to a list of arguments. These are versions of [vsprintf, _vsprintf_l, vswprintf, _vswprintf_l](../vs140/vsprintf--_vsprintf_l--vswprintf--_vswprintf_l--__vswprintf_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in characters.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Format specification.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> return the number of characters written, not including the terminating null character, or a negative value if an output error occurs. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a null pointer, if count is zero, or if the format string contains invalid formatting characters, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, and then formats and writes the given data to the memory pointed to by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> conforms to the ISO C Standard for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which requires the second parameter, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 These functions differ from the non-secure versions only in that the secure versions support positional parameters. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 The versions of these functions with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<stdio.h> and \<stdarg.h>|\<varargs.h>*|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>, and \<stdarg.h>|\<varargs.h>*|  
  
 \* Required for UNIX V compatibility.  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **123 < 456**  
**This is a string**   
## .NET Framework Equivalent  
 [System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [Format Specification Syntax: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [va_arg, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md)