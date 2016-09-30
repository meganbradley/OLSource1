---
title: "strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l"
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
  - "_mbspbrk"
  - "wcspbrk"
  - "_mbspbrk_l"
  - "strpbrk"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fstrpbrk"
  - "_mbspbrk"
  - "strpbrk"
  - "_tcspbrk"
  - "_ftcspbrk"
  - "wcspbrk"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fstrpbrk function"
  - "_ftcspbrk function"
  - "_mbspbrk_l function"
  - "strpbrk function"
  - "_fstrpbrk function"
  - "mbspbrk function"
  - "characters [C++], scanning strings"
  - "_tcspbrk function"
  - "wcspbrk function"
  - "ftcspbrk function"
  - "character sets [C++], scanning strings for characters"
  - "strings [C++], scanning"
  - "tcspbrk function"
  - "_mbspbrk function"
  - "mbspbrk_l function"
ms.assetid: 80b504f7-a167-4dde-97ad-4ae3000dc810
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l
Scans strings for characters in specified character sets.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated, searched string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated character set.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the first occurrence of any character from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer if the two string arguments have no characters in common.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function returns a pointer to the first occurrence of a character in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that belongs to the set of characters in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The search does not include the terminating null character.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> are multibyte-character strings.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> do not validate their parameters. These three functions behave identically otherwise.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is similar to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> except that <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> returns a pointer rather than a value of type [size_t](../vs140/standard-types.md).  
  
 In C, these functions take a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> pointer for the first argument. In C++, two overloads are available. The overload taking a pointer to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> returns a pointer to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>; the version that takes a pointer to non-<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> returns a pointer to non-<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The macro _CONST_CORRECT_OVERLOADS is defined if both the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> versions of these functions are available. If you require the non-<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> behavior for both C++ overloads, define the symbol _CONST_RETURN.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> category setting of the locale; for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions without the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the version with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> suffix is identical except that it uses the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|**n/a**|**n/a**|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|**n/a**|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more information about compatibility, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1: The 3 men and 2 boys ate 5 pigs**  
**2: 3 men and 2 boys ate 5 pigs**  
**3: 2 boys ate 5 pigs**  
**4: 5 pigs**   
## .NET Framework Equivalent  
 [System::String::IndexOfAny](https://msdn.microsoft.com/en-us/library/system.string.indexofany.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)   
 [strchr, wcschr, _mbschr, _mbschr_l](../vs140/strchr--wcschr--_mbschr--_mbschr_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)