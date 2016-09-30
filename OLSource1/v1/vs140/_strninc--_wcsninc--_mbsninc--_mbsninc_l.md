---
title: "_strninc, _wcsninc, _mbsninc, _mbsninc_l"
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
  - "_mbsninc"
  - "_mbsninc_l"
  - "_wcsninc"
  - "_strninc"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "strninc"
  - "wcsninc"
  - "mbsninc_l"
  - "_strninc"
  - "_tcsninc"
  - "mbsninc"
  - "_mbsninc_l"
  - "_ftcsninc"
  - "_wcsninc"
  - "_mbsninc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbsninc_l function"
  - "mbsninc function"
  - "_strninc function"
  - "tcsninc function"
  - "wcsninc function"
  - "_mbsninc function"
  - "strninc function"
  - "_wcsninc function"
  - "mbsninc_l function"
  - "_tcsninc function"
ms.assetid: 6caace64-f9e4-48c0-afa8-ea51824ad723
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strninc, _wcsninc, _mbsninc, _mbsninc_l
Advances a string pointer by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> characters.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Source string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters to increment a string pointer.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these routines returns a pointer to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> after <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has been incremented by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> characters or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if the supplied pointer is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is greater than or equal to the number of characters in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the result is undefined.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function increments <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> multibyte characters. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the [multibyte code page](../vs140/code-pages.md) currently in use.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> are single-byte–character string and wide-character string versions of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are provided only for this mapping and should not be used otherwise. For more information, see [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md) and [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is identical except that it uses the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<tchar.h>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<tchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbsdec, _mbsdec_l, _strdec, _wcsdec](../vs140/_strdec--_wcsdec--_mbsdec--_mbsdec_l.md)   
 [_mbsinc, _mbsinc_l, _strinc, _wcsinc](../vs140/_strinc--_wcsinc--_mbsinc--_mbsinc_l.md)   
 [_mbsnextc, _mbsnextc_l, _strnextc, _wcsnextc](../vs140/_strnextc--_wcsnextc--_mbsnextc--_mbsnextc_l.md)