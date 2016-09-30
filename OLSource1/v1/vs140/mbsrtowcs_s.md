---
title: "mbsrtowcs_s"
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
  - "mbsrtowcs_s"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsrtowcs_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsrtowcs_s function"
ms.assetid: 4ee084ec-b15d-4e5a-921d-6584ec3b5a60
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbsrtowcs_s
Convert a multibyte character string in the current locale to its wide character string representation. A version of [mbsrtowcs](../vs140/mbsrtowcs.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of characters converted.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of buffer to store the resulting converted wide character string.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in words (wide characters).  
  
 [in, out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Indirect pointer to the location of the multibyte character string to be converted.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The maximum number of wide characters to store in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> buffer, not including the terminating null, or [_TRUNCATE](../vs140/_truncate.md).  
  
 [in, out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> conversion state object. If this value is a null pointer, a static internal conversion state object is used. Because the internal <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is not thread-safe, we recommend that you always pass your own <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.  
  
## Return Value  
 Zero if conversion is successful, or an error code on failure.  
  
|Error condition|Return value and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|---------------------|------------------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a null pointer and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> > 0|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a null pointer|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|The string indirectly pointed to by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> contains a multibyte sequence that is not valid for the current locale.|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|The destination buffer is too small to contain the converted string (unless <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; for more information, see Remarks)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
  
 If any one of these conditions occurs, the invalid parameter exception is invoked as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, the function returns an error code and sets <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> as indicated in the table.  
  
## Remarks  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function converts a string of multibyte characters indirectly pointed to by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> into wide characters stored in the buffer pointed to by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, by using the conversion state contained in <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The conversion will continue for each character until one of these conditions is met:  
  
-   A multibyte null character is encountered  
  
-   An invalid multibyte character is encountered  
  
-   The number of wide characters stored in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> buffer equals <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 The destination string <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is always null-terminated, even in the case of an error, unless <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is a null pointer.  
  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is the special value [_TRUNCATE](../vs140/_truncate.md), <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> converts as much of the string as will fit into the destination buffer, while still leaving room for a null terminator.  
  
 If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> successfully converts the source string, it puts the size in wide characters of the converted string and the null terminator into <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, provided <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is not a null pointer. This occurs even if the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> argument is a null pointer and lets you determine the required buffer size. Note that if <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a null pointer, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is ignored.  
  
 If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is not a null pointer, the pointer object pointed to by <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is assigned a null pointer if conversion stopped because a terminating null character was reached. Otherwise, it is assigned the address just past the last multibyte character converted, if any. This allows a subsequent function call to restart conversion where this call stopped.  
  
 If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is a null pointer, the library internal <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> conversion state static object is used. Because this internal static object is not thread-safe, we recommend that you pass your own <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value.  
  
 If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> encounters a multibyte character that is not valid in the current locale, it puts -1 in <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, sets the destination buffer <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to an empty string, sets <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, and returns <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 If the sequences pointed to by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> overlap, the behavior of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is undefined. <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is affected by the LC_TYPE category of the current locale.  
  
> [!IMPORTANT]
>  Ensure that <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> do not overlap, and that <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> correctly reflects the number of multibyte characters to convert.  
  
 The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> function differs from [mbstowcs_s](../vs140/mbstowcs_s--_mbstowcs_s_l.md) by its restartability. The conversion state is stored in <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions. For example, an application should use <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, if a subsequent call to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is used instead of <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
 In C++, using this function is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the requirement to specify a size argument) and they can automatically replace older, non-secure functions by using their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Exceptions  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> function is multithread safe if no function in the current thread calls <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> as long as this function is executing and the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> argument is not a null pointer.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|\<wchar.h>|  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [mbrtowc](../vs140/mbrtowc.md)   
 [mbtowc, _mbtowc_l](../vs140/mbtowc--_mbtowc_l.md)   
 [mbstowcs_s, _mbstowcs_s_l](../vs140/mbstowcs_s--_mbstowcs_s_l.md)   
 [mbsinit](../vs140/mbsinit.md)