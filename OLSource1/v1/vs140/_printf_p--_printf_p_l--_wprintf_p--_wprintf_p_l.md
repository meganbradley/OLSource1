---
title: "_printf_p, _printf_p_l, _wprintf_p, _wprintf_p_l"
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
  - "_printf_p"
  - "_wprintf_p"
  - "_printf_p_l"
  - "_wprintf_p_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wprintf_p"
  - "_wprintf_p"
  - "printf_p_l"
  - "_printf_p"
  - "printf_p"
  - "_wprintf_p_l"
  - "_printf_p_l"
  - "wprintf_p_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "printf_p function"
  - "printf_p_l function"
  - "wprintf_p function"
  - "wprintf_p_l function"
  - "_tprintf_p_l function"
  - "_wprintf_p function"
  - "_wprintf_p_l function"
  - "_printf_p function"
  - "tprintf_p_l function"
  - "_printf_p_l function"
ms.assetid: 1b7e9ef9-a069-45db-af9d-c2730168322e
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _printf_p, _printf_p_l, _wprintf_p, _wprintf_p_l
Prints formatted output to the standard output stream, and enables specification of the order in which parameters are used in the format string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Format control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns the number of characters printed or a negative value if an error occurs.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function formats and prints a series of characters and values to the standard output stream, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If arguments follow the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> string, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> string must contain specifications that determine the output format for the arguments (see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)).  
  
 The difference between <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> supports positional parameters, which allows specifying the order in which the arguments are used in the format string. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; they behave identically if the stream is opened in ANSI mode. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> doesn't currently support output into a UNICODE stream.  
  
 The versions of these functions with the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not a user-defined string.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or of the format string contains invalid formatting characters, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns -1 and sets <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 The console is not supported in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. The standard stream handles that are associated with the console—<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>—must be redirected before C run-time functions can use them in [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] apps. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Specifying the order: I'm a little tea pot.**  
**Reusing arguments: 10 10 10 10**  
**Width specifiers:     Hello**   
## .NET Framework Equivalent  
  
-   [System::Console::Write](https://msdn.microsoft.com/en-us/library/system.console.write.aspx)  
  
-   [System::Console::WriteLine](https://msdn.microsoft.com/en-us/library/system.console.writeline.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Locale](../vs140/locale.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_fprintf_p, _fwprintf_p](../vs140/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [fprintf_s, fwprintf_s](../vs140/fprintf_s--_fprintf_s_l--fwprintf_s--_fwprintf_s_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)   
 [_sprintf_p, _swprintf_p](../vs140/_sprintf_p--_sprintf_p_l--_swprintf_p--_swprintf_p_l.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [sprintf_s, swprintf_s](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)