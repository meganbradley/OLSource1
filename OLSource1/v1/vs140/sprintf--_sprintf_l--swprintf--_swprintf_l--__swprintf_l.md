---
title: "sprintf, _sprintf_l, swprintf, _swprintf_l, __swprintf_l"
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
  - "__swprintf_l"
  - "sprintf"
  - "_sprintf_l"
  - "_swprintf_l"
  - "swprintf"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_stprintf_l"
  - "__swprintf_l"
  - "sprintf_l"
  - "swprintf"
  - "_sprintf_l"
  - "sprintf"
  - "_stprintf"
  - "stprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_swprintf_l function"
  - "_stprintf function"
  - "__swprintf_l function"
  - "stprintf function"
  - "sprintf function"
  - "_sprintf_l function"
  - "_stprintf_l function"
  - "swprintf function"
  - "strings [C++], writing to"
  - "_CRT_NON_CONFORMING_SWPRINTFS"
  - "swprintf_l function"
  - "stprintf_l function"
  - "sprintf_l function"
  - "formatted text [C++]"
ms.assetid: f6efe66f-3563-4c74-9455-5411ed939b81
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sprintf, _sprintf_l, swprintf, _swprintf_l, __swprintf_l
Write formatted data to a string. More secure versions of some of these functions are available; see [sprintf_s, _sprintf_s_l, swprintf_s, _swprintf_s_l](../vs140/sprintf_s--_sprintf_s_l--swprintf_s--_swprintf_s_l.md). The secure versions of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> do not take a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Storage location for output  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Maximum number of characters to store in the Unicode version of this function.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Format-control string  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional arguments  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 The number of characters written, or –1 if an error occurred. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns the number of bytes stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, not counting the terminating null character. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>returns the number of wide characters stored in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, not counting the terminating null wide character.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function formats and stores a series of characters and values in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Each <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The format consists of ordinary characters and has the same form and function as the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument for [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md). A null character is appended after the last character written. If copying occurs between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  Using <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, there is no way to limit the number of characters written, which means that code using <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is susceptible to buffer overruns. Consider using the related function [_snprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md), which specifies a maximum number of characters to be written to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, or use [_scprintf](../vs140/_scprintf--_scprintf_l--_scwprintf--_scwprintf_l.md) to determine how large a buffer is required. Also, ensure that <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is not a user-defined string.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>; the pointer arguments to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> are wide-character strings. Detection of encoding errors in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> may differ from that in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> behave identically except that <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> writes output to a string rather than to a destination of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> requires the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter to specify the maximum number of characters to be written. The versions of these functions with the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> conforms to the ISO C Standard, which requires the second parameter, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, of type <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. To force the old nonstandard behavior, define <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. In a future version, the old behavior may be removed, so code should be changed to use the new conformant behavior.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output:**  
 **String:    computer**  
 **Character: l**  
 **Integer:   35**  
 **Real:      1.732053**  
**character count = 79**   
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **wrote 11 characters**  
**wrote -1 characters**   
## .NET Framework Equivalent  
 [System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)