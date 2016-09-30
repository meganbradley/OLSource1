---
title: "vsnprintf_s, _vsnprintf_s, _vsnprintf_s_l, _vsnwprintf_s, _vsnwprintf_s_l"
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
  - "_vsnwprintf_s"
  - "_vsnwprintf_s_l"
  - "_vsnprintf_s"
  - "vsnprintf_s"
  - "_vsnprintf_s_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_vsnprintf_s"
  - "_vsntprintf_s"
  - "_vsnwprintf_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "vsnwprintf_s function"
  - "_vsntprintf_s function"
  - "_vsntprintf_s_l function"
  - "vsntprintf_s function"
  - "vsnwprintf_s_l function"
  - "vsnprintf_s_l function"
  - "vsntprintf_s_l function"
  - "_vsnwprintf_s_l function"
  - "_vsnprintf_s function"
  - "vsnprintf_s function"
  - "_vsnprintf_s_l function"
  - "_vsnwprintf_s function"
  - "formatted text [C++]"
ms.assetid: 147ccfce-58c7-4681-a726-ef54ac1c604e
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vsnprintf_s, _vsnprintf_s, _vsnprintf_s_l, _vsnwprintf_s, _vsnwprintf_s_l
Write formatted output using a pointer to a list of arguments. These are versions of [vsnprintf, _vsnprintf, _vsnprintf_l, _vsnwprintf, _vsnwprintf_l](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for output, as the character count.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Maximum number of characters to write (not including the terminating null), or [_TRUNCATE](../vs140/_truncate.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Format specification.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to list of arguments.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specifications](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> return the number of characters written, not including the terminating null, or a negative value if an output error occurs. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is included for compliance to the ANSI standard. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is retained for backward compatibility.  
  
 If the storage required to store the data and a terminating null exceeds <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md), unless <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is [_TRUNCATE](../vs140/_truncate.md), in which case as much of the string as will fit in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is written and -1 returned. If execution continues after the invalid parameter handler, these functions set <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to an empty string, set <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and return -1.  
  
 If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> pointer, or if <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is less than or equal to zero, the invalid parameter handler is invoked. If execution is allowed to continue, these functions set <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and return -1.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Return|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|-----------------|------------|-------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|-1|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|-1|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> <= 0|-1|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> too small (and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> != <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>)|-1 (and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> set to an empty string)|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
  
## Remarks  
 Each of these functions takes a pointer to an argument list, then formats and writes up to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> characters of the given data to the memory pointed to by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and appends a terminating null.  
  
 If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is [_TRUNCATE](../vs140/_truncate.md), then these functions write as much of the string as will fit in <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> while leaving room for a terminating null. If the entire string (with terminating null) fits in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, then these functions return the number of characters written (not including the terminating null); otherwise, these functions return -1 to indicate that truncation occurred.  
  
 The versions of these functions with the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is not a user-defined string. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
> [!NOTE]
>  To ensure that there is room for the terminating null, be sure that <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is strictly less than the buffer length, or use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|Optional headers|  
|-------------|---------------------|----------------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdio.h> and \<stdarg.h>|\<varargs.h>*|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|\<stdio.h> and \<stdarg.h>|\<varargs.h>*|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>, and \<stdarg.h>|\<varargs.h>*|  
  
 \* Required for UNIX V compatibility.  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **nSize: 8, buff: Hi there**  
**nSize: 9, buff: Hi there!**  
**nSize: -1, buff: Hi there!**   
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)   
 [fprintf, _fprintf_l, fwprintf, _fwprintf_l](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, _printf_l, wprintf, _wprintf_l](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [sprintf, _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [va_arg, va_copy, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md)