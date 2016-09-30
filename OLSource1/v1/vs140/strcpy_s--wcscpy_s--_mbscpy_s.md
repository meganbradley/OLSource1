---
title: "strcpy_s, wcscpy_s, _mbscpy_s"
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
  - "wcscpy_s"
  - "_mbscpy_s"
  - "strcpy_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strcpy_s"
  - "_mbscpy_s"
  - "_tcscpy_s"
  - "wcscpy_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strcpy_s function"
  - "_tcscpy_s function"
  - "_mbscpy_s function"
  - "copying strings"
  - "strings [C++], copying"
  - "tcscpy_s function"
  - "wcscpy_s function"
ms.assetid: 611326f3-7929-4a5d-a465-a4683af3b053
caps.latest.revision: 43
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# strcpy_s, wcscpy_s, _mbscpy_s
Copies a string. These versions of [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Location of the destination string buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the destination string buffer in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> units for narrow and multi-byte functions, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> units for wide functions.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Null-terminated source string buffer.  
  
## Return Value  
 Zero if successful; otherwise, an error.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|----------------------|------------------------|-----------------|------------------|----------------------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|not modified|  
|any|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>[0] set to 0|  
|any|0, or too small|any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>[0] set to 0|  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function copies the contents in the address of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, including the terminating null character, to the location that's specified by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The destination string must be large enough to hold the source string and its terminating null character. The behavior of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is undefined if the source and destination strings overlap.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is the multibyte-character version. The arguments and return value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a null pointer, or if the destination string is too small, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is a null pointer, and they return <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> when the destination string is too small.  
  
 Upon successful execution, the destination string is always null-terminated.  
  
 In C++, use of these functions is simplified by template overloads that can infer buffer length automatically so that you don't have to specify a size argument, and they can automatically replace older, less-secure functions with their newer, more secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFE. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String = Hello world from strcpy_s and strcat_s!**   
## .NET Framework Equivalent  
 [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strncat_s, _strncat_s_l, wcsncat_s, _wcsncat_s_l, _mbsncat_s, _mbsncat_s_l](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)