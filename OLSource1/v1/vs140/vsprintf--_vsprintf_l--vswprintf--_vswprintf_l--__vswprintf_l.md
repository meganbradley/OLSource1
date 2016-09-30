---
title: "vsprintf, _vsprintf_l, vswprintf, _vswprintf_l, __vswprintf_l"
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
  - "_vswprintf_l"
  - "_vsprintf_l"
  - "vsprintf"
  - "vswprintf"
  - "__vswprintf_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vstprintf"
  - "vswprintf"
  - "_vstprintf"
  - "vsprintf"
  - "__vswprintf_l"
  - "_vsprintf_l"
  - "_vswprintf_l"
  - "vswprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__vswprintf_l function"
  - "_vstprintf_l function"
  - "formatted text"
  - "vstprintf_l function"
  - "_vswprintf_l function"
  - "vsprintf_l function"
  - "buffers, avoiding overruns"
  - "buffer overruns"
  - "vswprintf_l function"
  - "buffers, buffer overruns"
  - "vstprintf function"
  - "_vsprintf_l function"
  - "vswprintf function"
  - "vsprintf function"
  - "_vstprintf function"
ms.assetid: b8ef1c0d-58f9-4a18-841a-f1a989e1c29b
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vsprintf, _vsprintf_l, vswprintf, _vswprintf_l, __vswprintf_l
Write formatted output using a pointer to a list of arguments. More secure versions of these functions are available; see [vsprintf_s, _vsprintf_s_l, vswprintf_s, _vswprintf_s_l](../vs140/vsprintf_s--_vsprintf_s_l--vswprintf_s--_vswprintf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum number of characters to store, in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> version of this function.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Format specification.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> return the number of characters written, not including the terminating null character, or a negative value if an output error occurs. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a null pointer, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 For information on these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, and then formats and writes the given data to the memory pointed to by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The versions of these functions with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Using <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, here is no way to limit the number of characters written, which means that code using this function is susceptible to buffer overruns. Use [_vsnprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md) instead, or call [_vscprintf](../vs140/_vscprintf--_vscprintf_l--_vscwprintf--_vscwprintf_l.md) to determine how large a buffer is needed. Also, ensure that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> conforms to the ISO C Standard, which requires the second parameter, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. To force the old nonstandard behavior, define <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> The old behavior may not be in a future version, so code should be changed to use the new conformant behavior.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<stdio.h> and \<stdarg.h>|\<varargs.h>*|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>, and \<stdarg.h>|\<varargs.h>*|  
  
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