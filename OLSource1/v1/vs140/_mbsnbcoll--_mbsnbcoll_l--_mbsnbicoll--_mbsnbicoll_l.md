---
title: "_mbsnbcoll, _mbsnbcoll_l, _mbsnbicoll, _mbsnbicoll_l"
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
  - "_mbsnbicoll_l"
  - "_mbsnbcoll_l"
  - "_mbsnbcoll"
  - "_mbsnbicoll"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbicoll"
  - "mbsnbcoll"
  - "mbsnbicoll_l"
  - "_mbsnbcoll"
  - "_mbsnbicoll"
  - "_ftcsnicoll"
  - "_ftcsncoll"
  - "mbsnbcoll_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbsnbcoll_l function"
  - "mbsnbcoll_l function"
  - "_mbsnbcoll function"
  - "_tcsnicoll function"
  - "mbsnbcoll function"
  - "mbsnbicoll_l function"
  - "mbsnbicoll function"
  - "_tcsncoll function"
  - "_mbsnbicoll function"
  - "_mbsnbicoll_l function"
  - "tcsncoll function"
  - "tcsnicoll function"
ms.assetid: d139ed63-ccba-4458-baa2-61cbcef03e94
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcoll, _mbsnbcoll_l, _mbsnbicoll, _mbsnbicoll_l
Compares <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> bytes of two multibyte-character strings by using multibyte code-page information.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Strings to compare.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of bytes to compare.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 The return value indicates the relation of the substrings of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> substring less than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> substring.|  
|0|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> substring identical to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> substring.|  
|> 0|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> substring greater than <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> substring.|  
  
 If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. To use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, include either String.h or Mbstring.h.  
  
## Remarks  
 Each of these functions collates, at most, the first <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> bytes in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and returns a value indicating the relationship between the resulting substrings of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If the final byte in the substring of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a lead byte, it is not included in the comparison; these functions compare only complete characters in the substrings. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is a case-insensitive version of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. Like <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> collate the two multibyte-character strings according to the lexicographic order specified by the multibyte [code page](../vs140/code-pages.md) currently in use.  
  
 For some code pages and corresponding character sets, the order of characters in the character set might differ from the lexicographic character order. In the "C" locale, this is not the case: the order of characters in the ASCII character set is the same as the lexicographic order of the characters. However, in certain European code pages, for example, the character 'a' (value 0x61) precedes the character 'ä' (value 0xE4) in the character set, but the character 'ä' precedes the character 'a' lexicographically. To perform a lexicographic comparison of strings by bytes in such an instance, use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>; to check only for string equality, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 Because the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> functions collate strings lexicographically for comparison, whereas the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> functions simply test for string equality, the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> functions are much slower than the corresponding <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> versions. Therefore, the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> functions should be used only when there is a difference between the character set order and the lexicographic character order in the current code page and this difference is of interest for the comparison.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|[_strncoll](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|[_wcsncoll](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|[_strncoll_l](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|[_wcsncoll_l](../vs140/_strncoll--_wcsncoll--_mbsncoll--_strncoll_l--_wcsncoll_l--_mbsncoll_l.md)|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|[_strnicoll](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|[_wcsnicoll](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|[_strnicoll_l](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|[_wcsnicoll_l](../vs140/_strnicoll--_wcsnicoll--_mbsnicoll--_strnicoll_l--_wcsnicoll_l--_mbsnicoll_l.md)|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_mbsnbicmp, _mbsnbicmp_l](../vs140/_mbsnbicmp--_mbsnbicmp_l.md)   
 [strcoll Functions](../vs140/strcoll-functions.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)