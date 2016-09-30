---
title: "wcsrtombs_s"
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
  - "wcsrtombs_s"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcsrtombs_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "string conversion, wide characters"
  - "wcsrtombs_s function"
  - "wide characters, strings"
ms.assetid: 9dccb766-113c-44bb-9b04-07a634dddec8
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcsrtombs_s
Convert a wide character string to its multibyte character string representation. A version of [wcsrtombs](../vs140/wcsrtombs.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of characters converted.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The address of a buffer for the resulting converted multibyte character string.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The size in bytes of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> buffer.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to the wide character string to be converted.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The maximum number of bytes to be stored in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> buffer, or [_TRUNCATE](../vs140/_truncate.md).  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> conversion state object.  
  
## Return Value  
 Zero if successful, an error code on failure.  
  
|Error condition|Return value and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|---------------------|------------------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> > 0|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|The destination buffer is too small to contain the converted string (unless <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; see Remarks below)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 If any of these conditions occurs, the invalid parameter exception is invoked as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the function returns an error code and sets <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> as indicated in the table.  
  
## Remarks  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function converts a string of wide characters pointed to by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> into multibyte characters stored in the buffer pointed to by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, using the conversion state contained in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. The conversion will continue for each character until one of these conditions is met:  
  
-   A null wide character is encountered  
  
-   A wide character that cannot be converted is encountered  
  
-   The number of bytes stored in the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> buffer equals <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The destination string is always null-terminated (even in the case of an error).  
  
 If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is the special value [_TRUNCATE](../vs140/_truncate.md), then <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> converts as much of the string as will fit into the destination buffer, while still leaving room for a null terminator.  
  
 If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> successfully converts the source string, it puts the size in bytes of the converted string, including the null terminator, into <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> (provided <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>). This occurs even if the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> argument is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and provides a way to determine the required buffer size. Note that if <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is ignored.  
  
 If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> encounters a wide character it cannot convert to a multibyte character, it puts -1 in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, sets the destination buffer to an empty string, sets <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 If the sequences pointed to by <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is undefined. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is affected by the LC_TYPE category of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> do not overlap, and that <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> correctly reflects the number of wide characters to convert.  
  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> function differs from [wcstombs_s](../vs140/wcstombs_s--_wcstombs_s_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions. For example, an application would use <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> rather than <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, if a subsequent call to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> were used instead of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Exceptions  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> function is multithread safe as long as no function in the current thread calls <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> while this function is executing and the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is null.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The string was successfully converted.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [wcrtomb](../vs140/wcrtomb.md)   
 [wcrtomb_s](../vs140/wcrtomb_s.md)   
 [wctomb](../vs140/wctomb--_wctomb_l.md)   
 [wcstombs, _wcstombs_l](../vs140/wcstombs--_wcstombs_l.md)   
 [mbsinit](../vs140/mbsinit.md)