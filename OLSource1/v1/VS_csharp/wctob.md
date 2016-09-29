---
title: "wctob"
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
  - "wctob"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wctob"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wide characters, converting"
  - "wctob function"
  - "characters, converting"
ms.assetid: 46aec98b-c2f2-4e9d-9d89-7db99ba8a9a6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wctob
Determines if a wide character corresponds to a multibyte character and returns its multibyte character representation.  
  
## Syntax  
  
```  
int wctob(  
   wint_t wchar  
);  
```  
  
#### Parameters  
 `wchar`  
 Value to translate.  
  
## Return Value  
 If `wctob` successfully converts a wide character, it returns its multibyte character representation, only if the multibyte character is exactly one byte long. If `wctob` encounters a wide character it cannot convert to a multibyte character or the multibyte character is not exactly one byte long, it returns a –1.  
  
## Remarks  
 The `wctob` function converts a wide character contained in `wchar` to the corresponding multibyte character passed by the return `int` value, if the multibyte character is exactly one byte long.  
  
 If `wctob` was unsuccessful and no corresponding multibyte character was found, the function sets `errno` to `EILSEQ` and returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`wctob`|<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the `wcstombs` function.  
  
```  
// crt_wctob.c  
#include <stdio.h>  
#include <wchar.h>  
  
int main( void )  
{  
    int     bChar = 0;  
    wint_t  wChar = 0;  
  
    // Set the corresponding wide character to exactly one byte.  
    wChar = (wint_t)'A';  
  
    bChar = wctob( wChar );  
    if (bChar == WEOF)  
    {  
        printf( "No corresponding multibyte character was found.\n");  
    }  
    else  
    {  
        printf( "Determined the corresponding multibyte character to"  
                " be \"%c\".\n", bChar);  
    }  
}  
  
```  
  
 **Determined the corresponding multibyte character to be "A".**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../VS_csharp/data-conversion.md)   
 [Locale](../VS_csharp/locale.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../VS_csharp/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../VS_csharp/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../VS_csharp/mbtowc--_mbtowc_l.md)   
 [wctomb, _wctomb_l](../VS_csharp/wctomb--_wctomb_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)