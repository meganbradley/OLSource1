---
title: "strtod, _strtod_l, wcstod, _wcstod_l"
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
  - "wcstod"
  - "_wcstod_l"
  - "_strtod_l"
  - "strtod"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcstod"
  - "strtod"
  - "wcstod"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcstod_l function"
  - "tcstod_l function"
  - "_tcstod_l function"
  - "strtod function"
  - "_wcstod_l function"
  - "wcstod function"
  - "strtod_l function"
  - "tcstod function"
  - "_tcstod function"
  - "_strtod_l function"
  - "string conversion, to floating point values"
ms.assetid: 0444f74a-ba2a-4973-b7f0-1d77ba88c6ed
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtod, _strtod_l, wcstod, _wcstod_l
Convert strings to a double-precision value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to character that stops scan.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the value of the floating-point number, except when the representation would cause an overflow, in which case the function returns +/–<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The sign of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> matches the sign of the value that cannot be represented. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns 0 if no conversion can be performed or an underflow occurs.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For both functions, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if overflow or underflow occurs and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on this and other return codes.  
  
## Remarks  
 Each function converts the input string <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to a double-precision value. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> stops reading the string <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> at the first character it cannot recognize as part of a number. This may be the terminating null character. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument is a wide-character string. These functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category setting of the current locale determines recognition of the radix character in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>*;* for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The functions without the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> suffix use the current locale; <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location pointed to by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is stored at the location pointed to by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>] [ {<CodeContentPlaceHolder>46\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>}[<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is either plus (<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>) or minus (<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>); and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> are one or more decimal digits. If no digits appear before the radix character, at least one must appear after the radix character. The decimal digits can be followed by an exponent, which consists of an introductory letter (<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>) and an optionally signed integer. If neither an exponent part nor a radix character appears, a radix character is assumed to follow the last digit in the string. The first character that does not fit this form stops the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **string = 3.1415926This stopped it**  
 **strtod = 3.141593**  
 **Stopped scan at: This stopped it**  
**string = -10110134932This stopped it**  
 **strtol = -2147483648**  
 **Stopped scan at: This stopped it**  
**string = 10110134932**  
 **strtol = 45 (base 2)**  
 **Stopped scan at: 34932**  
 **strtol = 4423 (base 4)**  
 **Stopped scan at: 4932**  
 **strtol = 2134108 (base 8)**  
 **Stopped scan at: 932**   
## .NET Framework Equivalent  
 [System::Convert::ToDouble](https://msdn.microsoft.com/en-us/library/system.convert.todouble.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [Locale](../vs140/locale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md)   
 [strtoul, _strtoul_l, wcstoul, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [localeconv](../vs140/localeconv.md)   
 [_create_locale](../vs140/_create_locale--_wcreate_locale.md)   
 [_free_locale](../vs140/_free_locale.md)