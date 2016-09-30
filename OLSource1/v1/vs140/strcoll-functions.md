---
title: "strcoll Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strcoll"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "code pages, using for string comparisons"
  - "string comparison [C++], culture-specific"
  - "strcoll functions"
  - "strings [C++], comparing by code page"
ms.assetid: c09eeff3-8aba-4cfb-a524-752436d85573
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strcoll Functions
Each of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions compares two strings according to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> category setting of the locale code page currently in use. Each of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions compares two strings according to the multibyte code page currently in use. Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions for string comparisons when there is a difference between the character set order and the lexicographic character order in the current code page and this difference is of interest for the comparison. Use the corresponding <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> functions to test only for string equality.  
  
### strcoll Functions  
  
|SBCS|Unicode|MBCS|Description|  
|----------|-------------|----------|-----------------|  
|[strcoll](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md)|[wcscoll](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md)|[_mbscoll](../vs140/strcoll--wcscoll--_mbscoll--_strcoll_l--_wcscoll_l--_mbscoll_l.md)|Collate two strings|  
|[_stricoll](../vs140/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md)|[_wcsicoll](../vs140/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md)|[_mbsicoll](../vs140/_stricoll--_wcsicoll--_mbsicoll--_stricoll_l--_wcsicoll_l--_mbsicoll_l.md)|Collate two strings (case insensitive)|  
|[_strncoll](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|[_wcsncoll](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|[_mbsncoll](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|Collate first <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> characters of two strings|  
|[_strnicoll](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|[_wcsnicoll](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|[_mbsnicoll](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|Collate first <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> characters of two strings (case-insensitive)|  
  
## Remarks  
 The single-byte character (SBCS) versions of these functions (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) compare <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> according to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> category setting of the current locale. These functions differ from the corresponding <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions in that the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions use locale code page information that provides collating sequences. For string comparisons in locales in which the character set order and the lexicographic character order differ, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> functions should be used rather than the corresponding <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> functions. For more information on <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, see [setlocale](../vs140/setlocale--_wsetlocale.md).  
  
 For some code pages and corresponding character sets, the order of characters in the character set may differ from the lexicographic character order. In the "C" locale, this is not the case: the order of characters in the ASCII character set is the same as the lexicographic order of the characters. However, in certain European code pages, for example, the character 'a' (value 0x61) precedes the character 'ä' (value 0xE4) in the character set, but the character 'ä' precedes the character 'a' lexicographically. To perform a lexicographic comparison in such an instance, use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Alternatively, you can use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> on the original strings, then use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> on the resulting strings.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> automatically handle multibyte-character strings according to the locale code page currently in use, as do their wide-character (Unicode) counterparts. The multibyte-character (MBCS) versions of these functions, however, collate strings on a character basis according to the multibyte code page currently in use.  
  
 Because the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> functions collate strings lexicographically for comparison, whereas the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> functions simply test for string equality, the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> functions are much slower than the corresponding <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> versions. Therefore, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functions should be used only when there is a difference between the character set order and the lexicographic character order in the current code page and this difference is of interest for the string comparison.  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [localeconv](../vs140/localeconv.md)   
 [_mbsnbcoll, _mbsnbcoll_l, _mbsnbicoll, _mbsnbicoll_l](../vs140/_mbsnbcoll--_mbsnbcoll_l--_mbsnbicoll--_mbsnbicoll_l.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [strcmp, wcscmp, _mbscmp](../vs140/strcmp--wcscmp--_mbscmp.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [strxfrm, wcsxfrm, _strxfrm_l, _wcsxfrm_l](../vs140/strxfrm--wcsxfrm--_strxfrm_l--_wcsxfrm_l.md)