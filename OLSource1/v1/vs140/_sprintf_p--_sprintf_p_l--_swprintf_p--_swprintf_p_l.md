---
title: "_sprintf_p, _sprintf_p_l, _swprintf_p, _swprintf_p_l"
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
  - "_sprintf_p"
  - "_swprintf_p_l"
  - "_swprintf_p"
  - "_sprintf_p_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sprintf_p"
  - "_swprintf_p_l"
  - "_sprintf_p_l"
  - "_swprintf_p"
  - "sprintf_p"
  - "swprint_p_l"
  - "swprintf_p"
  - "swprintf_p_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "sprintf_p_l function"
  - "swprintf_p function"
  - "swprintf_p_l function"
  - "_sprintf_p function"
  - "_sprintf_p_l function"
  - "_swprintf_p function"
  - "sprintf_p function"
  - "_stprintf_p function"
  - "stprintf_p function"
  - "_swprintf_p_l function"
  - "stprintf_p_l function"
  - "formatted text [C++]"
  - "_stprintf_p_l function"
ms.assetid: a2ae78e8-6b0c-48d5-87a9-ea2365b0693d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _sprintf_p, _sprintf_p_l, _swprintf_p, _swprintf_p_l
Write formatted data to a string with the ability to specify the order that the parameters are used in the format string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Storage location for output  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Maximum number of characters to store.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Format-control string  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Optional arguments  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 The number of characters written, or –1 if an error occurred.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function formats and stores a series of characters and values in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Each <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The format consists of ordinary characters and has the same form and function as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> character is appended after the last character written. If copying occurs between strings that overlap, the behavior is undefined. The difference between <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> supports positional parameters, which allows specifying the order in which the arguments are used in the format string. For more information, see [printf Positional Parameters](../vs140/printf_p-positional-parameters.md).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; the pointer arguments to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are wide-character strings. Detection of encoding errors in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> may differ from that in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> behave identically except that <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> writes output to a string rather than to a destination of type <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> requires the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>parameter to specify the maximum number of characters to be written. The versions of these functions with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> returns the number of bytes stored in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, not counting the terminating <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> character. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>returns the number of wide characters stored in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, not counting the terminating <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> wide character. If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is a null pointer, or if the format string contains invalid formatting characters, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
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
 **Wrote 24 characters**  
**Wrote -1 characters**   
## .NET Framework Equivalent  
 [System::String::Format](https://msdn.microsoft.com/en-us/library/system.string.format.aspx)  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [_fprintf_p, _fwprintf_p](../vs140/_fprintf_p--_fprintf_p_l--_fwprintf_p--_fwprintf_p_l.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [_printf_p, _wprintf_p](../vs140/_printf_p--_printf_p_l--_wprintf_p--_wprintf_p_l.md)   
 [printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [sscanf_s, swscanf_s](../vs140/sscanf_s--_sscanf_s_l--swscanf_s--_swscanf_s_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [printf Positional Parameters](../vs140/printf_p-positional-parameters.md)