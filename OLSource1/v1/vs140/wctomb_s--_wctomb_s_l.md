---
title: "wctomb_s, _wctomb_s_l"
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
  - "_wctomb_s_l"
  - "wctomb_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wctomb_s"
  - "_wctomb_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wctomb_s function"
  - "wctomb_s_l function"
  - "string conversion, wide characters"
  - "wide characters, converting"
  - "_wctomb_s_l function"
  - "characters, converting"
  - "string conversion, multibyte character strings"
ms.assetid: 7e94a888-deed-4dbd-b5e9-d4a0455538b8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wctomb_s, _wctomb_s_l
Converts a wide character to the corresponding multibyte character. A version of [wctomb](../vs140/wctomb--_wctomb_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of bytes, or a code indicating the result.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The address of a multibyte character.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the buffer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A wide character.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Zero if successful, an error code on failure.  
  
 Error Conditions  
  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Return value|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|--------------|-------------------|------------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|>0|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|not modified|  
|any|><CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|not modified|  
|any|too small|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|not modified|  
  
 If any of the above error conditions occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function converts its <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument to the corresponding multibyte character and stores the result at <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. You can call the function from any point in any program.  
  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> converts the wide character to a multibyte character, it puts the number of bytes (which is never greater than <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>) in the wide character into the integer pointed to by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is the wide-character null character (L'\0'), <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> fills <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> with 1. If the target pointer <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is NULL, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> puts 0 in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. If the conversion is not possible in the current locale, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> puts –1 in <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> uses the current locale for locale-dependent information; <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Convert a wide character:**  
 **Characters converted: 1**  
 **Multibyte character: a**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [_mbclen, mblen, _mblen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)