---
title: "_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l"
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
  - "_stricmp_l"
  - "_mbsicmp"
  - "_wcsicmp"
  - "_mbsicmp_l"
  - "_stricmp"
  - "_wcsicmp_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "ntdll.dll"
  - "ntoskrnl.exe"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ftcsicmp"
  - "_stricmp"
  - "wcsicmp_l"
  - "_wcsicmp"
  - "_tcsicmp"
  - "_strcmpi"
  - "stricmp_l"
  - "_mbsicmp"
  - "_fstricmp"
  - "mbsicmp_l"
  - "mbsicmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcsicmp function"
  - "_stricmp_l function"
  - "fstricmp function"
  - "_tcsicmp function"
  - "ftcsicmp function"
  - "string comparison [C++], lowercase"
  - "_wcsicmp_l function"
  - "_fstricmp function"
  - "strings [C++], comparing"
  - "mbsicmp function"
  - "_ftcsicmp function"
  - "_mbsicmp_l function"
  - "wcsicmp_l function"
  - "_stricmp function"
  - "_mbsicmp function"
  - "tcsicmp function"
  - "stricmp_l function"
  - "mbsicmp_l function"
  - "_strcmpi function"
ms.assetid: 0e1ee515-0d75-435a-a445-8875d4669b50
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l
Performs a case-insensitive comparison of strings.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated strings to compare.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 The return value indicates the relation of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> as follows.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> less than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|0|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> identical to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|> 0|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
  
 On an error, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which is defined in \<string.h> and \<mbstring.h>.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function ordinally compares <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> after converting each character to lowercase, and returns a value indicating their relationship. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in that the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> comparison is only affected by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, which determines which characters are upper and lowercase. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function compares strings according to both the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> categories of the locale, which includes both the case and the collation order. For more information about the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> category, see [setlocale](../vs140/setlocale--_wsetlocale.md) and [Locale Categories](../vs140/locale-categories.md). The versions of these functions without the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> suffix use the current locale for locale-dependent behavior. The versions with the suffix are identical except that they use the locale passed in instead. If the locale has not been set, the C locale is used. For more information, see [Locale](../vs140/locale.md).  
  
> [!NOTE]
>  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. They can be used interchangeably but <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is the preferred standard.  
  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function is equivalent to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and is provided for backward compatibility only.  
  
 Because <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> does lowercase comparisons, it may result in unexpected behavior.  
  
 To illustrate when case conversion by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> affects the outcome of a comparison, assume that you have the two strings JOHNSTON and JOHN_HENRY. The string JOHN_HENRY will be considered less than JOHNSTON because the "_" has a lower ASCII value than a lowercase S. In fact, any character that has an ASCII value between 91 and 96 will be considered less than any letter.  
  
 If the [strcmp](../vs140/strcmp--wcscmp--_mbscmp.md) function is used instead of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, JOHN_HENRY will be greater than JOHNSTON.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are wide-character and multibyte-character versions of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. The arguments and return value of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are wide-character strings; those of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> are multibyte-character strings. <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the current multibyte code page and returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> on an error. For more information, see [Code Pages](../vs140/code-pages.md). These three functions behave identically otherwise.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> behave identically except that <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> does not convert its arguments to lowercase before comparing them. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> behave identically except that <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> does not convert its arguments to lowercase before comparing them.  
  
 You will need to call [setlocale](../vs140/setlocale--_wsetlocale.md) for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> to work with Latin 1 characters. The C locale is in effect by default, so, for example, ä will not compare equal to Ä. Call <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> with any locale other than the C locale before the call to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. The following sample demonstrates how <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is sensitive to the locale:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An alternative is to call [_create_locale](../vs140/_create_locale--_wcreate_locale.md) and pass the returned locale object as a parameter to <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
 All of these functions validate their parameters. If either <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> are null pointers, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions return <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Compare strings:**  
 **The quick brown dog jumps over the lazy fox**  
 **The QUICK brown dog jumps over the lazy fox**  
 **strcmp:   String 1 is greater than string 2**  
 **_stricmp:  String 1 is equal to string 2**   
## .NET Framework Equivalent  
 [System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [_memicmp, _memicmp_l](../vs140/_memicmp--_memicmp_l.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)