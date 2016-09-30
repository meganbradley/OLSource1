---
title: "_vcprintf_p, _vcprintf_p_l, _vcwprintf_p, _vcwprintf_p_l"
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
  - "_vcprintf_p"
  - "_vcwprintf_p_l"
  - "_vcprintf_p_l"
  - "_vcwprintf_p"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "vcwprintf_p"
  - "vcprintf_p_l"
  - "_vcprintf_p"
  - "_vcprintf_p_l"
  - "vcwprintf_p_l"
  - "vcprintf_p"
  - "_vcwprintf_p"
  - "_vcwprintf_p_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_vtcprintf_p_l function"
  - "vcprintf_p_l function"
  - "_vcprintf_p_l function"
  - "vtcprintf_p_l function"
  - "vcprintf_p function"
  - "_vcwprintf_p function"
  - "_vcprintf_p function"
  - "vcwprintf_p function"
  - "vcwprintf_p_l function"
  - "vtcprintf_p function"
  - "_vcwprintf_p_l function"
  - "_vtcprintf_p function"
ms.assetid: 611024cc-90e7-41db-8e85-145ca95012b1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _vcprintf_p, _vcprintf_p_l, _vcwprintf_p, _vcwprintf_p_l
Writes formatted output to the console by using a pointer to a list of arguments, and supports positional parameters in the format string.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The format specification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a list of arguments.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specification Syntax: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 The number of characters that are written, or a negative value if an output error occurs. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and -1 is returned.  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, and then uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function to format and write the given data to the console. (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. It takes a wide-character string as an argument.)  
  
 The versions of these functions that have the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter that's passed in instead of the current locale.  
  
 Each <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (if any) is converted and is output according to the corresponding format specification in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The format specification supports positional parameters so that you can specify the order in which the arguments are used in the format string. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 These functions do not translate line-feed characters into carriage return-line feed (CR-LF) combinations when they are output.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 These functions validate the input pointer and the format string. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or if the format string contains invalid formatting characters, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<conio.h> and \<stdarg.h>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<conio.h> and \<stdarg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **parameter 2 = 222; parameter 1 = one**  
**38 characters printed**   
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cprintf, _cprintf_l, _cwprintf, _cwprintf_l](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)   
 [va_arg, va_copy, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md)   
 [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)