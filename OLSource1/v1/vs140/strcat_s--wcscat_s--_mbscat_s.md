---
title: "strcat_s, wcscat_s, _mbscat_s"
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
  - "strcat_s"
  - "_mbscat_s"
  - "wcscat_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strcat_s"
  - "wcscat_s"
  - "_mbscat_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcscat_s function"
  - "strcat_s function"
  - "mbscat_s function"
  - "strings [C++], appending"
  - "_mbscat_s function"
  - "appending strings"
ms.assetid: 0f2f9901-c5c5-480b-98bc-f8f690792fc0
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strcat_s, wcscat_s, _mbscat_s
Appends a string. These versions of [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Null-terminated destination string buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the destination string buffer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated source string buffer.  
  
## Return Value  
 Zero if successful; an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|----------------------|------------------------|-----------------|------------------|----------------------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or unterminated|any|any|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|not modified|  
|any|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>[0] set to 0|  
|any|0, or too small|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>[0] set to 0|  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function appends <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and terminates the resulting string with a null character. The initial character of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> overwrites the terminating null character of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. The behavior of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is undefined if the source and destination strings overlap.  
  
 Note that the second parameter is the total size of the buffer, not the remaining size:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a null pointer, or is not null-terminated, or if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> pointer, or if the destination string is too small, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the code example in [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md).  
  
## .NET Framework Equivalent  
 [System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat, _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)