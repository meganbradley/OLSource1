---
title: "strstr, wcsstr, _mbsstr, _mbsstr_l"
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
  - "_mbsstr"
  - "wcsstr"
  - "_mbsstr_l"
  - "strstr"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "_fstrstr"
  - "_ftcsstr"
  - "strstr"
  - "wcsstr"
  - "_mbsstr"
  - "_tcsstr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strings [C++], searching"
  - "mbsstr function"
  - "_ftcsstr function"
  - "ftcsstr function"
  - "fstrstr function"
  - "_tcsstr function"
  - "substrings, finding"
  - "mbsstr_l function"
  - "tcsstr function"
  - "_mbsstr function"
  - "wcsstr function"
  - "_fstrstr function"
  - "_mbsstr_l function"
  - "strstr function"
ms.assetid: 03d70c3f-2473-45cb-a5f8-b35beeb2748a
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstr, wcsstr, _mbsstr, _mbsstr_l
Returns a pointer to the first occurrence of a search string in a string.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated string to search.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated string to search for.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Returns a pointer to the first occurrence of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> does not appear in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> points to a string of zero length, the function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function returns a pointer to the first occurrence of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The search does not include terminating null characters. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is the wide-character version of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is the multibyte-character version. The arguments and return value of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are multibyte-character strings. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and returns 0. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> do not validate their parameters. These three functions behave identically otherwise.  
  
> [!IMPORTANT]
>  These functions might incur a threat from a buffer overrun problem. Buffer overrun problems can be used to attack a system because they can allow the execution of arbitrary code, which can cause an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 In C, these functions take a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> pointer for the first argument. In C++, two overloads are available. The overload that takes a pointer to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> returns a pointer to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>; the version that takes a pointer to non-<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> returns a pointer to non-<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The macro _CONST_CORRECT_OVERLOADS is defined if both the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and non-<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> versions of these functions are available. If you require the non-<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> behavior for both C++ overloads, define the symbol _CONST_RETURN.  
  
 The output value is affected by the locale-category setting of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>; for more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions that do not have the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions that have the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> suffix are identical except that they instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
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
 **String to be searched:**  
 **The quick brown dog jumps over the lazy fox**  
 **1         2         3         4         5**  
 **12345678901234567890123456789012345678901234567890**  
**lazy found at position 36**   
## .NET Framework Equivalent  
 [System::String::IndexOf](https://msdn.microsoft.com/en-us/library/system.string.indexof.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [strcspn, wcscspn, _mbscspn, _mbscspn_l](../vs140/strcspn--wcscspn--_mbscspn--_mbscspn_l.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l](../vs140/strpbrk--wcspbrk--_mbspbrk--_mbspbrk_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)   
 [basic_string::find](../vs140/basic_string--find.md)