---
title: "_strspnp, _wcsspnp, _mbsspnp, _mbsspnp_l"
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
  - "_mbsspnp"
  - "_wcsspnp"
  - "_mbsspnp_l"
  - "_strspnp"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcsspnp"
  - "_mbsspnp"
  - "strspnp"
  - "_ftcsspnp"
  - "_mbsspnp_l"
  - "wcsspnp"
  - "mbsspnp_l"
  - "_wcsspnp"
  - "_strspnp"
  - "mbsspnp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_strspnp function"
  - "_wcsspnp function"
  - "_mbsspnp_l function"
  - "strspnp function"
  - "mbsspnp function"
  - "wcsspnp function"
  - "_mbsspnp function"
  - "mbsspnp_l function"
  - "_tcsspnp function"
  - "tcsspnp function"
ms.assetid: 1ce18100-2edd-4c3b-af8b-53f204d80233
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strspnp, _wcsspnp, _mbsspnp, _mbsspnp_l
Returns a pointer to the first character in a given string that is not in another given string.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated string to search.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Null-terminated character set.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> return a pointer to the first character in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that does not belong to the set of characters in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>*.* Each of these functions returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> consists entirely of characters from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>*.* For each of these routines, no return value is reserved to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function returns a pointer to the multibyte character that is the first character in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that does not belong to the set of characters in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the [multibyte code page](../vs140/code-pages.md) currently in use. The search does not include terminating null characters.  
  
 If either <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a null pointer, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> are single-byte character and wide-character versions of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> behave identically to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> otherwise; they are provided only for this mapping and should not be used for any other reason. For more information, see [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md) and [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is identical except that it uses the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<tchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)   
 [strncat_s, _strncat_s_l, wcsncat_s, _wcsncat_s_l, _mbsncat_s, _mbsncat_s_l](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, _mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)