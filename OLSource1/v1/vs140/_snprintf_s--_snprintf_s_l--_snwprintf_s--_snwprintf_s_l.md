---
title: "_snprintf_s, _snprintf_s_l, _snwprintf_s, _snwprintf_s_l"
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
  - "_snprintf_s"
  - "_snprintf_s_l"
  - "_snwprintf_s"
  - "_snwprintf_s_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_snwprintf_s_l"
  - "_sntprintf_s_l"
  - "snprintf_s_l"
  - "_snprintf_s_l"
  - "_sntprintf_s"
  - "_snprintf_s"
  - "snprintf_s"
  - "_snwprintf_s"
  - "snwprintf_s_l"
  - "snwprintf_s"
  - "sntprintf_s"
  - "sntprintf_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_snprintf_s_l function"
  - "_snwprintf_s_l function"
  - "_sntprintf_s_l function"
  - "snwprintf_s_l function"
  - "snprintf_s function"
  - "_snprintf_s function"
  - "snprintf_s_l function"
  - "_sntprintf_s function"
  - "sntprintf_s_l function"
  - "sntprintf_s function"
  - "snwprintf_s function"
  - "_snwprintf_s function"
  - "formatted text [C++]"
ms.assetid: 9336ab86-13e5-4a29-a3cd-074adfee6891
caps.latest.revision: 34
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _snprintf_s, _snprintf_s_l, _snwprintf_s, _snwprintf_s_l
Writes formatted data to a string. These are versions of [_snprintf, _snprintf_l, _snwprintf, _snwprintf_l](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for the output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the storage location for output. Size in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or size in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Maximum number of characters to store, or [_TRUNCATE](../vs140/_truncate.md).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns the number of characters stored in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, not counting the terminating null character. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns the number of wide characters stored in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, not counting the terminating null wide character.  
  
 If the storage required to store the data and a terminating null exceeds <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution continues after the invalid parameter handler, these functions set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to an empty string, set <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and return -1.  
  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> pointer, or if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is less than or equal to zero, the invalid parameter handler is invoked. If execution is allowed to continue, these functions set <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and return -1.  
  
 For information about these and other error codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function formats and stores <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or fewer characters in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and appends a terminating null. Each argument (if any) is converted and output according to the corresponding format specification in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The formatting is consistent with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> family of functions; see [Format Specification Fields: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md). If copying occurs between strings that overlap, the behavior is undefined.  
  
 If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is [_TRUNCATE](../vs140/_truncate.md), then <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> writes as much of the string as will fit in <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> while leaving room for a terminating null. If the entire string (with terminating null) fits in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> returns the number of characters written (not including the terminating null); otherwise, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> returns -1 to indicate that truncation occurred.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is not a user-defined string.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>; the pointer arguments to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are wide-character strings. Detection of encoding errors in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> might differ from that in <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, like <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, writes output to a string rather than to a destination of type <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 The versions of these functions with the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **count = 8; 10-byte buffer**  
 **new contents of dest: '<<\<121>>'**  
**count = 9; 10-byte buffer**  
 **new contents of dest: '<<\<121>>>'**  
**count = 10; 10-byte buffer**  
 **new contents of dest: '<<\<121>>>'**  
**Destination buffer too small:**  
**count = 10; 10-byte buffer**  
**Invalid parameter handler invoked: ("Buffer too small", 0)**  
 **new contents of dest: ''**  
**Truncation examples:**  
**10-byte buffer; truncation semantics**  
 **new contents of dest: '<<\<1221>>'**  
 **truncation did occur**  
**10-byte buffer; truncation semantics**  
 **new contents of dest: '<<\<121>>>'**  
 **truncation did not occur**  
**Secure template overload example:**  
**Invalid parameter handler invoked: ("Buffer too small", 0)**  
 **new contents of dest: ''**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)