---
title: "_mbsnbset_s, _mbsnbset_s_l"
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
  - "_mbsnbset_s_l"
  - "_mbsnbset_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbset_s"
  - "_mbsnbset_s_l"
  - "_mbsnbset_s"
  - "mbsnbset_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcsnset_s function"
  - "mbsnbset_s function"
  - "mbsnbset_s_l function"
  - "_mbsnbset_s_l function"
  - "_tcsnset_s_l function"
  - "_mbsnbset_s function"
  - "_tcsnset_s function"
  - "tcsnset_s_l function"
ms.assetid: 811f92c9-cc31-4bbd-8017-2d1bfc6fb96f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbset_s, _mbsnbset_s_l
Sets the first <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> bytes of a multibyte-character string to a specified character. These versions of [_mbsnbset, _mbsnbset_l](../vs140/_mbsnbset--_mbsnbset_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 String to be altered.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the string buffer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Single-byte or multibyte-character setting.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of bytes to be set.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Zero if successful; otherwise, an error code.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> functions set, at most, the first <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bytes of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is greater than the length of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the length of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is used instead of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a multibyte character and cannot be set entirely into the last byte that's specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the last byte is padded with a blank character. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> do not place a terminating null at the end of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> resemble <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, except that they set <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> bytes rather than <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is zero, this function generates an invalid parameter exception, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. Also, if <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is not a valid multibyte character, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and a space is used instead.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> version of this function uses the current locale for this locale-dependent behavior; the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> version is identical except that it instead uses the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, use of these functions is simplified by template overloads; the overloads can infer buffer length automatically and thereby eliminate the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
 **Before: This is a test**  
**After:  \*\*\*\* is a test**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_strnset, _wcsnset, _mbsnset, _mbsnset_l](../vs140/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)