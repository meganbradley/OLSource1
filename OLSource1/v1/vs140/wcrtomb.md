---
title: "wcrtomb"
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
  - "wcrtomb"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcrtomb"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wide characters, converting"
  - "wcrtomb function"
  - "multibyte characters"
  - "characters, converting"
ms.assetid: 717f1b21-2705-4b7f-b6d0-82adc5224340
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcrtomb
Convert a wide character into its multibyte character representation. A more secure version of this function is available; see [wcrtomb_s](../vs140/wcrtomb_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The resulting multibyte converted character.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A wide character to convert.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Return Value  
 Returns the number of bytes required to represent the converted multibyte character, otherwise a -1 if an error occurs.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function converts a wide character, beginning in the specified conversion state contained in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, from the value contained in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, into the address represented by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The return value is the number of bytes required to represent the corresponding multibyte character, but it will not return more than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bytes.  
  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is null, the internal <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object containing the conversion state of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is used. If the character sequence <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not have a corresponding multibyte character representation, a -1 is returned and the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function differs from [wctomb](../vs140/wctomb--_wctomb_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions. For example, an application would use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, if a subsequent call to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> were used instead of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 In C++, this function has a template overload that invokes the newer, secure counterparts of this function. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Exceptions  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function is multithread safe as long as no function in the current thread calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> while this function is executing and while the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is null.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The corresponding wide character "Q" was converted to the "Q" multibyte character.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [mbsinit](../vs140/mbsinit.md)