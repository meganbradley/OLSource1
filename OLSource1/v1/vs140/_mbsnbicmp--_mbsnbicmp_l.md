---
title: "_mbsnbicmp, _mbsnbicmp_l"
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
  - "_mbsnbicmp_l"
  - "_mbsnbicmp"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_strnicmp"
  - "_wcsnicmp_l"
  - "_mbsnbicmp"
  - "mbsnbicmp"
  - "mbsnbicmp_l"
  - "_tcsnicmp"
  - "_strnicmp_l"
  - "_tcsnicmp_l"
  - "_wcsnicmp"
  - "_mbsnbicmp_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tcsnicmp_l function"
  - "_strnicmp function"
  - "mbsnbicmp_l function"
  - "_wcsnicmp_l function"
  - "_mbsnbicmp function"
  - "_mbsnbicmp_l function"
  - "_tcsnicmp function"
  - "_strnicmp_l function"
  - "mbsnbicmp function"
  - "_wcsnicmp function"
ms.assetid: ddb44974-8b0c-42f0-90d0-56c9350bae0c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbicmp, _mbsnbicmp_l
Compares <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> bytes of two multibyte-character strings, and ignores case.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated strings to compare.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of bytes to compare.  
  
## Return Value  
 The return value indicates the relationship between the substrings.  
  
|Return value|Description|  
|------------------|-----------------|  
|< 0|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> substring less than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> substring.|  
|0|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> substring identical to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> substring.|  
|> 0|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> substring greater than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> substring.|  
  
 On an error, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which is defined in String.h and Mbstring.h.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function performs an ordinal comparison of at most the first <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> bytes of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The comparison is performed by converting each character to lowercase; <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a case-sensitive version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. The comparison ends if a terminating null character is reached in either string before <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> characters are compared. If the strings are equal when a terminating null character is reached in either string before <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> characters are compared, the shorter string is lesser.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  is similar to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, except that it compares strings up to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> bytes instead of by characters.  
  
 Two strings containing characters located between 'Z' and 'a' in the ASCII table ('[', '\\', ']', '^', '_', and '\<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>ABCDE<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>ABCD^<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>abcde<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>abcd^<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>ABCDE<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>ABCD^<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>_mbsnbicmp<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>string1<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>string2<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>_mbsnbicmp<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>_NLSCMPERROR<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>errno<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>EINVAL<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>_tcsnicmp<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>_strnicmp<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>_mbsnbicmp<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>_wcsnicmp<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>_tcsnicmp_l<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>_strnicmp_l<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>_mbsnbicmp_l<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>_wcsnicmp_l<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>_mbsnbicmp<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_stricmp, _wcsicmp, _mbsicmp, _stricmp_l, _wcsicmp_l, _mbsicmp_l](../vs140/_stricmp--_wcsicmp--_mbsicmp--_stricmp_l--_wcsicmp_l--_mbsicmp_l.md)