---
title: "mbstowcs, _mbstowcs_l"
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
  - "mbstowcs"
  - "_mbstowcs_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbstowcs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbstowcs_l function"
  - "mbstowcs_l function"
  - "mbstowcs function"
ms.assetid: 96696b27-e068-4eeb-8006-3f7a0546ae6d
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbstowcs, _mbstowcs_l
Converts a sequence of multibyte characters to a corresponding sequence of wide characters. More secure versions of these functions are available; see [mbstowcs_s, _mbstowcs_s_l](../vs140/mbstowcs_s--_mbstowcs_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The address of a sequence of wide characters.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The address of a sequence of null terminated multibyte characters.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum number of multibyte characters to convert.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> successfully converts the source string, it returns the number of converted multibyte characters. If the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the function returns the required size (in wide characters) of the destination string. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> encounters an invalid multibyte character, it returns –1. If the return value is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the wide-character string is not null-terminated.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> do not overlap, and that <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> correctly reflects the number of multibyte characters to convert.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function converts up to a maximum number of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> multibyte characters pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to a string of corresponding wide characters that are determined by the current locale. It stores the resulting wide-character string at the address represented by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>*.* The result is similar to a series of calls to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> encounters the single-byte null character ('\0') either before or when <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> occurs, it converts the null character to a wide-character null character (L'\0') and stops. Thus the wide-character string at <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is null-terminated only if a null character is encountered during conversion. If the sequences pointed to by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> overlap, the behavior is undefined.  
  
 If the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returns the number of wide characters that would result from conversion, not including a null terminator. The source string must be null-terminated for the correct value to be returned. If you need the resulting wide character string to be null-terminated, add one to the returned value.  
  
 If the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is > <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, errno is set to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and the function returns -1.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior; <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Locale information set to Japanese_Japan.932**  
**Convert to multibyte string:**  
 **Required Size: 4**  
 **Number of bytes written to multibyte string: 4**  
 **Hex values of the  multibyte characters: 0x82 0xa0 0x82 0xa1**  
 **Codepage 932 uses 0x81 to 0x9f as lead bytes.**  
**Convert back to wide-character string:**  
 **Characters converted: 2**  
 **Hex value of first 2 wide characters: 0x3042 0x3043**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)   
 [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072)