---
title: "_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l"
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
  - "_wcsnicmp"
  - "_strnicmp_l"
  - "_wcsnicmp_l"
  - "_strnicmp"
  - "_mbsnicmp"
  - "_mbsnicmp_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "wcsnicmp_l"
  - "_strnicmp"
  - "_ftcsnicmp"
  - "mbsnicmp_l"
  - "_ftcsncicmp"
  - "mbsnicmp"
  - "_tcsncicmp"
  - "_mbsnicmp"
  - "_tcsnicmp"
  - "strnicmp_l"
  - "_wcsnicmp"
  - "_wcsnicmp_l"
  - "CORECRT_WSTRING/_wcsnicmp"
  - "CORECRT_WSTRING/_wcsnicmp_l"
  - "string/_strnicmp"
  - "string/_strnicmp_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcsnicmp function"
  - "_tcsncicmp function"
  - "_mbsnicmp_l function"
  - "mbsnicmp_l function"
  - "wcsnicmp_l function"
  - "wcsnicmp function"
  - "string comparison [C++], lowercase"
  - "ftcsnicmp function"
  - "strnicmp_l function"
  - "strncmp function"
  - "_strnicmp function"
  - "strings [C++], comparing characters of"
  - "_wcsnicmp_l function"
  - "tcsncicmp function"
  - "string comparison [C++], strncmp function"
  - "_mbsnicmp function"
  - "ftcsncicmp function"
  - "_tcsnicmp function"
  - "_ftcsncicmp function"
  - "_strnicmp_l function"
  - "_ftcsnicmp function"
  - "characters [C++], comparing"
  - "mbsnicmp function"
  - "_wcsnicmp function"
ms.assetid: df6e5037-4039-4c85-a0a6-21d4ef513966
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l
Compares the specified number of characters of two strings without regard to case.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Null-terminated strings to compare.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number of characters to compare.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Indicates the relationship between the substrings, as follows.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> substring is less than <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> substring.|  
|0|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> substring is identical to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> substring.|  
|> 0|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> substring is greater than <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> substring.|  
  
 On a parameter validation error, these functions return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which is defined in \<string.h> and \<mbstring.h>.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function ordinally compares, at most, the first <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The comparison is performed without regard to case by converting each character to lowercase. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a case-insensitive version of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The comparison ends if a terminating null character is reached in either string before <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> characters are compared. If the strings are equal when a terminating null character is reached in either string before <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> characters are compared, the shorter string is lesser.  
  
 The characters from 91 to 96 in the ASCII table ('[', '\\', ']', '^', '_', and '\<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>stricmp<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>_wcsnicmp<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>_mbsnicmp<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>_strnicmp<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>_wcsnicmp<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>_mbsnicmp<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>_mbsnicmp<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>_NLSCMPERROR<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>_l<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>_l<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>locale<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>string1<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>string2<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>_NLSCMPERROR<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>errno<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>EINVAL<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>_tcsncicmp<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>_strnicmp<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>_mbsnicmp<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>_wcsnicmp<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>_tcsnicmp<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>_strnicmp<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>_mbsnbicmp<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>_wcsnicmp<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>_tcsncicmp_l<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>_strnicmp_l<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>_mbsnicmp_l<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>_wcsnicmp_l<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>_strnicmp<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>_strnicmp_l<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>_wcsnicmp<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>_wcsnicmp_l<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>_mbsnicmp<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>_mbsnicmp_l`|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 See the example for [strncmp](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md).  
  
## .NET Framework Equivalent  
 [System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [strcat, wcscat, _mbscat](../vs140/strcat--wcscat--_mbscat.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)