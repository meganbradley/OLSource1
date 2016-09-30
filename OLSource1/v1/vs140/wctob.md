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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Value to translate.  
  
## Return Value  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> successfully converts a wide character, it returns its multibyte character representation, only if the multibyte character is exactly one byte long. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> encounters a wide character it cannot convert to a multibyte character or the multibyte character is not exactly one byte long, it returns a –1.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function converts a wide character contained in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to the corresponding multibyte character passed by the return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value, if the multibyte character is exactly one byte long.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> was unsuccessful and no corresponding multibyte character was found, the function sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and returns -1.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program illustrates the behavior of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Determined the corresponding multibyte character to be "A".**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)   
 [WideCharToMultiByte](http://msdn.microsoft.com/library/windows/desktop/dd374130)