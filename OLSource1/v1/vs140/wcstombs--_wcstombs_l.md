---
title: "wcstombs, _wcstombs_l"
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
  - "wcstombs"
  - "_wcstombs_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcstombs"
  - "_wcstombs_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wcstombs_l function"
  - "wcstombs function"
  - "string conversion, wide characters"
  - "wide characters, converting"
  - "wcstombs_l function"
  - "characters, converting"
  - "string conversion, multibyte character strings"
ms.assetid: 91234252-9ea1-423a-af99-e9d0ce4a40e3
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcstombs, _wcstombs_l
Converts a sequence of wide characters to a corresponding sequence of multibyte characters. More secure versions of these functions are available; see [wcstombs_s, _wcstombs_s_l](../vs140/wcstombs_s--_wcstombs_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The address of a sequence of multibyte characters.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The address of a sequence of wide characters.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum number of bytes that can be stored in the multibyte output string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> successfully converts the multibyte string, it returns the number of bytes written into the multibyte output string, excluding the terminating <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (if any). If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns the required size in bytes of the destination string. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> encounters a wide character it cannot convert to a multibyte character, it returns –1 cast to type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function converts the wide-character string pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to the corresponding multibyte characters and stores the results in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> array. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter indicates the maximum number of bytes that can be stored in the multibyte output string (that is, the size of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>). In general, it is not known how many bytes will be required when converting a wide-character string. Some wide characters will require only one byte in the output string; others require two. If there are two bytes in the multibyte output string for every wide character in the input string (including the wide character <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), the result is guaranteed to fit.  
  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> encounters the wide-character null character (L'\0') either before or when <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> occurs, it converts it to an 8-bit 0 and stops. Thus, the multibyte character string at <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is null-terminated only if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> encounters a wide-character null character during conversion. If the sequences pointed to by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is undefined.  
  
 If the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> returns the required size in bytes of the destination string.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is greater than<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, this function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the function sets <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and returns -1.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior; <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Convert wide-character string:**  
 **Characters converted: 13**  
 **Multibyte character: Hello, world.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [_mbclen, mblen, _mblen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)