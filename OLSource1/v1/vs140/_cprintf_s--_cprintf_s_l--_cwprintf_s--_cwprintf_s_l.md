---
title: "_cprintf_s, _cprintf_s_l, _cwprintf_s, _cwprintf_s_l"
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
  - "_cwprintf_s_l"
  - "_cprintf_s_l"
  - "_cprintf_s"
  - "_cwprintf_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_cwprintf_s_l"
  - "_cprintf_s"
  - "cwprintf_s"
  - "_cprintf_s_l"
  - "cwprintf_s_l"
  - "cprintf_s_l"
  - "_tcprintf_s"
  - "cprintf_s"
  - "_cwprintf_s"
  - "tcprintf_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcprintf_s_l function"
  - "_cprintf_s_l function"
  - "_cwprintf_s_l function"
  - "tcprintf_s function"
  - "_tcprintf_s_l function"
  - "_cwprintf_s function"
  - "cwprintf_s function"
  - "_cprintf_s function"
  - "cprintf_s function"
  - "_tcprintf_s function"
  - "cprintf_s_l function"
  - "cwprintf_s_l function"
ms.assetid: c28504fe-0d20-4f06-8f97-ee33225922ad
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cprintf_s, _cprintf_s_l, _cwprintf_s, _cwprintf_s_l
Formats and prints to the console. These versions of [_cprintf, _cprintf_l, _cwprintf, _cwprintf_l](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Optional parameters.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 The number of characters printed.  
  
## Remarks  
 These functions format and print a series of characters and values directly to the console, using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) to output characters. Each <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The format has the same form and function as the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter for the [printf_s](../vs140/format-specification-syntax--printf-and-wprintf-functions.md) function. Unlike the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> functions, neither <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> translates line-feed characters into carriage return–line feed (CR-LF) combinations when output.  
  
 An important distinction is that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> displays Unicode characters when used in Windows NT. Unlike <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> uses the current console locale  
  
 The versions of these functions with the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is not a user-defined string.  
  
 Like the non-secure versions (see [_cprintf, _cwprintf](../vs140/_cprintf--_cprintf_l--_cwprintf--_cwprintf_l.md)), these functions validate their parameters and invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md), if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a null pointer. These functions differ from the non-secure versions in that the format string itself is also validated. If there are any unknown or badly formed formatting specifiers, these functions invoke the invalid parameter handler. In all cases, If execution is allowed to continue, the functions return -1 and set <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<conio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cscanf, _cwscanf](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)   
 [fprintf_s, fwprintf_s](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)   
 [printf_s, wprintf_s](../vs140/printf_s--_printf_s_l--wprintf_s--_wprintf_s_l.md)   
 [sprintf_s, swprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)   
 [vfprintf_s, vfwprintf_s](../vs140/vfprintf_s--_vfprintf_s_l--vfwprintf_s--_vfwprintf_s_l.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)