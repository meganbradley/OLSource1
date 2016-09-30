---
title: "strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l"
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
  - "strxfrm"
  - "_wcsxfrm_l"
  - "_strxfrm_l"
  - "wcsxfrm"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strxfrm"
  - "_tcsxfrm"
  - "wcsxfrm"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "strxfrm_l function"
  - "_tcsxfrm function"
  - "_strxfrm_l function"
  - "strxfrm function"
  - "wcsxfrm_l function"
  - "wcsxfrm function"
  - "string comparison [C++], transforming strings"
  - "tcsxfrm function"
  - "strings [C++], comparing locale"
  - "_wcsxfrm_l function"
ms.assetid: 6ba8e1f6-4484-49aa-83b8-bc2373187d9e
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l
Transform a string based on locale-specific information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Destination string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Source string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Maximum number of characters to place in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>*.*  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Returns the length of the transformed string, not counting the terminating null character. If the return value is greater than or equal to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the content of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is unpredictable. On an error, each function sets <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For an invalid character, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function transforms the string pointed to by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> into a new collated form that is stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. No more than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> characters, including the null character, are transformed and placed into the resulting string. The transformation is made using the locale's <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> category setting. For more information on <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, see [setlocale](../vs140/setlocale--_wsetlocale.md). <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> uses the current locale for its locale-dependent behavior; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead of the current locale. For more information, see [Locale](../vs140/locale.md).  
  
 After the transformation, a call to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> with the two transformed strings yields results identical to those of a call to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> applied to the original two strings. As with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> automatically handles multibyte-character strings as appropriate.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>; the string arguments of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are wide-character pointers. For <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, after the string transformation, a call to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> with the two transformed strings yields results identical to those of a call to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> applied to the original two strings. <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> behave identically otherwise. <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> uses the current locale for its locale-dependent behavior; <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> uses the locale passed in instead of the current locale.  
  
 These functions validate their parameters. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is a null pointer, or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a NULL pointer (unless count is zero), or if <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions set <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
  
 In the "C" locale, the order of the characters in the character set (ASCII character set) is the same as the lexicographic order of the characters. However, in other locales, the order of characters in the character set may differ from the lexicographic character order. For example, in certain European locales, the character 'a' (value 0x61) precedes the character '&\#x00E4;' (value 0xE4) in the character set, but the character 'ä' precedes the character 'a' lexicographically.  
  
 In locales for which the character set and the lexicographic character order differ, use <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> on the original strings and then <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> on the resulting strings to produce a lexicographic string comparison according to the current locale's <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> category setting. Thus, to compare two strings lexicographically in the above locale, use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> on the original strings, then <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> on the resulting strings. Alternately, you can use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> on the original strings.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is basically a wrapper around [LCMapString](http://msdn.microsoft.com/library/windows/desktop/dd318700) with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
 The value of the following expression is the size of the array needed to hold the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> transformation of the source string:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the "C" locale only, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is equivalent to the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|\<string.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [Locale](../vs140/locale.md)   
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)