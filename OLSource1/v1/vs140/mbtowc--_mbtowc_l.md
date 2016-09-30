---
title: "mbtowc, _mbtowc_l"
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
  - "mbtowc"
  - "_mbtowc_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbtowc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbtowc function"
  - "_mbtowc_l function"
  - "mbtowc_l function"
ms.assetid: dfd1c8a7-e73a-4307-9353-53b70b45d4d1
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbtowc, _mbtowc_l
Convert a multibyte character to a corresponding wide character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *wchar*  
 Address of a wide character (type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Address of a sequence of bytes (a multibyte character).  
  
 *count*  
 Number of bytes to check.  
  
 *locale*  
 The locale to use.  
  
## Return Value  
 If **mbchar** is not **NULL** and if the object that <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> points to forms a valid multibyte character, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the length in bytes of the multibyte character. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **NULL** or the object that it points to is a wide-character null character (L'\0'), the function returns 0. If the object that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> points to does not form a valid multibyte character within the first *count* characters, it returns –1.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function converts *count* or fewer bytes pointed to by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is not **NULL**, to a corresponding wide character. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> stores the resulting wide character at *wchar,* if *wchar* is not **NULL**. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> does not examine more than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> bytes. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> uses the current locale for locale-dependent behavior; <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is identical except that it uses the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<stdlib.h>|  
|**_mbtowc_l**|\<stdlib.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [wctomb, _wctomb_l](../vs140/wctomb--_wctomb_l.md)