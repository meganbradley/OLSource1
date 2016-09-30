---
title: "strnlen, strnlen_s, wcsnlen, wcsnlen_s, _mbsnlen, _mbsnlen_l, _mbstrnlen, _mbstrnlen_l"
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
  - "wcsnlen"
  - "strnlen_s"
  - "_mbstrnlen"
  - "_mbsnlen_l"
  - "_mbstrnlen_l"
  - "strnlen"
  - "wcsnlen_s"
  - "_mbsnlen"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcsnlen"
  - "strnlen_s"
  - "_mbsnlen"
  - "_mbsnlen_l"
  - "_tcsnlen"
  - "_tcscnlen"
  - "_mbstrnlen_l"
  - "wcsnlen_s"
  - "_mbstrnlen"
  - "strnlen"
  - "_tcscnlen_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tcscnlen function"
  - "_mbstrnlen function"
  - "_mbsnlen_l function"
  - "lengths, strings"
  - "mbstrnlen function"
  - "mbsnlen_l function"
  - "_mbstrnlen_l function"
  - "_tcscnlen_l function"
  - "wcsnlen_l function"
  - "_tcsnlen function"
  - "_mbsnlen function"
  - "strnlen function"
  - "mbsnlen function"
  - "wcsnlen_s function"
  - "strnlen_s function"
  - "mbstrnlen_l function"
  - "wcsnlen function"
  - "string length"
  - "strnlen_l function"
ms.assetid: cc05ce1c-72ea-4ae4-a7e7-4464e56e5f80
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strnlen, strnlen_s, wcsnlen, wcsnlen_s, _mbsnlen, _mbsnlen_l, _mbstrnlen, _mbstrnlen_l
Gets the length of a string by using the current locale or one that has been passed in. These are more secure versions of [strlen, wcslen, _mbslen, _mbstrlen](../vs140/strlen--wcslen--_mbslen--_mbslen_l--_mbstrlen--_mbstrlen_l.md).  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Null-terminated string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The size of the string buffer.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 These functions return the number of characters in the string, not including the terminating null character. If there is no null terminator within the first <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bytes of the string (or wide characters for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>), then <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is returned to indicate the error condition; null-terminated strings have lengths that are strictly less than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> return -1 if the string contains an invalid multibyte character.  
  
## Remarks  
  
> [!NOTE]
>  <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not a replacement for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is intended to be used only to calculate the size of incoming untrusted data in a buffer of known size—for example, a network packet. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> calculates the length but doesn't walk past the end of the buffer if the string is unterminated. For other situations, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. (The same applies to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.)  
  
 Each of these functions returns the number of characters in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, not including the terminating null character. However, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> interpret the string as a single-byte character string and therefore, the return value is always equal to the number of bytes, even if the string contains multibyte characters. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are wide-character versions of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> respectively; the arguments for <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are wide-character strings and the count of characters are in wide-character units. Otherwise, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> behave identically, as do <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> do not validate their parameters. If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, an access violation occurs.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> validate their parameters. If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, the functions return 0.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> also validates its parameters. If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> generates an invalid parameter exception, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> sets <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> and returns -1.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> return the number of multibyte characters in a multibyte-character string. <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the multibyte code page that's currently in use or according to the locale that's passed in; it does not test for multibyte-character validity. <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> tests for multibyte-character validity and recognizes multibyte-character sequences. If the string that's passed to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> contains an invalid multibyte character, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that the ones that don't have the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior and the versions that have the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> suffix instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The length of a string is the number of characters**  
**excluding the terminating null.**  
 **Length: 82**   
**strnlen takes a maximum size. If the string is longer**  
**than the maximum size specified, the maximum size is**  
**returned rather than the actual size of the string.**  
 **Length: 100**    
## .NET Framework Equivalent  
 [System::String::Length](https://msdn.microsoft.com/en-us/library/system.string.length.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strncpy_s, _strncpy_s_l, wcsncpy_s, _wcsncpy_s_l, _mbsncpy_s, \__mbsncpy_s_l](../vs140/strncpy_s--_strncpy_s_l--wcsncpy_s--_wcsncpy_s_l--_mbsncpy_s--_mbsncpy_s_l.md)   
 [strrchr, wcsrchr, _mbsrchr, _mbsrchr_l](../vs140/strrchr--wcsrchr--_mbsrchr--_mbsrchr_l.md)   
 [_strset, _strset_l, _wcsset, _wcsset_l, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)   
 [strspn, wcsspn, _mbsspn, _mbsspn_l](../vs140/strspn--wcsspn--_mbsspn--_mbsspn_l.md)