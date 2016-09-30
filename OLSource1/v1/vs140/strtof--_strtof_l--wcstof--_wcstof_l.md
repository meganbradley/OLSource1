---
title: "strtof, _strtof_l, wcstof, _wcstof_l"
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
  - "_strtof_l"
  - "wcstof"
  - "strtof"
  - "_wcstof_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tcstof"
  - "wcstof"
  - "_wcstof_l"
  - "_tcstof_l"
  - "_strtof_l"
  - "strtof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_strtof_l function"
  - "_tcstof function"
  - "_wcstof_l function"
  - "wcstof function"
  - "_tcstof_l function"
  - "strtof function"
ms.assetid: 52221b46-876d-4fcc-afb1-97512c17a43b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtof, _strtof_l, wcstof, _wcstof_l
Converts strings to a single-precision floating-point value.  
  
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
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the value of the floating-point number, except when the representation would cause an overflow, in which case the function returns +/–<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The sign of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> matches the sign of the value that cannot be represented. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns 0 if no conversion can be performed or an underflow occurs.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For both functions, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if overflow or underflow occurs and the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md).  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 Each function converts the input string <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to a single-precision value. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> stops reading the string <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> at the first character it cannot recognize as part of a number. This may be the terminating null character. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise, these functions behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category setting of the current locale determines recognition of the radix character in <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>; for more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The functions that don't have the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> suffix use the current locale; the ones that have the suffix are identical except that they use the locale that's passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location that's pointed to by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is stored at the location that's pointed to by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>] [ {<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>}[<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>]<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is either plus (<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>) or minus (<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>); and <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> are one or more decimal digits. If no digits appear before the radix character, at least one must appear after the radix character. The decimal digits can be followed by an exponent, which consists of an introductory letter (<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>) and an optionally signed integer. If neither an exponent part nor a radix character appears, a radix character is assumed to follow the last digit in the string. The first character that does not fit this form stops the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **string = 3.14159This stopped it**  
 **strtof = 3.141590**  
 **Stopped scan at: This stopped it**   
## .NET Framework Equivalent  
 [System::Convert::ToSingle](https://msdn.microsoft.com/en-us/library/system.convert.tosingle.aspx)  
  
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