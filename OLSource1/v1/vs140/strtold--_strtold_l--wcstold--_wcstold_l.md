---
title: "strtold, _strtold_l, wcstold, _wcstold_l"
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
  - "wcstold"
  - "strtold"
  - "_strtold_l"
  - "_wcstold_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcstold_l"
  - "_wcstold_l"
  - "_tcstold"
  - "strtold"
  - "_strtold_l"
  - "wcstold"
dev_langs: 
  - "C++"
ms.assetid: 928c0c9a-bc49-445b-8822-100eb5954115
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtold, _strtold_l, wcstold, _wcstold_l
Converts strings to a long double-precision floating-point value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the character that stops the scan.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the value of the floating-point number as a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, except when the representation would cause an overflow—in that case, the function returns +/–<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The sign of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> matches the sign of the value that cannot be represented. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns 0 if no conversion can be performed or an underflow occurs.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For both functions, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if overflow or underflow occurs and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each function converts the input string <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a long double-precision value. <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> stops reading the string <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> at the first character it cannot recognize as part of a number. This may be the terminating null character. The wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise, these functions behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> category setting of the current locale determines the recognition of the radix character in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. For more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The functions without the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffix use the current locale; <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> except that they instead use the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location that's pointed to by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is stored at the location that's pointed to by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>] [ {<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>}[<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is either plus (<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>) or minus (<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>); and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are one or more decimal digits. If no digits appear before the radix character, at least one must appear after the radix character. The decimal digits can be followed by an exponent, which consists of an introductory letter (<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>) and an optionally signed integer. If neither an exponent part nor a radix character appears, a radix character is assumed to follow the last digit in the string. The first character that does not fit this form stops the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **string = 3.1415926535898This stopped it**  
 **strtold = 3.1415926535898**  
 **Stopped scan at: This stopped it**   
## .NET Framework Equivalent  
 [System::Convert::ToDouble](https://msdn.microsoft.com/en-us/library/system.convert.todouble.aspx)  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [Locale](../vs140/locale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)   
 [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md)   
 [strtoul, _strtoul_l, wcstoul, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)   
 [localeconv](../vs140/localeconv.md)   
 [_create_locale](../vs140/_create_locale--_wcreate_locale.md)   
 [_free_locale](../vs140/_free_locale.md)