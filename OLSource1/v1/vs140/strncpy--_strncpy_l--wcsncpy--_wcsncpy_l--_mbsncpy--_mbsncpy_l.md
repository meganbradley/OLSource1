---
title: "strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l"
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
  - "strncpy"
  - "_strncpy_l"
  - "_mbsncpy"
  - "wcsncpy"
  - "_mbsncpy_l"
  - "_wcsncpy_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fstrncpy"
  - "strncpy"
  - "_ftcsncpy"
  - "_tcsnccpy_l"
  - "_tcsnccpy"
  - "_mbsncpy"
  - "wcsncpy"
  - "_tcsncpy"
  - "_strncpy_l"
  - "_mbsncpy_l"
  - "_wcsncpy_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcsncpy_l function"
  - "characters [C++], copying"
  - "mbsncpy_l function"
  - "strncpy_l function"
  - "wcsncpy function"
  - "tcsnccpy function"
  - "ftcsncpy function"
  - "copying characters of strings"
  - "_wcsncpy_l function"
  - "_tcsnccpy function"
  - "_tcsnccpy_l function"
  - "strncpy function"
  - "_tcsncpy function"
  - "mbsncpy function"
  - "_fstrncpy function"
  - "_mbsncpy_l function"
  - "tcsncpy_l function"
  - "tcsnccpy_l function"
  - "fstrncpy function"
  - "strings [C++], copying"
  - "_ftcsncpy function"
  - "_tcsncpy_l function"
  - "_mbsncpy function"
  - "tcsncpy function"
  - "_strncpy_l function"
ms.assetid: ac4345a1-a129-4f2f-bb8a-373ec58ab8b0
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l
Copy characters of one string to another. More secure versions of these functions are available; see [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Destination string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Source string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of characters to be copied.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. No return value is reserved to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function copies the initial <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is less than or equal to the length of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, a null character is not appended automatically to the copied string. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is greater than the length of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the destination string is padded with null characters up to length <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The behavior of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is undefined if the source and destination strings overlap.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> does not check for sufficient space in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; this makes it a potential cause of buffer overruns. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument limits the number of characters copied; it is not a limit on the size of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. See the following example. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> pointer, or if <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is less than or equal to zero, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> vary accordingly. These six functions behave identically otherwise.  
  
 The versions of these functions with the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> have no locale dependence; they are provided just for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and are not intended to be called directly.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional platform compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and how it can be misused to cause program bugs and security issues. The compiler generates a warning for each call to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> similar to **crt_strncpy_x86.c(15) : warning C4996: 'strncpy': This function or variable may be unsafe. Consider using strncpy_s instead. To disable deprecation, use _CRT_SECURE_NO_WARNINGS. See online help for details.**  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Output  
  
  **ZZ**  
**aa bb dd**  
**this is a very long test**  
**dogs like cats**  
**dogs like to chase cars.**  
**Buffer overrun: s = 'ars.' (should be 'test')** The layout of automatic variables and the level of error detection and code protection can vary with changed compiler settings. This example may have different results when built in other compilation environments or with other compiler options.  
  
## .NET Framework Equivalent  
 [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbcpy, _mbsnbcpy_l](../vs140/_mbsnbcpy--_mbsnbcpy_l.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)   
 [strcpy_s, wcscpy_s, _mbscpy_s](../vs140/strcpy_s--wcscpy_s--_mbscpy_s.md)