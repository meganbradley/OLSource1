---
title: "c16rtomb, c32rtomb"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "c16rtomb"
  - "c32rtomb"
apilocation: 
  - "api-ms-win-crt-convert-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "c16rtomb"
  - "c32rtomb"
  - "uchar/c16rtomb"
  - "uchar/c32rtomb"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "c16rtomb function"
  - "c32rtomb function"
ms.assetid: 7f5743ca-a90e-4e3f-a310-c73e16f4e14d
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# c16rtomb, c32rtomb
Convert a UTF-16 or UTF-32 wide character into a multibyte character in the current locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an array to store the multibyte converted character.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A wide character to convert.  
  
 [in, out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Return Value  
 The number of bytes stored in array object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, including any shift sequences. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not a valid wide character, the value (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>)(-1) is returned, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the value of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is unspecified.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function converts the UTF-16 character <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to the equivalent multibyte narrow character sequence in the current locale. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not a null pointer, the function stores the converted sequence in the array object pointed to by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Up to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes are stored in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to the resulting multibyte shift state.    If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a null wide character, a sequence required to restore the initial shift state is stored, if needed, followed by the null character, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is set to the initial conversion state. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function is identical, but converts a UTF-32 character.  
  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a null pointer, the behavior is equivalent to a call to the function that substitutes an internal buffer for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and a wide null character for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> conversion state object allows you to make subsequent calls to this function and other restartable functions that maintain the shift state of the multibyte output characters. Results are undefined when you mix the use of restartable and non-restartable functions, or if a call to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is made between restartable function calls.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|C, C++: \<uchar.h>|  
  
 For compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [mbrtoc16, mbrtoc32](../vs140/mbrtoc16--mbrtoc32.md)   
 [wcrtomb](../vs140/wcrtomb.md)   
 [wcrtomb_s](../vs140/wcrtomb_s.md)