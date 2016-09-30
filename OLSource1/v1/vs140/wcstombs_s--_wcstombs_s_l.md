---
title: "wcstombs_s, _wcstombs_s_l"
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
  - "_wcstombs_s_l"
  - "wcstombs_s"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcstombs_s"
  - "_wcstombs_s_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcstombs_s function"
  - "string conversion, wide characters"
  - "wide characters, converting"
  - "_wcstombs_s_l function"
  - "wcstombs_s_l function"
  - "characters, converting"
  - "string conversion, multibyte character strings"
ms.assetid: 105f2d33-221a-4f6d-864c-23c1865c42af
caps.latest.revision: 33
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# wcstombs_s, _wcstombs_s_l
Converts a sequence of wide characters to a corresponding sequence of multibyte characters. A version of [wcstombs](../vs140/wcstombs--_wcstombs_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of characters converted.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The address of a buffer for the resulting converted multibyte character string.  
  
 [in]<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size in bytes of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> buffer.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to the wide character string to be converted.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The maximum number of bytes to store in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> buffer, not including the terminating null character, or [_TRUNCATE](../vs140/_truncate.md).  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Zero if successful, an error code on failure.  
  
|Error condition|Return value and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|---------------------|------------------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> > 0|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|The destination buffer is too small to contain the converted string (unless <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>; see Remarks below)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
 If any of these conditions occurs, the invalid parameter exception is invoked as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the function returns an error code and sets <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> as indicated in the table.  
  
## Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function converts a string of wide characters pointed to by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> into multibyte characters stored in the buffer pointed to by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The conversion will continue for each character until one of these conditions is met:  
  
-   A null wide character is encountered  
  
-   A wide character that cannot be converted is encountered  
  
-   The number of bytes stored in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> buffer equals <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The destination string is always null-terminated (even in the case of an error).  
  
 If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is the special value [_TRUNCATE](../vs140/_truncate.md), then <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> converts as much of the string as will fit into the destination buffer, while still leaving room for a null terminator.  
  
 If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> successfully converts the source string, it puts the size in bytes of the converted string, including the null terminator, into <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> (provided <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>). This occurs even if the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and provides a way to determine the required buffer size. Note that if <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is ignored.  
  
 If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> encounters a wide character it cannot convert to a multibyte character, it puts 0 in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, sets the destination buffer to an empty string, sets <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, and returns <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 If the sequences pointed to by <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is undefined.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> do not overlap, and that <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> correctly reflects the number of wide characters to convert.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior; <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Convert wide-character string:**  
 **Characters converted: 14**  
 **Multibyte character: Hello, world.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wctomb_s, _wctomb_s_l](../vs140/wctomb_s--_wctomb_s_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)