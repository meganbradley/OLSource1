---
title: "_strtoi64, _wcstoi64, _strtoi64_l, _wcstoi64_l"
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
  - "_strtoi64"
  - "_strtoi64_l"
  - "_wcstoi64_l"
  - "_wcstoi64"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_strtoi64"
  - "strtoi64"
  - "_stroi64_l"
  - "_wcstoi64_l"
  - "wcstoi64_l"
  - "_wcstoi64"
  - "wcstoi64"
  - "strtoi64_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_strtoi64 function"
  - "_wcstoi64 function"
  - "_strtoi64_l function"
  - "string conversion, to integers"
  - "_wcstoi64_l function"
  - "strtoi64_l function"
  - "wcstoi64 function"
  - "strtoi64 function"
  - "wcstoi64_l function"
ms.assetid: ea2abc50-7bfe-420e-a46b-703c3153593a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strtoi64, _wcstoi64, _strtoi64_l, _wcstoi64_l
Convert a string to an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to character that stops scan.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number base to use.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the value represented in the string <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, except when the representation would cause an overflow, in which case it returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The function will return 0 if no conversion can be performed. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are defined in LIMITS.H.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is nonzero and either less than 2 or greater than 36, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>function converts <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Both functions stop reading the string <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> at the first character they cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character greater than or equal to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> argument is a wide-character string. These functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 The locale's <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> category setting determines recognition of the radix character in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>*;* for more information, see [setlocale](../vs140/setlocale--_wsetlocale.md). The functions without the _l suffix use the current locale; <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and<CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are identical to the corresponding function without the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> suffix except that they use the locale passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location pointed to by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is stored at the location pointed to by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> are one or more decimal digits. The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is 0, the initial characters of the string pointed to by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> are used to determine the base. If the first character is 0 and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character will stop the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtod, _strtod_l, wcstod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)   
 [strtoul, _strtoul_l, wcstoul, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)