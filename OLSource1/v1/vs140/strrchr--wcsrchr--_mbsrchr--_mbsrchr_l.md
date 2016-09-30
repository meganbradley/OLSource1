---
title: "strrchr, wcsrchr, _mbsrchr, _mbsrchr_l"
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
  - "strrchr"
  - "wcsrchr"
  - "_mbsrchr"
  - "_mbsrchr_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcsrchr"
  - "_ftcsrchr"
  - "strrchr"
  - "wcsrchr"
  - "_mbsrchr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbsrchr function"
  - "tcsrchr function"
  - "mbsrchr_l function"
  - "characters [C++], scanning for"
  - "ftcsrchr function"
  - "_tcsrchr function"
  - "strings [C++], scanning"
  - "mbsrchr function"
  - "strrchr function"
  - "scanning strings"
  - "wcsrchr function"
  - "_ftcsrchr function"
  - "_mbsrchr_l function"
ms.assetid: 75cf2664-758e-49bb-bf6b-8a139cd474d2
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strrchr, wcsrchr, _mbsrchr, _mbsrchr_l
Scans a string for the last occurrence of a character.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Null-terminated string to search.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Character to be located.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the last occurrence of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not found.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function finds the last occurrence of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (converted to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The search includes the terminating null character.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are multibyte-character strings.  
  
 In C, these functions take a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> pointer for the first argument. In C++, two overloads are available. The overload taking a pointer to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns a pointer to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; the version that takes a pointer to non-<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns a pointer to non-<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The macro _CONST_CORRECT_OVERLOADS is defined if both the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> versions of these functions are available. If you require the non-<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> behavior for both C++ overloads, define the symbol _CONST_RETURN.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> returns 0. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> do not validate their parameters. These three functions behave identically otherwise.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> category setting of the locale; for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions without the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|**n/a**|**n/a**|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|**n/a**|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more information about compatibility, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 For an example of using <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, see [strchr](../vs140/strchr--wcschr--_mbschr--_mbschr_l.md).  
  
## .NET Framework Equivalent  
 [System::String::LastIndexOf](https://msdn.microsoft.com/en-us/library/system.string.lastindexof.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strchr, wcschr, _mbschr, _mbschr_l](../vs140/strchr--wcschr--_mbschr--_mbschr_l.md)   
 [strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l](../vs140/strpbrk--wcspbrk--_mbspbrk--_mbspbrk_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)