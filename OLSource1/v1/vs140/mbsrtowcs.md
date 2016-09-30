---
title: "mbsrtowcs"
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
  - "mbsrtowcs"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsrtowcs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsrtowcs function"
ms.assetid: f3a29de8-e36e-425b-a7fa-a258e6d7909d
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbsrtowcs
Converts a multibyte character string in the current locale to a corresponding wide character string, with the capability of restarting in the middle of a multibyte character. A more secure version of this function is available; see [mbsrtowcs_s](../vs140/mbsrtowcs_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address to store the resulting converted wide character string.  
  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indirect pointer to the location of the multibyte character string to convert.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The maximum number of characters (not bytes) to convert and store in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in, out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> conversion state object. If this value is a null pointer, a static internal conversion state object is used. Because the internal <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is not thread-safe, we recommend that you always pass your own <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
## Return Value  
 Returns the number of characters successfully converted, not including the terminating null character, if any. Returns (size_t)(-1) if an error occurred, and sets <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to EILSEQ.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function converts a string of multibyte characters indirectly pointed to by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, into wide characters stored in the buffer pointed to by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, by using the conversion state contained in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The conversion continues for each character until either a terminating null multibyte character is encountered, a multibyte sequence that does not correspond to a valid character in the current locale is encountered, or until <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> characters have been converted. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> encounters the multibyte null character ('\0') either before or when <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> occurs, it converts it to a 16-bit terminating null character and stops.  
  
 Thus, the wide character string at <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is null-terminated only if <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> encounters a multibyte null character during conversion. If the sequences pointed to by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is undefined. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is affected by the LC_TYPE category of the current locale.  
  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function differs from [mbstowcs](../vs140/mbstowcs--_mbstowcs_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions.  For example, an application should use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, if a subsequent call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is used instead of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not a null pointer, the pointer object pointed to by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is assigned a null pointer if conversion stopped because a terminating null character was reached. Otherwise, it is assigned the address just past the last multibyte character converted, if any. This allows a subsequent function call to restart conversion where this call stopped.  
  
 If the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> argument is a null pointer, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument is ignored and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> returns the required size in wide characters for the destination string. If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is a null pointer, the function uses a non-thread-safe static internal <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> conversion state object. If the character sequence <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> does not have a corresponding multibyte character representation, a -1 is returned and the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> isa null pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and returns -1.  
  
 In C++, this function has a template overload that invokes the newer, secure counterpart of this function. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Exceptions  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function is multithread safe as long as no function in the current thread calls <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> as long as this function is executing and the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> argument is not a null pointer.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [mbrtowc](../vs140/mbrtowc.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [mbstowcs, _mbstowcs_l](../vs140/mbstowcs--_mbstowcs_l.md)   
 [mbsinit](../vs140/mbsinit.md)