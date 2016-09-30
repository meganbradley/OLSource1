---
title: "_strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l"
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
  - "_mbsnicoll_l"
  - "_mbsnicoll"
  - "_wcsnicoll_l"
  - "_strnicoll"
  - "_strnicoll_l"
  - "_wcsnicoll"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcshicoll_l"
  - "_ftcsncicoll"
  - "strnicoll_l"
  - "_wcsnicoll"
  - "mbsnicoll_l"
  - "_strnicoll"
  - "mbsnicoll"
  - "_ftcsnicoll"
  - "wcsnicoll"
  - "_tcsnicoll"
  - "_mbsnicoll"
  - "strinicoll"
  - "_tcsncicoll"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "code pages, using for string comparisons"
  - "ftcsncicoll function"
  - "mbsnicoll_l function"
  - "_ftcsnicoll function"
  - "mbsnicoll function"
  - "_tcsnicoll function"
  - "_wcsnicoll_l function"
  - "_mbsnicoll function"
  - "tcsncicoll function"
  - "strnicoll function"
  - "_ftcsncicoll function"
  - "wcsnicoll_l function"
  - "_mbsnicoll_l function"
  - "_tcsncicoll function"
  - "strnicoll_l function"
  - "wcsnicoll function"
  - "_strnicoll_l function"
  - "_wcsnicoll function"
  - "ftcsnicoll function"
  - "strings [C++], comparing by code page"
  - "tcsnicoll function"
  - "_strnicoll function"
ms.assetid: abf0c569-725b-428d-9ff2-924f430104b4
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strnicoll, _wcsnicoll, _mbsnicoll, _strnicoll_l, _wcsnicoll_l, _mbsnicoll_l
Compares strings by using locale-specific information.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Null-terminated strings to compare  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of characters to compare  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Each of these functions returns a value indicating the relationship of the substrings of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>*,* as follows.  
  
|Return value|Relationship of string1 to string2|  
|------------------|----------------------------------------|  
|< 0|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> less than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|0|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> identical to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|> 0|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> greater than <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
  
 Each of these functions returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. To use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, include either STRING.H or MBSTRING.H. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can fail if either <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> contains wide-character codes outside the domain of the collating sequence. When an error occurs, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> may set <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. To check for an error on a call to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, set <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to 0 and then check <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> after calling <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>**.**  
  
## Remarks  
 Each of these functions performs a case-insensitive comparison of the first <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> characters in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> according to the code page. These functions should be used only when there is a difference between the character set order and the lexicographic character order in the code page and this difference is of interest for the string comparison. The versions of these functions without the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> suffix use the current locale and code page. The versions with the<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 All of these functions validate their parameters. If either <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is a null pointer, or if count is greater than <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions return <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>**.**  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|[_mbsnbicoll](../vs140/_mbsnbcoll--_mbsnbcoll_l--_mbsnbicoll--_mbsnbicoll_l.md)|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<wchar.h> or \<string.h>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 [System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [localeconv](../vs140/localeconv.md)   
 [_mbsnbcoll, _mbsnbcoll_l, _mbsnbicoll, _mbsnbicoll_l](../vs140/_mbsnbcoll--_mbsnbcoll_l--_mbsnbicoll--_mbsnbicoll_l.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../vs140/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)