---
title: "strtoimax, _strtoimax_l, wcstoimax, _wcstoimax_l"
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
  - "wcstoimax"
  - "_wcstoimax_l"
  - "_strtoimax_l"
  - "strtoimax"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcstoimax"
  - "_tcstoimax"
  - "strtoimax"
  - "_wcstoimax_l"
  - "_strtoimax_l"
  - "_tcstoimax_l"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strtoimax funciton"
  - "conversion functions"
  - "_strtoimax_l function"
  - "_wcstoimax_l function"
  - "wcstoimax function"
ms.assetid: 4530d3dc-aaac-4a76-b7cf-29ae3c98d0ae
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strtoimax, _strtoimax_l, wcstoimax, _wcstoimax_l
Converts a string to an integer value of the largest supported signed integer type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Null-terminated string to convert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the character that stops the scan.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number base to use.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the value that's represented in the string <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, except when the representation would cause an overflow—in that case, it returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The function returns 0 if no conversion can be performed. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> returns values analogously to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are defined in stdint.h.  
  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is nonzero and either less than 2 or greater than 36, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 For more information about return codes, see [errno, _doserrno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function converts <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The wide-character version of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; its <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> argument is a wide-character string. Otherwise, these functions behave identically. Both functions stop reading the string <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> at the first character they cannot recognize as part of a number. This may be the terminating null character, or it may be the first numeric character that's greater than or equal to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The locale's <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> category setting determines recognition of the radix character in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>; for more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The functions that don't have the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> suffix use the current locale; <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are identical to the corresponding functions that don't have the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> suffix except that they instead use the locale that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is not <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, a pointer to the character that stopped the scan is stored at the location that's pointed to by <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. If no conversion can be performed (no valid digits were found or an invalid base was specified), the value of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is stored at the location that's pointed to by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> expects <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to point to a string of the following form:  
  
 [<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>] [{<CodeContentPlaceHolder>50\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>}] [<CodeContentPlaceHolder>52\</CodeContentPlaceHolder> [{ <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> }]] [<CodeContentPlaceHolder>55\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>]  
  
 A <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> may consist of space and tab characters, which are ignored; <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> are one or more decimal digits; <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> are one or more of the letters 'a' through 'z' (or 'A' through 'Z'). The first character that does not fit this form stops the scan. If <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is between 2 and 36, then it is used as the base of the number. If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is 0, the initial characters of the string pointed to by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> are used to determine the base. If the first character is '0' and the second character is not 'x' or 'X', the string is interpreted as an octal integer. If the first character is '0' and the second character is 'x' or 'X', the string is interpreted as a hexadecimal integer. If the first character is '1' through '9', the string is interpreted as a decimal integer. The letters 'a' through 'z' (or 'A' through 'Z') are assigned the values 10 through 35; only letters whose assigned values are less than <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> are permitted. The first character outside the range of the base stops the scan. For example, if <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is 0 and the first character scanned is '0', an octal integer is assumed and an '8' or '9' character would stop the scan.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|\<inttypes.h>|  
  
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
 [strtoumax](../vs140/strtoumax--_strtoumax_l--wcstoumax--_wcstoumax_l.md)   
 [atof, _atof_l, _wtof, _wtof_l](../vs140/atof--_atof_l--_wtof--_wtof_l.md)