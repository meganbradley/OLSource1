---
title: "_cprintf_p, _cprintf_p_l, _cwprintf_p, _cwprintf_p_l"
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
  - "_cprintf_p_l"
  - "_cwprintf_p_l"
  - "_cwprintf_p"
  - "_cprintf_p"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "cprintf_p"
  - "cwprintf_p"
  - "tcprintf_p"
  - "_cwprintf_p_l"
  - "_cprintf_p"
  - "csprintf_p_l"
  - "_cprintf_p_l"
  - "_cwprintf_p"
  - "_tcprintf_p"
  - "cprintf_p_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_cwprintf_p_l function"
  - "cwprintf_p function"
  - "tcprintf_p_l function"
  - "cprintf_p_l function"
  - "_tcprintf_p function"
  - "_tcprintf_p_l function"
  - "_cprintf_p function"
  - "_cprintf_p_l function"
  - "cwprintf_p_l function"
  - "_cwprintf_p function"
  - "tcprintf_p function"
  - "cprintf_p function"
ms.assetid: 1f82fd7d-13c8-4c4a-a3e4-db0df3873564
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cprintf_p, _cprintf_p_l, _cwprintf_p, _cwprintf_p_l
Formats and prints to the console, and supports positional parameters in the format string.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional parameters.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 The number of characters printed or a negative value if an error occurs.  
  
## Remarks  
 These functions format and print a series of characters and values directly to the console, using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions to output characters. Each <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The format has the same form and function as the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter for the [printf_p](../vs140/format-specification-syntax--printf-and-wprintf-functions.md) function. The difference between <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> supports positional parameters, which allows specifying the order in which the arguments are used in the format string. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 Unlike the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions, neither <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> translates line-feed characters into carriage return–line feed (CR-LF) combinations when output. An important distinction is that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> displays Unicode characters when used in Windows NT. Unlike <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> uses the current console locale settings.  
  
 The versions of these functions with the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is not a user-defined string.  
  
 Also, like <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, they validate the input pointer and the format string. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or of the format string contains invalid formatting characters, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<conio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **-16  001d  62511  A Test**   
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cscanf, _cwscanf](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)   
 [_cscanf_s, _cwscanf_s](../vs140/_cscanf_s--_cscanf_s_l--_cwscanf_s--_cwscanf_s_l.md)   
 [_fprintf_p, _fwprintf_p](../vs140/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)   
 [fprintf_s, _fprintf_s_l, fwprintf_s, _fwprintf_s_l](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)   
 [_printf_p, _wprintf_p](../vs140/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)   
 [printf_s, _printf_s_l, wprintf_s, _wprintf_s_l](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)   
 [_sprintf_p, _swprintf_p](../vs140/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)   
 [_vfprintf_p, _vfwprintf_p](../vs140/_vfprintf_p--_vfprintf_p_l--_vfwprintf_p--_vfwprintf_p_l.md)   
 [_cprintf_s, _cprintf_s_l, _cwprintf_s, _cwprintf_s_l](../vs140/_cprintf_s--_cprintf_s_l--_cwprintf_s--_cwprintf_s_l.md)   
 [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)