---
title: "strncmp, wcsncmp, _mbsncmp, _mbsncmp_l"
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
  - "strncmp"
  - "_mbsncmp"
  - "wcsncmp"
  - "_mbsncmp_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "ntdll.dll"
  - "ntoskrnl.exe"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ftcsnccmp"
  - "_ftcsncmp"
  - "_tcsncmp"
  - "_tcsnccmp"
  - "strncmp"
  - "_mbsncmp"
  - "wcsncmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tcsnccmp function"
  - "ftcsncmp function"
  - "wcsncmp function"
  - "_ftcsncmp function"
  - "_mbsncmp function"
  - "tcsncmp function"
  - "mbsncmp function"
  - "_mbsncmp_l function"
  - "mbsncmp_l function"
  - "strncmp function"
  - "strings [C++], comparing characters of"
  - "string comparison [C++], strncmp function"
  - "_tcsncmp function"
  - "tcsnccmp function"
  - "ftcsnccmp function"
  - "characters [C++], comparing"
  - "_ftcsnccmp function"
ms.assetid: 2fdbf4e6-77da-4b59-9086-488f6066b8af
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strncmp, wcsncmp, _mbsncmp, _mbsncmp_l
Compares up to the specified count of characters of two strings.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Strings to compare.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters to compare.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 The return value indicates the relation of the substrings of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as follows.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> substring less than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> substring|  
|0|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> substring identical to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> substring|  
|> 0|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> substring greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> substring|  
  
 On a parameter validation error, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, which is defined in \<string.h> and \<mbstring.h>.  
  
## Remarks  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function performs an ordinal comparison of at most the first <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> characters in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and returns a value indicating the relationship between the substrings. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a case-sensitive version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are case-sensitive versions of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. The arguments of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are multibyte-character strings. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to a multibyte code page and returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> on an error.  
  
 Also, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> validate parameters. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> do not validate their parameters. These functions behave identically otherwise.  
  
 The comparison behavior of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is affected by the setting of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> category setting of the locale. This controls detection of leading and trailing bytes of multibyte characters. For more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> function uses the current locale for this locale-dependent behavior. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> function is identical except that it uses the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> parameter instead. For more information, see [Locale](../vs140/locale.md). If the locale is a single-byte locale, the behavior of these functions is identical to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Maps to macro or inline function|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Maps to macro or inline function|  
|**not applicable**|**not applicable**|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|**not applicable**|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Compare strings:**  
 **The quick brown dog jumps over the lazy fox**  
 **The QUICK brown fox jumps over the lazy dog**  
**Function:   strncmp (first 10 characters only)**  
**Result:      String 1 is greater than string 2**  
**Function:   strnicmp _strnicmp (first 10 characters only)**  
**Result:      String 1 is equal to string 2**   
## .NET Framework Equivalent  
 [System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_mbsnbicmp, _mbsnbicmp_l](../vs140/_mbsnbicmp--_mbsnbicmp_l.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)