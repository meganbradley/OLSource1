---
title: "snprintf, _snprintf, _snprintf_l, _snwprintf, _snwprintf_l"
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
  - "_snwprintf"
  - "_snprintf"
  - "_snprintf_l"
  - "_snwprintf_l"
  - "snprintf"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "ntoskrnl.exe"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "ntdll.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_snprintf"
  - "snprintf_l"
  - "snwprintf_l"
  - "sntprintf"
  - "snprintf"
  - "_sntprintf"
  - "_sntprintf_l"
  - "sntprintf_l"
  - "snwprintf"
  - "_snprintf_l"
  - "_snwprintf"
  - "_snwprintf_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "snwprintf_l function"
  - "sntprintf_l function"
  - "snprintf_l function"
  - "_snwprintf_l function"
  - "_sntprintf_l function"
  - "_snwprintf function"
  - "_snprintf function"
  - "_sntprintf function"
  - "_snprintf_l function"
  - "snwprintf function"
  - "snprintf function"
  - "sntprintf function"
  - "formatted text [C++]"
ms.assetid: 5976c9c8-876e-4ac9-a515-39f3f7fd0925
caps.latest.revision: 37
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# snprintf, _snprintf, _snprintf_l, _snwprintf, _snwprintf_l
Writes formatted data to a string. More secure versions of these functions are available; see [_snprintf_s, _snprintf_s_l, _snwprintf_s, _snwprintf_s_l](../vs140/_snprintf_s--_snprintf_s_l--_snwprintf_s--_snwprintf_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Storage location for the output.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Maximum number of characters to store.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Format-control string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional arguments.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
 For more information, see [Format Specification Syntax: printf and wprintf Functions](../vs140/format-specification-syntax--printf-and-wprintf-functions.md).  
  
## Return Value  
 Let <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> be the length of the formatted data string, not including the terminating null. Both <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are in bytes for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, wide characters for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 For all functions, if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> < <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> characters are stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, a null-terminator is appended, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is returned.  
  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function truncates the output when <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is greater than or equal to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, by placing a null-terminator at <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The value returned is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the number of characters that would have been output if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> was large enough. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function returns a negative value if an encoding error occurs.  
  
 For all functions other than <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> characters are stored in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, no null-terminator is appended, and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is returned. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> > <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> characters are stored in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, no null-terminator is appended, and a negative value is returned.  
  
 If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is a null pointer and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is zero, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is returned as the count of characters required to format the output, not including the terminating null. To make a successful call with the same <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameters, allocate a buffer holding at least <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> + 1 characters.  
  
 If <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is a null pointer and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is nonzero, or if <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 For information about these and other error codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> function and the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> family of functions format and store <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or fewer characters in <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> function always stores a terminating null character, truncating the output if necessary. The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> family of functions only appends a terminating null character if the formatted string length is strictly less than <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> characters. Each <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> (if any) is converted and is output according to the corresponding format specification in <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. The format consists of ordinary characters and has the same form and function as the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> argument for [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md). If copying occurs between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is not a user-defined string. Because the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> functions do not guarantee NULL termination—in particular, when the return value is <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>—make sure that they are followed by code that adds the null terminator. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 Beginning with the UCRT in Visual Studio 2015 and Windows 10, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is no longer identical to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> function behavior is now C99 standard compliant.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>; the pointer arguments to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> are wide-character strings. Detection of encoding errors in <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> might differ from that in <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, just like <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, writes output to a string instead of a destination of type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
 The versions of these functions that have the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead of the current thread locale.  
  
 In C++, these functions have template overloads that invoke their newer, more secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|\<stdio.h>|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|\<stdio.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output:**  
 **String: computer**  
 **Character: l**  
 **Integer: 35**  
 **Real: 1.732053**  
**character count = 69**   
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [sprintf, swprintf](../vs140/sprintf--_sprintf_l--swprintf--_swprintf_l--__swprintf_l.md)   
 [fprintf, fwprintf](../vs140/fprintf--_fprintf_l--fwprintf--_fwprintf_l.md)   
 [printf, wprintf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [sscanf, swscanf](../vs140/sscanf--_sscanf_l--swscanf--_swscanf_l.md)   
 [vprintf Functions](../vs140/vprintf-functions.md)