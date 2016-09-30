---
title: "_mbsnbcmp, _mbsnbcmp_l"
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
  - "_mbsnbcmp"
  - "_mbsnbcmp_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbcmp"
  - "tcsnbmp"
  - "_mbsnbcmp_l"
  - "mbsnbcmp_l"
  - "_mbsnbcmp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsnbcmp_l function"
  - "mbsnbcmp function"
  - "tcsncmp function"
  - "_mbsnbcmp_l function"
  - "_tcsncmp function"
  - "_mbsnbcmp function"
ms.assetid: dbc99e50-cf85-4e57-a13f-067591f18ac8
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcmp, _mbsnbcmp_l
Compares the first <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> bytes of two multibyte-character strings.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The strings to compare.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of bytes to compare.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 The return value indicates the ordinal relationship between the substrings of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> substring is less than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> substring.|  
|0|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> substring is identical to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> substring.|  
|> 0|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> substring is greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> substring.|  
  
 On a parameter validation error, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> return <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, which is defined in \<string.h> and \<mbstring.h>.  
  
## Remarks  
 The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> functions compare at most the first <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> bytes in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and return a value that indicates the relationship between the substrings. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a case-sensitive version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Unlike <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is not affected by the collation order of the locale. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the current multibyte [code page](../vs140/code-pages.md).  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> resembles <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, except that <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> compares strings by characters rather than by bytes.  
  
 The output value is affected by the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category setting of the locale, which specifies the lead bytes and trailing bytes of multibyte characters. For more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> function uses the current locale for this locale-dependent behavior. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> function is identical except that it uses the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter instead. For more information, see [Locale](../vs140/locale.md).  
  
 If either <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is a null pointer, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and  _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|---------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|[strncmp](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|[wcsncmp](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|[strncmp](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|[wcsncmp](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbicmp, _mbsnbicmp_l](../vs140/_mbsnbicmp--_mbsnbicmp_l.md)   
 [strncmp, wcsncmp, _mbsncmp, _mbsncmp_l](../vs140/strncmp--wcsncmp--_mbsncmp--_mbsncmp_l.md)   
 [_strnicmp, _wcsnicmp, _mbsnicmp, _strnicmp_l, _wcsnicmp_l, _mbsnicmp_l](../vs140/_strnicmp--_wcsnicmp--_mbsnicmp--_strnicmp_l--_wcsnicmp_l--_mbsnicmp_l.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)