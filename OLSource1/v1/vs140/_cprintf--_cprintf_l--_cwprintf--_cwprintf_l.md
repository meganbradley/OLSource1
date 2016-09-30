---
title: "_cprintf, _cprintf_l, _cwprintf, _cwprintf_l"
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
  - "_cwprintf_l"
  - "_cprintf_l"
  - "_cwprintf"
  - "_cprintf"
apilocation: 
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_cwprintf"
  - "cwprintf"
  - "tcprintf"
  - "_tcprintf"
  - "_cprintf"
  - "cwprintf_l"
  - "tcprintf_l"
  - "_tcprintf_l"
  - "cprintf_l"
  - "_cprintf_l"
  - "_cwprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_cprintf_l function"
  - "_cwprintf_l function"
  - "cwprintf function"
  - "cprintf_l function"
  - "characters, printing to console"
  - "printing characters to console"
  - "_tcprintf_l function"
  - "tcprintf function"
  - "_tcprintf function"
  - "tcprintf_l function"
  - "_cwprintf function"
  - "cwprintf_l function"
  - "_cprintf function"
ms.assetid: 67ffefd4-45b3-4be0-9833-d8d26ac7c4e2
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _cprintf, _cprintf_l, _cwprintf, _cwprintf_l
Formats and prints to the console. More-secure versions are available; see [_cprintf_s, _cprintf_s_l, _cwprintf_s, _cwprintf_s_l](../vs140/_cprintf_s--_cprintf_s_l--_cwprintf_s--_cwprintf_s_l.md).  
  
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
 The number of characters printed.  
  
## Remarks  
 Thesefunctions format and print a series of characters and values directly to the console, using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to output characters. Each <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The format has the same form and function as the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter for the [printf](../vs140/format-specification-syntax--printf-and-wprintf-functions.md) function. Unlike the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> functions, neither <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> translates line-feed characters into carriage return–line feed (CR-LF) combinations when output.  
  
 An important distinction is that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> displays Unicode characters when used in Windows NT. Unlike <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> uses the current console locale settings.  
  
 The versions of these functions with the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current locale.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> validates the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a null pointer, the function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and sets <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is not a user-defined string.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<conio.h>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<conio.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **-16  001d  62511  A Test**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Console and Port I/O](../vs140/console-and-port-i-o.md)   
 [_cscanf, _cwscanf](../vs140/_cscanf--_cscanf_l--_cwscanf--_cwscanf_l.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [vfprintf, vfwprintf](../vs140/vfprintf--_vfprintf_l--vfwprintf--_vfwprintf_l.md)   
 [_cprintf_s, _cwprintf_s](../vs140/_cprintf_s--_cprintf_s_l--_cwprintf_s--_cwprintf_s_l.md)   
 [_cprintf_p, _cwprintf_p](../vs140/_cprintf_p--_cprintf_p_l--_cwprintf_p--_cwprintf_p_l.md)   
 [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md)