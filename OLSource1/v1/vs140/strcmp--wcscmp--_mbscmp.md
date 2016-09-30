---
title: "strcmp, wcscmp, _mbscmp"
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
  - "wcscmp"
  - "_mbscmp"
  - "strcmp"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "_mbscmp"
  - "wcscmp"
  - "strcmp"
  - "_tcscmp"
  - "_ftcscmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcscmp function"
  - "strcmp function"
  - "strings [C++], comparing"
  - "mbscmp function"
  - "string comparison [C++]"
  - "_mbscmp function"
  - "wcscmp function"
  - "_tcscmp function"
  - "_ftcscmp function"
  - "ftcscmp function"
ms.assetid: 5d216b57-7a5c-4cb3-abf0-0f4facf4396d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strcmp, wcscmp, _mbscmp
Compare strings.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Null-terminated strings to compare.  
  
## Return Value  
 The return value for each of these functions indicates the ordinal relation of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Value|Relationship of string1 to string2|  
|-----------|----------------------------------------|  
|< 0|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|0|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|> 0|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
  
 On a parameter validation error, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, which is defined in \<string.h> and \<mbstring.h>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function performs an ordinal comparison of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and returns a value that indicates their relationship. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> are, respectively, wide-character and multibyte-character versions of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the current multibyte code page and returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> on an error. For more information, see [Code Pages](../vs140/code-pages.md). Also, if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> do not validate their parameters. These three functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> functions differ from the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> functions in that <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> comparisons are ordinal, and are not affected by locale. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> compares strings lexicographically by using the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> category of the current locale. For more information about the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> category, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md).  
  
 In the "C" locale, the order of characters in the character set (ASCII character set) is the same as the lexicographic character order. However, in other locales, the order of characters in the character set may differ from the lexicographic order. For example, in certain European locales, the character 'a' (value 0x61) comes before the character 'ä' (value 0xE4) in the character set, but the character 'ä' comes in front of the character 'a' lexicographically.  
  
 In locales for which the character set and the lexicographic character order differ, you can use <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> for lexicographic comparison of strings. Alternatively, you can use <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> on the original strings, and then use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> on the resulting strings.  
  
 The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> functions are case-sensitive. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> compare strings by first converting them to their lowercase forms. Two strings that contain characters that are located between 'Z' and 'a' in the ASCII table ('[', '<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>', ']', '<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>', '<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>', and '<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>"ABCDE"<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>"ABCD^"<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>"abcde"<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>"abcd^"<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>"ABCDE"<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>"ABCD^"<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>strcmp<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>wcscmp<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>_mbscmp`|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Compare strings:**  
 **The quick brown dog jumps over the lazy fox**  
 **The QUICK brown dog jumps over the lazy fox**  
 **strcmp:   String 1 is greater than string 2**  
 **_stricmp:  String 1 is equal to string 2**   
## .NET Framework Equivalent  
 [System::String::CompareOrdinal](https://msdn.microsoft.com/en-us/library/system.string.compareordinal.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [_memicmp, _memicmp_l](../vs140/_memicmp--_memicmp_l.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../vs140/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)