---
title: "mbrtowc"
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
  - "mbrtowc"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbrtowc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbrtowc function"
ms.assetid: a1e87fcc-6de0-4ca1-bf26-508d28490286
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbrtowc
Convert a multibyte character in the current locale into the equivalent wide character, with the capability of restarting in the middle of a multibyte character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Address of a wide character to receive the converted wide character string (type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>). This value can be a null pointer if no return wide character is required.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Address of a sequence of bytes (a multibyte character).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of bytes to check.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to conversion state object. If this value is a null pointer, the function uses a static internal conversion state object. Because the internal <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is not thread-safe, we recommend that you always pass your own <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument.  
  
## Return Value  
 One of the following values:  
  
 0  
 The next <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or fewer bytes complete the multibyte character that represents the null wide character, which is stored in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not a null pointer.  
  
 1 to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, inclusive  
 The next <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or fewer bytes complete a valid multibyte character. The value returned is the number of bytes that complete the multibyte character. The wide character equivalent is stored in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not a null pointer.  
  
 (size_t)(-1)  
 An encoding error occurred. The next <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or fewer bytes do not contribute to a complete and valid multibyte character. In this case, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is set to EILSEQ and the conversion shift state in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is unspecified.  
  
 (size_t)(-2)  
 The next <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> bytes contribute to an incomplete but potentially valid multibyte character, and all <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> bytes have been processed. No value is stored in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, but <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is updated to restart the function.  
  
## Remarks  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer, the function is equivalent to the call:  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 In this case, the value of the arguments <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are ignored.  
  
 If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is not a null pointer, the function examines <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> bytes from <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to determine the required number of bytes that are required to complete the next multibyte character. If the next character is valid, the corresponding multibyte character is stored in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if it is not a null pointer. If the character is the corresponding wide null character, the resulting state of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is the initial conversion state.  
  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function differs from [mbtowc](../vs140/mbtowc--_mbtowc_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions.  For example, an application should use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> if a subsequent call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is used instead of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
## Example  
 Converts a multibyte character to its wide character equivalent.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)