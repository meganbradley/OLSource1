---
title: "strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat, _mbsncat_l"
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
  - "strncat"
  - "_strncat_l"
  - "_mbsncat"
  - "_mbsncat_l"
  - "wcsncat"
  - "wcsncat_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcsncat_l"
  - "_wcsncat_l"
  - "_tcsnccat_l"
  - "_mbsncat"
  - "_strncat_l"
  - "strncat"
  - "_tcsnccat"
  - "_mbsncat_l"
  - "_ftcsncat"
  - "wcsncat"
  - "_tcsncat"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "concatenating strings"
  - "ftcsncat function"
  - "tcsncat_l function"
  - "_tcsnccat_l function"
  - "_tcsncat function"
  - "strncat function"
  - "_ftcsncat function"
  - "mbsncat function"
  - "mbsncat_l function"
  - "strings [C++], appending"
  - "wcsncat function"
  - "tcsnccat function"
  - "tcsnccat_l function"
  - "_tcsnccat function"
  - "string concatenation [C++]"
  - "appending strings"
  - "characters [C++], appending to strings"
  - "_mbsncat function"
  - "_tcsncat_l function"
  - "_mbsncat_l function"
  - "tcsncat function"
ms.assetid: de67363b-68c6-4ca5-91e3-478610ad8159
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat, _mbsncat_l
Appends characters of a string. More secure versions of these functions are available, see [strncat_s, wcsncat_s, _mbsncat_s](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md) .  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated destination string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Null-terminated source string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Number of characters to append.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the destination string. No return value is reserved to indicate an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function appends, at most, the first <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The initial character of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> overwrites the terminating null character of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If a null character appears in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> characters are appended, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> appends all characters from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, up to the null character. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is greater than the length of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the length of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is used in place of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The all cases, the resulting string is terminated with a null character. If copying takes place between strings that overlap, the behavior is undefined.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does not check for sufficient space in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; it is therefore a potential cause of buffer overruns. Keep in mind that <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> limits the number of characters appended; it is not a limit on the size of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. See the example below. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. The string arguments and return value of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are multibyte-character strings. These three functions behave identically otherwise.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, these functions have template overloads. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> have no locale dependence and are not meant to be called directly. They are provided for internal use by <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Note that <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> caused a buffer overrun.  
  
## .NET Framework Equivalent  
 [System::String::Concat](https://msdn.microsoft.com/en-us/library/system.string.concat.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)