---
title: "_vprintf_p, _vprintf_p_l, _vwprintf_p, _vwprintf_p_l"
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
  - "_vwprintf_p"
  - "_vprintf_p"
  - "_vprintf_p_l"
  - "_vwprintf_p_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_vwprintf_p_l"
  - "vprintf_p"
  - "_vprintf_p_l"
  - "_vwprintf_p"
  - "vprintf_p_l"
  - "vwprintf_p_l"
  - "vwprintf_p"
  - "vtprintf_p"
  - "_vtprintf_p"
  - "_vprintf_p"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_vtprintf_p_l function"
  - "_vtprintf_p function"
  - "vtprintf_p function"
  - "_vwprintf_p function"
  - "_vwprintf_p_l function"
  - "_vprintf_p function"
  - "_vprintf_p_l function"
  - "vprintf_p_l function"
  - "vwprintf_p function"
  - "vprintf_p function"
  - "vtprintf_p_l function"
  - "vwprintf_p_l function"
  - "formatted text [C++]"
ms.assetid: 3f99bde3-c891-493d-908f-30559c421058
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _vprintf_p, _vprintf_p_l, _vwprintf_p, _vwprintf_p_l
Writes formatted output by using a pointer to a list of arguments, and enables specification of the order in which the arguments are used.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Format specification.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> return the number of characters written, not including the terminating null character, or a negative value if an output error occurs.  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, then formats and writes the given data to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. These functions differ from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> only in that they support the ability to specify the order in which the arguments are used. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; the two functions behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> doesn't currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a null pointer, or if the format string contains invalid formatting characters, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<stdio.h> and \<stdarg.h>|\<varargs.h>*|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>, and \<stdarg.h>|\<varargs.h>*|  
  
 \* Required for UNIX V compatibility.  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [_fprintf_p, _fwprintf_p](../vs140/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)   
 [_printf_p, _wprintf_p](../vs140/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)   
 [_sprintf_p, _swprintf_p](../vs140/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)   
 [vsprintf_s, vswprintf_s](../vs140/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md)   
 [va_arg, va_copy, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md)   
 [_vfprintf_p, _vfwprintf_p](../vs140/_vfprintf_p--_vfprintf_p_l--_vfwprintf_p--_vfwprintf_p_l.md)   
 [_printf_p, _wprintf_p](../vs140/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)   
 [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)