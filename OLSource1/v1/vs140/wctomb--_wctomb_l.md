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
  
```  
int wctomb(  
   char *mbchar,  
   wchar_t wchar   
);  
int _wctomb_l(  
   char *mbchar,  
   wchar_t wchar,  
   _locale_t locale  
);  
```  
  
#### Parameters  
 `mbchar`  
 The address of a multibyte character.  
  
 `wchar`  
 A wide character.  
  
## Return Value  
 If `wctomb` converts the wide character to a multibyte character, it returns the number of bytes (which is never greater than `MB_CUR_MAX`) in the wide character. If `wchar` is the wide-character null character (L'\0'), `wctomb` returns 1. If the target pointer `mbchar` is NULL, `wctomb` returns 0. If the conversion is not possible in the current locale, `wctomb` returns –1 and `errno` is set to `EILSEQ`.  
  
## Remarks  
 The `wctomb` function converts its `wchar` argument to the corresponding multibyte character and stores the result at `mbchar`. You can call the function from any point in any program. `wctomb` uses the current locale for any locale-dependent behavior; `_wctomb_l` is identical to `wctomb` except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 `wctomb` validates its parameters. If `mbchar` is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, `errno` is set to `EINVAL` and the function returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`wctomb`|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the wctomb function.  
  
```  
// crt_wctomb.cpp  
// compile with: /W3  
#include <stdio.h>  
#include <stdlib.h>  
  
int main( void )  
{  
   int i;  
   wchar_t wc = L'a';  
   char *pmb = (char *)malloc( MB_CUR_MAX );  
  
   printf( "Convert a wide character:\n" );  
   i = wctomb( pmb, wc ); // C4996  
   // Note: wctomb is deprecated; consider using wctomb_s  
   printf( "   Characters converted: %u\n", i );  
   printf( "   Multibyte character: %.1s\n\n", pmb );  
}  
```  
  
 **Convert a wide character:**  
 **Characters converted: 1**  
 **Multibyte character: a**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [_mbclen, mblen, _mblen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)