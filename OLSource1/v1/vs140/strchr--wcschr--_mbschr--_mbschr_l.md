---
title: "strchr, wcschr, _mbschr, _mbschr_l"
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
  - "strchr"
  - "wcschr"
  - "_mbschr_l"
  - "_mbschr"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "_ftcschr"
  - "strchr"
  - "wcschr"
  - "_tcschr"
  - "_mbschr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strings [C++], searching"
  - "mbschr function"
  - "_ftcschr function"
  - "_mbschr function"
  - "characters [C++], finding in strings"
  - "_mbschr_l function"
  - "ftcschr function"
  - "wcschr function"
  - "strchr function"
  - "_tcschr function"
  - "tcschr function"
  - "mbschr_l function"
ms.assetid: 2639905d-e983-43b7-b885-abef32cfac43
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strchr, wcschr, _mbschr, _mbschr_l
Finds a character in a string, by using the current locale or a specified LC_CTYPE conversion-state category.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated source string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Character to be located.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these functions returns a pointer to the first occurrence of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not found.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function finds the first occurrence of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, or it returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not found. The null terminating character is included in the search.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are multibyte-character strings. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> recognizes multibyte-character sequences. Also, if the string is a null pointer, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> do not validate their parameters. These three functions behave identically otherwise.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category setting of the locale; for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions without the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C, these functions take a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> pointer for the first argument. In C++, two overloads are available. The overload taking a pointer to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> returns a pointer to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>; the version that takes a pointer to non-<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> returns a pointer to non-<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. The macro _CONST_CORRECT_OVERLOADS is defined if both the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>39\</CodeContentPlaceHolder> versions of these functions are available. If you require the non-<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> behavior for both C++ overloads, define the symbol _CONST_RETURN.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|**_n/a**|**n/a**|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|**n/a**|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more information about compatibility, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **String to be searched:**  
 **The quick brown dog jumps over the lazy fox**  
 **1         2         3         4         5**  
 **12345678901234567890123456789012345678901234567890**  
**Search char:   r**  
**Result:   first r found at position 12**  
**Result:   last r found at position 30**   
## .NET Framework Equivalent  
 [System::String::IndexOf](https://msdn.microsoft.com/en-us/library/system.string.indexof.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat, _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l](../vs140/strpbrk--wcspbrk--_mbspbrk--_mbspbrk_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strstr, wcsstr, _mbsstr, _mbsstr_l](../vs140/strstr--wcsstr--_mbsstr--_mbsstr_l.md)