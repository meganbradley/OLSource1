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
Writes formatted output to the console by using a pointer to a list of arguments. More secure versions of these functions are available, see [_vcprintf_s, _vcprintf_s_l, _vcwprintf_s, _vcprintf_s_l](../vs140/_vcprintf_s--_vcprintf_s_l--_vcwprintf_s--_vcwprintf_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Format specification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 The number of characters written, or a negative value if an output error occurs. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and -1 is returned.  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, then formats and writes the given data to the console. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. It takes a wide-character string as an argument.  
  
 The versions of these functions with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<conio.h> and \<stdarg.h>|\<varargs.h>*|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<conio.h> or \<wchar.h>, and \<stdarg.h>|\<varargs.h>*|  
  
 \* Required for UNIX V compatibility.  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **(10,23): Error C2111 : \<some error text>**  
 **(Related to symbol '\<symbol>' defined on line 5).**   
## .NET Framework Equivalent  
 [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [_cprintf, _cprintf_l, _cwprintf, _cwprintf_l](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [va_arg, va_copy, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md)