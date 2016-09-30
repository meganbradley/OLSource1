---
title: "wctomb, _wctomb_l"
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
  - "_wctomb_l"
  - "wctomb"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wctomb"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "string conversion, wide characters"
  - "wide characters, converting"
  - "_wctomb_l function"
  - "wctomb function"
  - "wctomb_l function"
  - "characters, converting"
  - "string conversion, multibyte character strings"
ms.assetid: 4a543f0e-5516-4d81-8ff2-3c5206f02ed5
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wctomb, _wctomb_l
Convert a wide character to the corresponding multibyte character. More secure versions of these functions are available; see [wctomb_s, _wctomb_s_l](../vs140/wctomb_s--_wctomb_s_l.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The address of a multibyte character.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A wide character.  
  
## Return Value  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> converts the wide character to a multibyte character, it returns the number of bytes (which is never greater than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) in the wide character. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the wide-character null character (L'\0'), <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns 1. If the target pointer <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is NULL, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns 0. If the conversion is not possible in the current locale, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns –1 and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function converts its <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument to the corresponding multibyte character and stores the result at <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. You can call the function from any point in any program. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior; <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> validates its parameters. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and the function returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the wctomb function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Convert a wide character:**  
 **Characters converted: 1**  
 **Multibyte character: a**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [_mbclen, mblen, _mblen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)