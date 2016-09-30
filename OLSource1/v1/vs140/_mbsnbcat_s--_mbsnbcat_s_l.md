---
title: "_mbsnbcat_s, _mbsnbcat_s_l"
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
  - "_mbsnbcat_s_l"
  - "_mbsnbcat_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbsnbcat_s"
  - "mbsnbcat_s"
  - "_mbsnbcat_s_l"
  - "mbsnbcat_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tcsncat function"
  - "mbsnbcat_s function"
  - "_mbsnbcat_s function"
  - "_mbsnbcat_s_l function"
  - "_tcsncat_s_l function"
  - "tcsncat_s_l function"
  - "mbsnbcat_s_l function"
  - "tcsncat function"
ms.assetid: 2c9e9be7-d979-4a54-8ada-23428b6648a9
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbcat_s, _mbsnbcat_s_l
Appends to a multibyte character string, at most, the first <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> bytes of another multibyte-character string. These are versions of [_mbsnbcat](../vs140/_mbsnbcat--_mbsnbcat_l.md) that have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated multibyte-character destination string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> buffer in bytes.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Null-terminated multibyte-character source string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of bytes from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to append to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Zero if successful; otherwise, an error code.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Return value|  
|------------|-------------------|-----------|------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|any|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|Any|<= 0|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|Any|any|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
  
 If any of the error conditions occurs, the function generates an invalid parameter error, as described in [Parameter Validation](../vs140/parameter-validation.md). If the error is handled, the function returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function appends to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, at most, the first <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> bytes of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If the byte that immediately precedes the null character in <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a lead byte, it is overwritten by the initial byte of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Otherwise, the initial byte of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> overwrites the terminating null character of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. If a null byte appears in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> before <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> bytes are appended, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> appends all bytes from <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, up to the null character. If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is greater than the length of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the length of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is used in place of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The resulting string is terminated by a null character. If copying takes place between strings that overlap, the behavior is undefined.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that the ones that don't have the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> suffix use the current locale and the ones that do have the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> suffix instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, the use of these functions is simplified by template overloads; the overloads can infer buffer length automatically and thereby eliminate the need to specify a size argument, and they can automatically use their newer, more secure functions to replace older, less-secure functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|[strncat](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|[wcsncat](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcmp, _mbsnbcmp_l](../vs140/_mbsnbcmp--_mbsnbcmp_l.md)   
 [_mbsnbcnt, _mbsnbcnt_l, _mbsnccnt, _mbsnccnt_l, _strncnt, _wcsncnt](../vs140/_strncnt--_wcsncnt--_mbsnbcnt--_mbsnbcnt_l--_mbsnccnt--_mbsnccnt_l.md)   
 [_mbsnbcpy, _mbsnbcpy_l](../vs140/_mbsnbcpy--_mbsnbcpy_l.md)   
 [_mbsnbcpy_s, _mbsnbcpy_s_l](../vs140/_mbsnbcpy_s--_mbsnbcpy_s_l.md)   
 [_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md)   
 [strncat, _strncat_l, wcsncat, _wcsncat_l, _mbsncat _mbsncat_l](../vs140/strncat--_strncat_l--wcsncat--_wcsncat_l--_mbsncat--_mbsncat_l.md)   
 [strncat_s, _strncat_s_l, wcsncat_s, _wcsncat_s_l, _mbsncat_s, _mbsncat_s_l](../vs140/strncat_s--_strncat_s_l--wcsncat_s--_wcsncat_s_l--_mbsncat_s--_mbsncat_s_l.md)