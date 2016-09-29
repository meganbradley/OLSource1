---
title: "_vcprintf, _vcprintf_l, _vcwprintf, _vcwprintf_l"
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
  - "_vcwprintf"
  - "_vcprintf_l"
  - "_vcwprintf_l"
  - "_vcprintf"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_vcwprintf_l"
  - "_vtcprintf"
  - "vcwprintf"
  - "_vcwprintf"
  - "vcprintf_l"
  - "_vcprintf_l"
  - "_vcprintf"
  - "vcprintf"
  - "vcwprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "vcwprintf function"
  - "_vcwprintf_l function"
  - "_vcprintf function"
  - "_vcprintf_l function"
  - "vtcprintf_l function"
  - "vcprintf function"
  - "vcprintf_l function"
  - "_vtcprintf function"
  - "_vcwprintf function"
  - "_vtcprintf_l function"
  - "vcwprintf_l function"
  - "vtcprintf function"
  - "formatted text [C++]"
ms.assetid: 4ef8d237-6200-4b66-8731-8c57e5624bb1
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _vcprintf, _vcprintf_l, _vcwprintf, _vcwprintf_l
Writes formatted output to the console by using a pointer to a list of arguments. More secure versions of these functions are available, see [_vcprintf_s, _vcprintf_s_l, _vcwprintf_s, _vcprintf_s_l](../VS_csharp/_vcprintf_s--_vcprintf_s_l--_vcwprintf_s--_vcwprintf_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
```  
int _vcprintf(  
   const char* format,  
   va_list argptr  
);  
int _vcprintf_l(  
   const char* format,  
   locale_t locale,  
   va_list argptr  
);  
int _vcwprintf(  
   const wchar_t* format,  
   va_list argptr  
);  
int _vcwprintf_l(  
   const wchar_t* format,  
   locale_t locale,  
   va_list argptr  
);  
```  
  
#### Parameters  
 `format`  
 Format specification.  
  
 `argptr`  
 Pointer to list of arguments.  
  
 `locale`  
 The locale to use.  
  
 For more information, see [Format Specifications](../VS_csharp/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 The number of characters written, or a negative value if an output error occurs. If `format` is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, `errno` is set to `EINVAL` and -1 is returned.  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, then formats and writes the given data to the console. `_vcwprintf` is the wide-character version of `_vcprintf`. It takes a wide-character string as an argument.  
  
 The versions of these functions with the `_l` suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
> [!IMPORTANT]
>  Ensure that `format` is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_vtcprintf`|`_vcprintf`|`_vcprintf`|`_vcwprintf`|  
|`_vtcprintf_l`|`_vcprintf_l`|`_vcprintf_l`|`_vcwprintf_l`|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|`_vcprintf`, `_vcprintf_l`|<conio.h> and <stdarg.h>|<varargs.h>*|  
|`_vcwprintf`, `_vcwprintf_l`|<conio.h> or <wchar.h>, and <stdarg.h>|<varargs.h>*|  
  
 \* Required for UNIX V compatibility.  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md).  
  
## Example  
  
```  
// crt_vcprintf.cpp  
// compile with: /c  
#include <conio.h>  
#include <stdarg.h>  
  
// An error formatting function used to print to the console.  
int eprintf(const char* format, ...)  
{  
  va_list args;  
  va_start(args, format);  
  return _vcprintf(format, args);  
}  
  
int main()  
{  
   eprintf("  (%d:%d): Error %s%d : %s\n", 10, 23, "C", 2111,  
           "<some error text>");  
   eprintf("  (Related to symbol '%s' defined on line %d).\n",  
           "<symbol>", 5 );  
}  
```  
  
 **(10,23): Error C2111 : <some error text\>**  
 **(Related to symbol '<symbol\>' defined on line 5).**   
## .NET Framework Equivalent  
 [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../VS_csharp/stream-i-o.md)   
 [vprintf Functions](../VS_csharp/vprintf-functions.md)   
 [_cprintf, _cprintf_l, _cwprintf, _cwprintf_l](../VS_csharp/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../VS_csharp/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../VS_csharp/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../VS_csharp/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [va_arg, va_copy, va_end, va_start](../VS_csharp/va_arg--va_copy--va_end--va_start.md)