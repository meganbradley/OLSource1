---
title: "wcrtomb_s"
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
  - "wcrtomb_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcrtomb_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wide characters, converting"
  - "wcrtomb_s function"
  - "multibyte characters"
  - "characters, converting"
ms.assetid: 9a8a1bd0-1d60-463d-a3a2-d83525eaf656
caps.latest.revision: 24
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# wcrtomb_s
Convert a wide character into its multibyte character representation. A version of [wcrtomb](../vs140/wcrtomb.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Returns the number of bytes written or -1 if an error occurred.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The resulting multibyte converted character.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable in bytes.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A wide character to convert.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns zero or an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> value if an error occurs.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function converts a wide character, beginning in the specified conversion state contained in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, from the value contained in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, into the address represented by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> value will be the number of bytes converted, but no more than <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes, or an -1 if an error occurred.  
  
 If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is null, the internal <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> conversion state is used. If the character contained in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does not have a corresponding multibyte character, the value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> will be -1 and the function will return the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function differs from [wctomb_s](../vs140/wctomb_s--_wctomb_s_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions. For example, an application would use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, if a subsequent call to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> were used instead of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 In C++, using this function is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Exceptions  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function is multithread safe as long as no function in the current thread calls <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> while this function is executing and the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is null.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The corresponding wide character "Q" was converted to a the "Q" multibyte character.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [mbsinit](../vs140/mbsinit.md)