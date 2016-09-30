---
title: "mbstowcs_s, _mbstowcs_s_l"
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
  - "_mbstowcs_s_l"
  - "mbstowcs_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbstowcs_s_l"
  - "mbstowcs_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbstowcs_s_l function"
  - "mbstowcs_s function"
  - "mbstowcs_s_l function"
ms.assetid: 2fbda953-6918-498f-b440-3e7b21ed65a4
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbstowcs_s, _mbstowcs_s_l
Converts a sequence of multibyte characters to a corresponding sequence of wide characters. Versions of [mbstowcs](../vs140/mbstowcs--_mbstowcs_l.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of characters converted.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of buffer for the resulting converted wide character string.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> buffer in words.  
  
 [in]<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The address of a sequence of null terminated multibyte characters.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The maximum number of wide characters to store in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> buffer, not including the terminating null, or [_TRUNCATE](../vs140/_truncate.md).  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 Zero if successful, an error code on failure.  
  
|Error condition|Return value and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|---------------------|------------------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> > 0|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|The destination buffer is too small to contain the converted string (unless <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>; see Remarks below)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> == 0|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
  
 If any of these conditions occurs, the invalid parameter exception is invoked as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the function returns an error code and sets <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> as indicated in the table.  
  
## Remarks  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function converts a string of multibyte characters pointed to by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> into wide characters stored in the buffer pointed to by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The conversion will continue for each character until one of these conditions is met:  
  
-   A multibyte null character is encountered  
  
-   An invalid multibyte character is encountered  
  
-   The number of wide characters stored in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> buffer equals <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 The destination string is always null-terminated (even in the case of an error).  
  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is the special value [_TRUNCATE](../vs140/_truncate.md), then <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> converts as much of the string as will fit into the destination buffer, while still leaving room for a null terminator.  
  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> successfully converts the source string, it puts the size in wide characters of the converted string, including the null terminator, into <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (provided <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>). This occurs even if the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and provides a way to determine the required buffer size. Note that if <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is ignored, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> must be 0.  
  
 If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> encounters an invalid multibyte character, it puts 0 in <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, sets the destination buffer to an empty string, sets <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and returns <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 If the sequences pointed to by <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is undefined.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> do not overlap, and that <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> correctly reflects the number of multibyte characters to convert.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior; <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)