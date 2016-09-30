---
title: "wcsrtombs"
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
  - "wcsrtombs"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcsrtombs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcsrtombs function"
  - "string conversion, wide characters"
  - "wide characters, strings"
ms.assetid: a8d21fec-0d36-4085-9d81-9b1c61c7259d
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcsrtombs
Convert a wide character string to its multibyte character string representation. A more secure version of this function is available; see [wcsrtombs_s](../vs140/wcsrtombs_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resulting converted multibyte character string's address location.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indirectly points to the location of the wide character string to be converted.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of character to be converted.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> conversion state object.  
  
## Return Value  
 Returns the number of bytes successfully converted, not including the null terminating null byte (if any), otherwise a -1 if an error occurred.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function converts a string of wide characters, beginning in the specified conversion state contained in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, from the values indirect pointed to in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, into the address of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The conversion will continue for each character until: after a null terminating wide character is encountered, when a non corresponding character is encountered or when the next character would exceed the limit contained in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> encounters the wide-character null character (L'\0') either before or when <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> occurs, it converts it to an 8-bit 0 and stops.  
  
 Thus, the multibyte character string at <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is null-terminated only if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> encounters a wide character null character during conversion. If the sequences pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is undefined. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is affected by the LC_TYPE category of the current locale.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function differs from [wcstombs](../vs140/wcstombs--_wcstombs_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions.  For example, an application would use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, if a subsequent call to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> were used instead of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 If the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns the required size in bytes of the destination string. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is null, the internal <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> conversion state is used. If the character sequence <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> does not have a corresponding multibyte character representation, a -1 is returned and the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 In C++, this function has a template overload that invokes the newer, secure counterpart of this function. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Exceptions  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> function is multithread safe as long as no function in the current thread calls <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> while this function is executing and the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is not null.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The string was successfuly converted.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [wcrtomb](../vs140/wcrtomb.md)   
 [wcrtomb_s](../vs140/wcrtomb_s.md)   
 [wctomb](../vs140/wctomb--_wctomb_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [mbsinit](../vs140/mbsinit.md)