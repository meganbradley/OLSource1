---
title: "strtoll, _strtoll_l, wcstoll, _wcstoll_l"
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
  - "strtoll"
  - "wcstoll"
  - "_strtoll_l"
  - "_wcstoll_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_strtoll_l"
  - "_tcstoll_l"
  - "_tcstoll"
  - "_wcstoll_l"
  - "strtoll"
  - "wcstoll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_tcstoll_l function"
  - "_wcstoll_l function"
  - "strtoll function"
  - "wcstoll function"
  - "_tcstoll function"
  - "_strtoll_l function"
ms.assetid: e2d05dcf-d3b2-4291-9e60-dee77e540fd7
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtoll, _strtoll_l, wcstoll, _wcstoll_l
Converts a string to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the character that stops the scan.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Number base to use.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the value that's represented in the string <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, except when the representation would cause an overflow—in that case, it returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The function returns 0 if no conversion can be performed. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are defined in LIMITS.H.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is nonzero and either less than 2 or greater than 36, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Both functions stop reading the string <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> at the first character they cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character that's greater than or equal to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise, these functions behave identically.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
  
 The locale's <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> category setting determines recognition of the radix character in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>; for more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The functions that don't have the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> suffix use the current locale; <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> are identical to the corresponding functions that don't have the suffix, except that they instead use the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location that's pointed to by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is stored at the location that's pointed to by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>53\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> are one or more decimal digits; <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> are one or more of the letters 'a' through 'z' (or 'A' through 'Z'). The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is 0, the initial characters of the string that's pointed to by <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> are used to determine the base. If the first character is '0' and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character stops the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [localeconv](../vs140/localeconv.md)   
 [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md)   
 [String to Numeric Value Functions](../vs140/string-to-numeric-value-functions.md)   
 [strtod, _strtod_l, wcstod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md)   
 [strtol](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md)   
 [strtoul, _strtoul_l, wcstoul, _wcstoul_l](../vs140/strtoul--_strtoul_l--wcstoul--_wcstoul_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)